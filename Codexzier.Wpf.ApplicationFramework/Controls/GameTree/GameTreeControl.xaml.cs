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
            this.CreateTree(8);
            //TestGamingTree();
        }

        private void CreateTree(int countPlayer)
        {
            AddRow();
            for (int i = 0; i < countPlayer; i++)
            {
                AddColumn();
                AddNode(i, 0);
            }

            var isStraight = countPlayer % 2 == 0;
            var plusNode = isStraight ? 0 : 1;
            var latePlus = false;
            //var countMatches = (int)Math.Sqrt(countPlayer) + (isStraight ? 2 : 1);
            var countMatches = countPlayer / 2 + (isStraight? 0: 1);

            var lastCountNodes = countPlayer;
            for (int iNextRow = 0; iNextRow < countMatches; iNextRow++)
            {
                this.AddDistanceRow();
                this.AddRow();

                var addNodes = lastCountNodes / 2;
                
                for (int i = 0; i < addNodes + plusNode; i++)
                {
                    AddNode((i * 2) + iNextRow, 2 + (iNextRow * 2), 2);
                }

                if(isStraight && !latePlus)
                {
                    plusNode++;
                    latePlus = true;
                }

                if (countPlayer % 2 == 1 && isStraight)
                {
                    AddNode(countPlayer, 2);
                }

                lastCountNodes = addNodes;
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
            AddNode(0, 0);

            // spieler zwei
            AddNode(1, 0);

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
            AddNode(2, 0);

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

        private void AddNode(int column, int row, int columnSpan = 1)
        {
            var grid = new Grid
            {
                Width = 200,
                Height = 100,
                MinWidth = 200,
                MinHeight = 100
            };
            grid.SetValue(Grid.ColumnProperty, column);
            grid.SetValue(Grid.ColumnSpanProperty, columnSpan);
            grid.SetValue(Grid.RowProperty, row);

            var rectNode = new Rectangle
            {
                Width = 200,
                Height = 100,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Opacity = .7,
                Fill = Brushes.Gray,
                Margin = new Thickness(5)
            };

            grid.Children.Add(rectNode);

            var text = new TextBlock
            {
                Text = $"C:{column}, R:{row}, CS:{columnSpan}",
                Foreground = Brushes.White,
                FontWeight = FontWeight.FromOpenTypeWeight(3)
            };

            grid.Children.Add(text);

            this.MainGrid.Children.Add(grid);
        }
    }
}
