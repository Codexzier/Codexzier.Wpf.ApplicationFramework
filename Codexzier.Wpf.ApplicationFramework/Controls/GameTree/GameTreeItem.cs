namespace Codexzier.Wpf.ApplicationFramework.Controls.GameTree
{
    public class GameTreeItem
    {
        public GameTreeItem()
        {
            this.Player1 = new PlayerItem();
            this.Player2 = new PlayerItem();
        }

        public int GameId { get; set; }

        public int ItemPositionHorizontal { get; set; }

        public int ItemPositionVertikal { get; set; }

        public PlayerItem Player1 { get; set; }

        public PlayerItem Player2 { get; set; }
    }
}