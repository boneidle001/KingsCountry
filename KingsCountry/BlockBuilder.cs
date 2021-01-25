using BlockEntities;
using Pipliz;
using System.Collections.Generic;

namespace BKiln
{
    [BlockEntityAutoLoader]
    public class Bkiln : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kilndoorx-"),
                 ItemTypes.GetType("kilndoorx+"),
                 ItemTypes.GetType("kilndoorz-"),
                 ItemTypes.GetType("kilndoorz+")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("largekilnx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("worktablez-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("worktablez+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.back, ItemTypes.GetType("worktablez-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.forward, ItemTypes.GetType("worktablez+"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("kilntables"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("brickmoldx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("largekilnx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("worktablez+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("worktablez-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.forward, ItemTypes.GetType("worktablez+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.back, ItemTypes.GetType("worktablez-"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("kilntables"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("brickmoldx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("largekilnz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("worktablex+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("worktablex-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.right, ItemTypes.GetType("worktablex+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.left, ItemTypes.GetType("worktablex-"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("kilntables"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("brickmoldz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("largekilnz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("worktablex-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("worktablex+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.left, ItemTypes.GetType("worktablex-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.right, ItemTypes.GetType("worktablex+"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("kilntables"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("brickmoldz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Carpenter
{
    [BlockEntityAutoLoader]
    public class Carpenter : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.carpenterz+"),
                 ItemTypes.GetType("kings.carpenterx+"),
                 ItemTypes.GetType("kings.carpenterz-"),
                 ItemTypes.GetType("kings.carpenterx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.carpentertoolsz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.carpenterlegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.carpenterlegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.carpentertoolsx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.carpenterlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.carpenterlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.carpentertoolsz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.carpenterlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.carpenterlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.carpentertoolsx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.carpenterlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.carpenterlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Furniture
{
    [BlockEntityAutoLoader]
    public class Furniture : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.furniturez+"),
                 ItemTypes.GetType("kings.furniturex+"),
                 ItemTypes.GetType("kings.furniturez-"),
                 ItemTypes.GetType("kings.furniturex-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.furnituretoolsz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.furniturelegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.furniturelegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.furnituretoolsx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.furniturelegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.furniturelegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.furnituretoolsz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.furniturelegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.furniturelegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.furnituretoolsx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.furniturelegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.furniturelegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Butcher
{
    [BlockEntityAutoLoader]
    public class Butcher : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.butcherz+"),
                 ItemTypes.GetType("kings.butcherx+"),
                 ItemTypes.GetType("kings.butcherz-"),
                 ItemTypes.GetType("kings.butcherx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.butchertopz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.butcherlegz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.butcherlegz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.butchertopx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.butcherlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.butcherlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.butchertopz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.butcherlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.butcherlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.butchertopx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.butcherlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.butcherlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Shopfront
{
    [BlockEntityAutoLoader]
    public class Shopfront : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.shopfrontz+"),
                 ItemTypes.GetType("kings.shopfrontx+"),
                 ItemTypes.GetType("kings.shopfrontz-"),
                 ItemTypes.GetType("kings.shopfrontx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopframez-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.shopcoverz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopframex-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.shopcoverx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopframez+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.shopcoverz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopframex+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.shopcoverx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Bar
{
    [BlockEntityAutoLoader]
    public class Bar : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.barz+"),
                 ItemTypes.GetType("kings.barx+"),
                 ItemTypes.GetType("kings.barz-"),
                 ItemTypes.GetType("kings.barx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barframez-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.barcoverz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.bartapsz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.bartapsz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barframex-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.barcoverx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.bartapsx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.bartapsx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barframez+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.barcoverz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.bartapsz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.bartapsz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barframex+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.barcoverx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.bartapsx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.bartapsx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Bottler
{
    [BlockEntityAutoLoader]
    public class Bottler : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.bottlerz+"),
                 ItemTypes.GetType("kings.bottlerx+"),
                 ItemTypes.GetType("kings.bottlerz-"),
                 ItemTypes.GetType("kings.bottlerx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("beer"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.bottlerlegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.bottlerlegz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("wine"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.bottlerlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.bottlerlegx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("honeymead"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.bottlerlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.bottlerlegz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("honeybottle"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("cider"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.bottlerlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.bottlerlegx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace GlassMaker
{
    [BlockEntityAutoLoader]
    public class Glassmaker : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.glassbasez+"),
                 ItemTypes.GetType("kings.glassbasex+"),
                 ItemTypes.GetType("kings.glassbasez-"),
                 ItemTypes.GetType("kings.glassbasex-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.glasstopz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.glasstablez+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.glasspressz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.glasstopx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.glasstablex+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.glasspressx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.glasstopz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.glasstablez-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.glasspressz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.glasstopx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.glasspressx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.glasspressx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace LargeOven
{
    [BlockEntityAutoLoader]
    public class LargeOven : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.ovenz+"),
                 ItemTypes.GetType("kings.ovenx+"),
                 ItemTypes.GetType("kings.ovenz-"),
                 ItemTypes.GetType("kings.ovenx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.ovendoorz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.ovenworktopz+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.chefx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, ItemTypes.GetType("kings.chefx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.chefx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, ItemTypes.GetType("kings.chefx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.ovendoorx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.ovenworktopx+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.chefz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, ItemTypes.GetType("kings.chefz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.chefz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, ItemTypes.GetType("kings.chefz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.ovendoorz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.ovenworktopz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.chefx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, ItemTypes.GetType("kings.chefx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.chefx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, ItemTypes.GetType("kings.chefx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.ovendoorx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.ovenworktopx-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.chefz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, ItemTypes.GetType("kings.chefz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.chefz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, ItemTypes.GetType("kings.chefz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Fishingboat
{
    [BlockEntityAutoLoader]
    public class Fishingboat : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.docksz+"),
                 ItemTypes.GetType("kings.docksx+"),
                 ItemTypes.GetType("kings.docksz-"),
                 ItemTypes.GetType("kings.docksx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.fishtopz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.dockworker"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.dockworker"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 3 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 4 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 5 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 6, ItemTypes.GetType("kings.boatfisherz-"), requestOrigin);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.fishtopx-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.dockworker"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.dockworker"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 3 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 4 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 5 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 6, ItemTypes.GetType("kings.boatfisherx-"), requestOrigin);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.fishtopz+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.dockworker"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.dockworker"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 3 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 4 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 5 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 6, ItemTypes.GetType("kings.boatfisherz+"), requestOrigin);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.fishtopx+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.dockworker"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.dockworker"), requestOrigin);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 3 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 4 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 5 + Vector3Int.down, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 6, ItemTypes.GetType("kings.boatfisherx+"), requestOrigin);

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 2 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 3 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 4 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 5 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward * 6, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 2 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 3 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 4 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 5 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right * 6, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 2 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 3 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 4 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 5 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back * 6, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 2 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 3 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 4 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 5 + Vector3Int.down, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left * 6, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Smoker
{
    [BlockEntityAutoLoader]
    public class Smoker : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                ItemTypes.GetType("kings.smoker")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("smokertop"));

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

        }
    }
}

namespace Forge
{
    [BlockEntityAutoLoader]
    public class Forge : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.forgez+"),
                 ItemTypes.GetType("kings.forgex+"),
                 ItemTypes.GetType("kings.forgez-"),
                 ItemTypes.GetType("kings.forgex-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.anvilsz+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.forgecoalz+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("kings.forgeroofz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, ItemTypes.GetType("kings.forgerz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, ItemTypes.GetType("kings.forgerz-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.anvilsx+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.forgecoalx+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("kings.forgeroofx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, ItemTypes.GetType("kings.forgerx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, ItemTypes.GetType("kings.forgerx-"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.anvilsz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.forgecoalz-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("kings.forgeroofz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, ItemTypes.GetType("kings.forgerz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, ItemTypes.GetType("kings.forgerz+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.anvilsx-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.forgecoalx-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("kings.forgeroofx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, ItemTypes.GetType("kings.forgerx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, ItemTypes.GetType("kings.forgerx+"), requestOrigin);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

namespace Brewer
{
    [BlockEntityAutoLoader]
    public class Brewer : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.breweryz+"),
                 ItemTypes.GetType("kings.breweryx+"),
                 ItemTypes.GetType("kings.breweryz-"),
                 ItemTypes.GetType("kings.breweryx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barrelstandz+"));
                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barrelstandx+"));
                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barrelstandz-"));
                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.barrelstandx-"));
                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        break;
                }
            }
        }
    }

}

namespace GrapeSeed
{
    [BlockEntityAutoLoader]
    public class GrapeSeed : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                ItemTypes.GetType("grapesframe")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("grapesstage1"));
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("invisible.kiln"));

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

        }
    }
}

namespace KingsSign
{
    [BlockEntityAutoLoader]
    public class KingsSign : IChangedWithType, IMultiBlockEntityMapping
    {
        public IEnumerable<ItemTypes.ItemType> TypesToRegister { get { return types; } }

        ItemTypes.ItemType[] types = new ItemTypes.ItemType[]
            {
                 ItemTypes.GetType("kings.signz+"),
                 ItemTypes.GetType("kings.signx+"),
                 ItemTypes.GetType("kings.signz-"),
                 ItemTypes.GetType("kings.signx-")
            };

        public void OnChangedWithType(Chunk chunk, BlockChangeRequestOrigin requestOrigin, Vector3Int blockPosition, ItemTypes.ItemType typeOld, ItemTypes.ItemType typeNew)
        {
            //OnAdd
            if (typeOld == BlockTypes.BuiltinBlocks.Types.air)
            {

                switch (typeNew.Name.Substring(typeNew.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.sign0202z-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0102z-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("kings.sign0203z-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0103z-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("kings.sign0201z-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0101z-"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.sign0202x-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0102x-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("kings.sign0203x-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0103x-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("kings.sign0201x-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0101x-"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.sign0202z+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0102z+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("kings.sign0203z+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0103z+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("kings.sign0201z+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0101z+"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.sign0202x+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0102x+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("kings.sign0203x+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0103x+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("kings.sign0201x+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, ItemTypes.GetType("kings.sign0101x+"));

                        break;
                }
            }

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
            {
                switch (typeOld.Name.Substring(typeOld.Name.Length - 2))
                {
                    case "z+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up * 2, BlockTypes.BuiltinBlocks.Indices.air);

                        break;
                }
            }

        }
    }
}

