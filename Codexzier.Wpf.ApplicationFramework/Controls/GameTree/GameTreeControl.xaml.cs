using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        public ObservableCollection<GameTreeItem> GameItems 
        {
            get => (ObservableCollection<GameTreeItem>)this.GetValue(GameTreeItemProperty);
            set => this.SetValue(GameTreeItemProperty, value);
        }

        public static readonly DependencyProperty GameTreeItemProperty =
            DependencyProperty.RegisterAttached(
                nameof(GameItems), 
                typeof(ObservableCollection<GameTreeItem>), 
                typeof(GameTreeControl), 
                new PropertyMetadata(new ObservableCollection<GameTreeItem>(), GamingItemsHasChanged));

        private static void GamingItemsHasChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is GameTreeControl control)
            {
                if(control.GameItems == null || control.GameItems.Count == 0)
                {
                    var list = new List<GameTreeItem>();
                    control.CreateTree(list);
                    return;
                }

                control.CreateTree(control.GameItems);
            }
        }

        public GameTreeControl()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            var list = new List<GameTreeItem>();


            this.CreateTree(list);
        }

        private void CreateTree(IEnumerable<GameTreeItem> gameTreeItems)
        {
            this.MainGrid.Children.Clear();
            this.MainGrid.ColumnDefinitions.Clear();
            this.MainGrid.RowDefinitions.Clear();
            this.PlayingDirections.Children.Clear();
            int countPlayer = gameTreeItems.Count();
            var gameTreeItemsArray = gameTreeItems.ToArray();

            AddRow();
            for (int i = 0; i < countPlayer; i++)
            {
                AddColumn();
                AddNode(gameTreeItemsArray[i], i, 0);

                AddNodeConnectionStart(i, 0);
            }

            bool isStraight = countPlayer % 2 == 0;

            if (!isStraight)
            {
                this.AddDistanceRow();
                this.AddRow();
                for (int iNextColumn = 0; iNextColumn < (countPlayer + 1) / 2; iNextColumn++)
                {
                    // inialisiere nächstes match
                    var t = gameTreeItemsArray[iNextColumn];

                    AddNode(new GameTreeItem(), iNextColumn * 2, 2, 2);
                    AddNodeConnectionEnd(iNextColumn, 1);

                    AddNodeConnectionStart(iNextColumn, 1, false);
                }
            }

            var addOneCanSet = false;

            var lastCountNodes = countPlayer; // + addOneMore;
            var countMatches = lastCountNodes / 2;

            for (int iNextRow = 0; iNextRow < countMatches; iNextRow++)
            {
                this.AddDistanceRow();
                this.AddRow();

                if (addOneCanSet)
                {
                    lastCountNodes--;
                }
                else
                {
                    addOneCanSet = true;
                    lastCountNodes /= 2;
                }

                for (int i = 0; i < lastCountNodes; i++)
                {
                    AddNode(new GameTreeItem(), (i * 2) + iNextRow + (isStraight ? 0 : 1), 2 + (iNextRow * 2) + (isStraight ? 0 : 2), 2);

                    var colNode = (i * 2) + (isStraight ? 1 : 2) + iNextRow;
                    var rowNode = (isStraight ? 1 : 2) + iNextRow;
                    AddNodeConnectionEnd(colNode, rowNode);

                    if(iNextRow < countMatches - 1)
                    {
                        AddNodeConnectionStart(colNode, rowNode, false);
                    }
                }
            }
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
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(30, GridUnitType.Pixel) });
        }

        private void AddNode(GameTreeItem item, int column, int row, int columnSpan = 1)
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

            var rectNode = new GameTreeItemControl
            {
                Width = 200,
                Height = 100,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Opacity = .7
            };

            rectNode.SetGameTreeItemValue(item);

            grid.Children.Add(rectNode);

            //var text = new TextBlock
            //{
            //    Text = $"C:{column}, R:{row}, CS:{columnSpan}",
            //    Foreground = Brushes.White,
            //    FontWeight = FontWeight.FromOpenTypeWeight(3)
            //};

            //grid.Children.Add(text);

            this.MainGrid.Children.Add(grid);
        }

        private void AddNodeConnectionStart(int column, int row, bool half = true)
        {
            var x = (200 * column) + (half ? 100 : 0);
            var y = (row > 0 ? (100 + (130 * row)) : (100 * row)) + (row == 0 ? 90 : -10);
            var el = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Green,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(
                    x,
                    y, 
                    0, 0)
            };

            this.PlayingDirections.Children.Add(el);

            var text = new TextBlock
            {
                Text = $"pos: {x} {y}",
                Foreground = Brushes.White,
                FontWeight = FontWeight.FromOpenTypeWeight(3),
                Margin = new Thickness(x, y, 0, 0)
            };
            this.PlayingDirections.Children.Add(text);
        }

        private void AddNodeConnectionEnd(int column, int row)
        {
            var pos = new Point(200 * column, 130 * row);
            var el = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Red,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(pos.X, pos.Y, 0, 0)
            };

            this.PlayingDirections.Children.Add(el);
        }
    }
}