using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Codexzier.Wpf.ApplicationFramework.Controls.GameTree
{
    /// <summary>
    /// Interaction logic for GameTreeView.xaml
    /// </summary>
    public partial class GameTreeControl : UserControl
    {
        public GameTreeControl()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            this.CreateTree(3);
            //TestGamingTree();
        }

        private void CreateTree(int countPlayer)
        {
            AddRow();
            for (int i = 0; i < countPlayer; i++)
            {
                AddColumn();
                AddPlayer(i, 0);
            }

            AddDistanceRow();
            AddRow();
            AddNode(0, 2, 2);

            if(countPlayer % 2 == 1)
            {
                AddNode(2, 2);
            }
        }

        private void TestGamingTree()
        {
            // zwei spieler ...
            AddColumn();
            AddColumn();
            // ... in einer Zeile
            AddRow();

            // spieler eins
            AddPlayer(0, 0);

            // spieler zwei
            AddPlayer(1, 0);

            // abstands Zeile
            AddDistanceRow();

            // gewinner Zeile
            AddRow();

            // gewinner
            AddNode(0, 2, 2);

            // ################################
            // dritter Spieler
            AddColumn();

            // spieler drei
            AddPlayer(2, 0);

            // gewinner 2
            AddNode(2, 2);
        }

        private void AddColumn()
        {
            this.MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(20, GridUnitType.Auto) });
        }

        private void AddRow()
        {
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Auto) });

        }

        private void AddDistanceRow()
        {
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Pixel) });
        }

        private void AddPlayer(int column, int row)
        {
            var rectPlayer = new Rectangle { Width = 200, Height = 100 };
            rectPlayer.SetValue(Grid.ColumnProperty, column);
            rectPlayer.SetValue(Grid.RowProperty, row);
            rectPlayer.Fill = Brushes.Gray;
            rectPlayer.Margin = new Thickness(5);
            this.MainGrid.Children.Add(rectPlayer);
        }

        private void AddNode(int column, int row, int columnSpan = 1)
        {
            var rectNode = new Rectangle { Width = 200, Height = 100 };
            rectNode.SetValue(Grid.ColumnProperty, column);
            rectNode.SetValue(Grid.ColumnSpanProperty, columnSpan);
            rectNode.SetValue(Grid.RowProperty, row);
            rectNode.Fill = Brushes.Gray;
            rectNode.Margin = new Thickness(5);

            this.MainGrid.Children.Add(rectNode);
        }
    }
}
