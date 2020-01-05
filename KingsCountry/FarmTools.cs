using NetworkUI;
using NetworkUI.Items;
using Pipliz;
using System.Collections.Generic;

namespace KingsTools
{
    [ModLoader.ModManager]
    public static class FarmTools
    {
        public static Dictionary<NetworkID, int> last_tool = new Dictionary<NetworkID, int>();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerClicked, "KC.FarmTools.OnPlayerClicked")]
        public static void OnPlayerClicked(Players.Player player, Shared.PlayerClickedData playerClickedData)
        {
            if (player == null || playerClickedData.TypeSelected != ItemTypes.IndexLookup.GetIndex("kings.tool"))
                return;

            switch (playerClickedData.ClickType)
            {
                case Shared.PlayerClickedData.EClickType.Left:
                    Left_Click(player);
                    break;

                case Shared.PlayerClickedData.EClickType.Right:
                    Right_Click(player);
                    break;
            };
        }

        private static void Right_Click(Players.Player player)
        {
            int kingstools = last_tool.GetValueOrDefault(player.ID, 0);

            AreaJobTracker.CommandToolTypeData data = new AreaJobTracker.CommandToolTypeData();

            switch (kingstools)
            {
                default:
                case 0:
                    data.LocaleEntry = "popup.tooljob.grapefarmer";
                    data.AreaType = "kc.grapefarm";
                    data.Minimum3DBlockCount = 25;
                    data.Maximum3DBlockCount = 100;
                    data.Minimum2DBlockCount = 25;
                    data.Maximum2DBlockCount = 100;
                    data.MinimumHeight = 1;
                    data.MaximumHeight = 3;
                    data.OneAreaOnly = false;
                break;
                case 1:
                    data.LocaleEntry = "popup.tooljob.applefarmer";
                    data.AreaType = "kc.applefarm";
                    data.Minimum3DBlockCount = 50;
                    data.Maximum3DBlockCount = 100;
                    data.Minimum2DBlockCount = 50;
                    data.Maximum2DBlockCount = 100;
                    data.MinimumHeight = 1;
                    data.MaximumHeight = 3;
                    data.OneAreaOnly = false;
                    break;

            }
            
            AreaJobTracker.StartCommandToolSelection(player, data);
        }

        private static void Left_Click(Players.Player player)
        {
            if (null == player)
                return;

            NetworkMenu menu = new NetworkMenu();
            menu.Identifier = "Farm Tools";
            menu.Width = 500;

            menu.LocalStorage.SetAs("header", Localization.GetSentence(player.LastKnownLocale, "popup.tooljob.kingstoolheader"));

            ButtonCallback grapeButton = new ButtonCallback("KC.FarmTools.0", new LabelData(Localization.GetSentence(player.LastKnownLocale, "popup.tooljob.grapefarm"), UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter), -1, 25, ButtonCallback.EOnClickActions.ClosePopup);
            ButtonCallback appleButton = new ButtonCallback("KC.FarmTools.1", new LabelData(Localization.GetSentence(player.LastKnownLocale, "popup.tooljob.applefarm"), UnityEngine.Color.black, UnityEngine.TextAnchor.MiddleCenter), -1, 25, ButtonCallback.EOnClickActions.ClosePopup);

            HorizontalRow row1 = new HorizontalRow(new List<(IItem, int)> { (grapeButton, 150), (appleButton, 150) });
            menu.Items.Add(row1);

            NetworkMenuManager.SendServerPopup(player, menu);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerPushedNetworkUIButton, "KC.Farmtools.OnPlayerPushedNetworkUIButton")]
        public static void OnPlayerPushedNetworkUIButton(ButtonPressCallbackData data)
        {
            if (!data.ButtonIdentifier.StartsWith("KC.FarmTools."))
                return;

            Log.Write("Kings ID:" + data.ButtonIdentifier.Substring(data.ButtonIdentifier.LastIndexOf(".") + 1));

            int kingsID = int.Parse(data.ButtonIdentifier.Substring(data.ButtonIdentifier.LastIndexOf(".") + 1));

            if (last_tool.ContainsKey(data.Player.ID))
                last_tool.Remove(data.Player.ID);

            last_tool.Add(data.Player.ID, kingsID);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerDisconnected, "KC.Farmtools.OnPlayerDisconnected")]
        public static void OnPlayerDisconnected(Players.Player player)
        {
            if (last_tool.ContainsKey(player.ID))
                last_tool.Remove(player.ID);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnSendAreaHighlights, "KC.Farmtools.ShowArea")]
        public static void OnSendAreaHighlights(Players.Player player, List<AreaJobTracker.AreaHighlight> list, List<ushort> showWhileHoldingTypes)
        {
            if (null != player)
            {
                showWhileHoldingTypes.Add(ItemTypes.IndexLookup.GetIndex("kings.tool"));
            }
        }
    }
}