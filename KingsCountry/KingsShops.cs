using Pipliz;

namespace KingsShops
{
    [ModLoader.ModManager]
    public static class KingsShops
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "kc.Kingsshop.AfterItemTypesDefined")]
        [ModLoader.ModCallbackDependsOn("blockentitycallback.autoloaders")]
        public static void AfterItemTypesDefined()
        {
            var entities = ServerManager.BlockEntityCallbacks;
            if (entities.TryGetAutoLoadedInstance<BlockEntities.Implementations.NPCShopTracker>(out var shopTracker))
            {

                var newTypes = new ItemTypes.ItemType[] { ItemTypes.GetType("kings.barz+"), ItemTypes.GetType("kings.barz-"), ItemTypes.GetType("kings.barx+"), ItemTypes.GetType("kings.barx-") };

                entities.RegisterEvent(BlockEntities.ERegisteredEventTypes.OnChanged, newTypes, entities.ChangedEvents, shopTracker.OnChangedWithType);
                entities.RegisterEvent(BlockEntities.ERegisteredEventTypes.OnLoadWithData, newTypes, entities.LoadedWithDataEvents, BlockEntities.Delegates.WrapToLoadWithData(shopTracker.OnLoadedPosition));
                entities.RegisterEvent(BlockEntities.ERegisteredEventTypes.OnUnload, newTypes, entities.UnloadedEvents, BlockEntities.Delegates.WrapToDataIteration(shopTracker.OnUnloadedPosition));

                shopTracker.GetType().GetField("Types", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(shopTracker, newTypes.Append(BlockTypes.BuiltinBlocks.Types.npcshop));
            }
        }
    }
}
