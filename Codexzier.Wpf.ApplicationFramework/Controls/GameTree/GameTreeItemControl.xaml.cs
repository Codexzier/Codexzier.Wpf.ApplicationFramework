using System.Windows.Controls;

namespace Codexzier.Wpf.ApplicationFramework.Controls.GameTree
{
    /// <summary>
    /// Interaction logic for GameTreeItemControl.xaml
    /// </summary>
    public partial class GameTreeItemControl : UserControl
    {
        private GameTreeItem _gameTreeItem;

        public GameTreeItemControl()
        {
            InitializeComponent();
        }

        internal void SetGameTreeItemValue(GameTreeItem treeItem)
        {
            this.tbPlayername.Text = treeItem.Player1.Name;
            this.tbPlayerScore.Text = $"{treeItem.Player1.Score}";

            this.tbVsPlayername.Text = treeItem.Player2.Name;
            this.tbVsPlayerScore.Text = $"{treeItem.Player2.Score}";
        }

        internal GameTreeItem GetGameTreeItem()
        {
            if(int.TryParse(tbPlayerScore.Text, out var playerScore))
            {
                this._gameTreeItem.Player1.Score = playerScore;
            }

            if(int.TryParse(tbVsPlayerScore.Text, out var vsPlayerScore))
            {
                this._gameTreeItem.Player2.Score = vsPlayerScore;
            }

            return this._gameTreeItem;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tbxPlayerScoreEdit.Text = tbPlayerScore.Text;
            tbxVsPlayerScoreEdit.Text = tbVsPlayerScore.Text;

            btnStartEdit.Visibility = System.Windows.Visibility.Collapsed;
            gridReadable.Visibility = System.Windows.Visibility.Collapsed;
            gridEditable.Visibility = System.Windows.Visibility.Visible;
            btnSaveEdit.Visibility = System.Windows.Visibility.Visible;
        }

        private void ButtonSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            tbPlayerScore.Text = tbxPlayerScoreEdit.Text;
            tbVsPlayerScore.Text = tbxVsPlayerScoreEdit.Text;

            btnStartEdit.Visibility = System.Windows.Visibility.Visible;
            gridReadable.Visibility = System.Windows.Visibility.Visible;
            gridEditable.Visibility = System.Windows.Visibility.Collapsed;
            btnSaveEdit.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
