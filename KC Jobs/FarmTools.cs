using Jobs;
using ModLoaderInterfaces;
using NetworkUI;
using NetworkUI.AreaJobs;
using NetworkUI.Items;

namespace kc
{
    public class JobUI : IOnConstructCommandTool, IOnPlayerPushedNetworkUIButton, IAfterWorldLoad
    {
        public void AfterWorldLoad()
        {
            //CommandToolManager.MenuTooltips.Add("Khanx.CherryForest", ("popup.tooljob.cherryforestera", "popup.tooljob.cherryforesterb"));
            CommandToolManager.AreaDescriptions.Add("kc.applefarm",
                AreaToolDescriptionSettings.NewForest("popup.tooljob.applefarmer", "kc.applefarm", "kc.applefarmer"));

            //CommandToolManager.MenuTooltips.Add("Khanx.CherryForest", ("popup.tooljob.cherryforestera", "popup.tooljob.cherryforesterb"));
            CommandToolManager.AreaDescriptions.Add("kc.grapefarm",
                AreaToolDescriptionSettings.NewStandard("popup.tooljob.grapefarmer", "kc.grapefarm", "kc.grapefarmer", new string[10]
                {
                    "air",
                    "grapesstage",
                    "grapesstage1",
                    "grapesstage2",
                    "grapesstage3",
                    "grapesstage4",
                    "grapesstage5",
                    "grapesstage6",
                    "grapesstage7",
                    "grapesframe"
                }));

            //CommandToolManager.MenuTooltips.Add("Khanx.CherryForest", ("popup.tooljob.cherryforestera", "popup.tooljob.cherryforesterb"));
            CommandToolManager.AreaDescriptions.Add("kc.cowfarm",
                AreaToolDescriptionSettings.NewBlockFarm("popup.tooljob.cowfarmer", "kc.cowfarm", "kc.cowfarmer", 8, 12, new string[9]
                {
                    "air",
                    "cowstage1",
                    "cowstage2",
                    "cowstage3",
                    "cowstage4",
                    "cow1",
                    "cow2",
                    "cow3",
                    "cow4"
                }));

        }

        public void OnConstructCommandTool(Players.Player player, NetworkMenu networkMenu, string menuName)
        {
            if (!menuName.Equals(CommandToolManager.Menus.MAIN_MENU))
                return;

            networkMenu.Items.Add(new EmptySpace(10));

            CommandToolManager.GenerateThreeColumnCenteredRow(networkMenu, new EmptySpace(), CommandToolManager.GetButtonMenu(player, "popup.tooljob.kc", "King's Country"), new EmptySpace());

        }

        public void OnPlayerPushedNetworkUIButton(ButtonPressCallbackData data)
        {
            if (!CommandToolManager.TryStartCommandToolSelection(data.Player, data.ButtonIdentifier))
            {
                switch (data.ButtonIdentifier)
                {
                    case "popup.tooljob.kc":
                        NetworkMenu networkMenu = CommandToolManager.GenerateMenuBase(data.Player, showBackButton: true);

                        CommandToolManager.GenerateThreeColumnCenteredRow(networkMenu, CommandToolManager.GetButtonTool(data.Player, "kc.applefarm", "Apple Farm", 200), CommandToolManager.GetButtonTool(data.Player, "kc.grapefarm", "Grape Farm", 200), CommandToolManager.GetButtonTool(data.Player, "kc.cowfarm", "Cow Farm", 200));

                        NetworkMenuManager.SendServerPopup(data.Player, networkMenu);
                        break;
                }
            }
        }
    }
}
