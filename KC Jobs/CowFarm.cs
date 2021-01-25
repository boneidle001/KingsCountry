using BlockTypes;
using Jobs;
using NPC;
using Pipliz;
using Recipes;
using System.Collections.Generic;


namespace CowFarm
{
    [AreaJobDefinitionAutoLoader]
    public class CowFarm : AbstractFarmAreaJobDefinition
    {
        public string NPCTypeString { get; protected set; }
        public float Cooldown { get; set; } = 6.8f;

        public CowFarm()
        {
            Identifier = "kc.cowfarm";
            NPCTypeString = "kc.cowfarmer";
            UsedNPCType = NPCType.GetByKeyNameOrDefault(NPCTypeString);
            MaxGathersPerRun = 10;
            JobRequiresSeeds = false;
            Stages = new ushort[] {
                ItemTypes.IndexLookup.GetIndex("cowstage1")
            };
        }

        public override IAreaJob CreateAreaJob(Colony owner, Vector3Int min, Vector3Int max, bool isLoaded, int npcID = 0)
        {
            return new CowFarmerJob(this, owner, min, max, npcID);
        }

        public class CowFarmerJob : AbstractAreaJob
        {
            // store cowLocation separately from positionSub because the farmer will move next to these positions(they're not equal)
            protected Vector3Int cowLocation = Vector3Int.invalidPos;

            static readonly ItemTypes.ItemType[] yTypesBuffer = new ItemTypes.ItemType[5]; // max 3 Y + 1 below + 1 above
            static readonly List<Vector3Int> cowPositions = new List<Vector3Int>();
            static readonly List<RecipeResult> GatherResults = new List<RecipeResult>();

            public int GatheredCount { get; set; }

            public CowFarmerJob(AbstractAreaJobDefinition def, Colony owner, Vector3Int min, Vector3Int max, int npcID = 0) : base(def, owner, min, max, npcID) { }

            public override void CalculateSubPosition()
            {
                ThreadManager.AssertIsMainThread();
                Vector3Int min = Minimum;
                Vector3Int max = Maximum;
                int ySize = max.y - min.y + 1;

                cowPositions.Clear();
                for (int x = min.x + 1; x < max.x; x += 3)
                {
                    for (int z = min.z + 1; z < max.z; z += 3)
                    {
                        cowPositions.Add(new Vector3Int(x, 0, z));
                    }
                }

                while (cowPositions.Count > 0)
                {
                    int idx = Random.Next(0, cowPositions.Count);
                    Vector3Int pos = cowPositions[idx];
                    cowPositions.RemoveAt(idx);

                    if (!World.TryGetColumn(new Vector3Int(pos.x, min.y - 1, pos.z), ySize + 2, yTypesBuffer))
                    {
                        goto DUMB_RANDOM;
                    }

                    for (int y = 0; y < ySize; y++)
                    {
                        ItemTypes.ItemType typeBelow = yTypesBuffer[y];
                        ItemTypes.ItemType type = yTypesBuffer[y + 1];
                        ItemTypes.ItemType typeAbove = yTypesBuffer[y + 2];

                        if (
                            (type == BuiltinBlocks.Types.air || type == ItemTypes.GetType("cowstage1") || type == ItemTypes.GetType("cowstage2") || type == ItemTypes.GetType("cowstage3") || type == ItemTypes.GetType("cowstage4"))
                            && typeBelow.IsFertile
                        )
                        {
                            cowLocation = new Vector3Int(pos.x, min.y + y, pos.z);
                            if (type == BuiltinBlocks.Types.air || type == ItemTypes.GetType("cowstage1") || type == ItemTypes.GetType("cowstage2") || type == ItemTypes.GetType("cowstage3") || type == ItemTypes.GetType("cowstage4"))
                            {
                                cowLocation = new Vector3Int(pos.x, min.y + y, pos.z);
                                if (AI.PathingManager.TryGetClosestPositionWorldNotAt(cowLocation, NPC.Position, out bool canStand, out Vector3Int canStandLocation) && canStand)
                                {
                                    positionSub = canStandLocation;
                                }
                                else
                                {
                                    positionSub = cowLocation;
                                }
                                return;
                            }
                        }
                    }

                    // none of the spots were viable cow locations (???)

                    DUMB_RANDOM:
                    cowLocation = Vector3Int.invalidPos;
                    positionSub = min.Add(
                        Random.Next(0, (max.x - min.x) / 3) * 3,
                        (max.y - min.y) / 2,
                        Random.Next(0, (max.z - min.z) / 3) * 3
                    );
                }
            }

            public override void OnNPCAtJob(ref NPCBase.NPCState state)
                
            {
                CowFarm def = (CowFarm)Definition;

                ThreadManager.AssertIsMainThread();
                state.JobIsDone = true;
                positionSub = Vector3Int.invalidPos;

                                
                if (!cowLocation.IsValid)
                { // probably idling about
                    state.SetCooldown(Random.NextFloat(8f, 16f));
                    return;
                }

                if (!World.TryGetTypeAt(cowLocation, out ushort type))
                {
                    state.SetCooldown(10.0);
                    return;
                }

                if (type == ItemTypes.IndexLookup.GetIndex("cowstage1"))
                { // gather milk
                    
                    {
                        NPC.Inventory.Add(ItemTypes.IndexLookup.GetIndex("milk"),5);
                        state.SetCooldown(5);
                        state.JobIsDone = true;
                        shouldDumpInventory = true;
                    }
                    return;
                     
                }

                else if (type == ItemTypes.IndexLookup.GetIndex("cowstage2"))
                { // gather milk
                    
                    {
                        NPC.Inventory.Add (ItemTypes.IndexLookup.GetIndex("milk"),10);
                        state.SetCooldown(10);
                        state.JobIsDone = true;
                        shouldDumpInventory = true;
                    }
                    return;

                }

                else if (type == ItemTypes.IndexLookup.GetIndex("cowstage3"))
                { // gather milk

                    {
                        NPC.Inventory.Add(ItemTypes.IndexLookup.GetIndex("milk"),20);
                        state.SetCooldown(15);
                        state.JobIsDone = true;
                        shouldDumpInventory = true;
                    }
                    return;
                }

                else if (type == ItemTypes.IndexLookup.GetIndex("cowstage4"))
                {// butcher cow!
                    
                    {

                        NPC.Inventory.Add(ItemTypes.IndexLookup.GetIndex("cowcarcass"), 2);
                        state.SetCooldown(5);
                        ServerManager.TryChangeBlock(cowLocation, BuiltinBlocks.Indices.air);
                        state.JobIsDone = true;
                        shouldDumpInventory = true;
                    }
                    return;
                }
                
                 else if (type == BuiltinBlocks.Indices.air)
                { // maybe have a cow?
                    if (World.TryGetTypeAt(cowLocation.Add(0, -1, 0), out ItemTypes.ItemType typeBelow))
                    {
                        if (typeBelow.IsFertile)
                        {
                            ServerManager.TryChangeBlock(cowLocation, ItemTypes.GetType("cowstage1"), Owner);
                            state.SetCooldown(2.0);
                            return;
                        }
                    }
                    else
                    {
                        state.SetCooldown(10.0);
                        return;
                    }
                }
                else
                {
                    // very likely it's a cow, so idle about
                }

                // something unexpected or idling
                state.SetCooldown(Random.NextFloat(4f, 8f));
                return;
            }
        }
    }
}