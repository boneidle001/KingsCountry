using Pipliz;
using Jobs;
using NPC;

namespace Grapefarm
{
    [AreaJobDefinitionAutoLoader]
    public class GrapeFarm : AbstractFarmAreaJobDefinition
    {
        public GrapeFarm()
        {
            Identifier = "kc.grapefarm";
            UsedNPCType = NPCType.GetByKeyNameOrDefault("kc.grapefarmer");
            JobRequiresSeeds = false;
            Stages = new ushort[] {
                ItemTypes.IndexLookup.GetIndex("grapesframe")
            };
        }

        public override IAreaJob CreateAreaJob(Colony owner, Vector3Int min, Vector3Int max, bool isLoaded, int npcID = 0)
        {
            return base.CreateAreaJob(owner, min, max, npcID);
        }

    }
}
