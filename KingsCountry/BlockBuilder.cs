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
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopcoverz-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("kings.shopframez-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x+":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopcoverx-"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("kings.shopframex-"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "z-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopcoverz+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.left + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right, ItemTypes.GetType("kings.shopframez+"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.right + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));

                        break;

                    case "x-":
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, ItemTypes.GetType("kings.shopcoverx+"));

                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.forward + Vector3Int.up, ItemTypes.GetType("invisible.kiln"));
                        ServerManager.TryChangeBlock(blockPosition + Vector3Int.back, ItemTypes.GetType("kings.shopframex+"));
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

            if (typeNew == BlockTypes.BuiltinBlocks.Types.air)
                ServerManager.TryChangeBlock(blockPosition + Vector3Int.up, BlockTypes.BuiltinBlocks.Indices.air);

        }
    }
}
