namespace Codexzier.Wpf.ApplicationFramework.Controls.GameTree
{
    public class GameTreeItem
    {
        public int GameId { get; set; }

        public int ItemPositionHorizontal { get; set; }

        public int ItemPositionVertikal { get; set; }

        public PlayerItem Player1 { get; set; }

        public PlayerItem Player2 { get; set; }
    }
}