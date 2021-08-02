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
            // zwei spieler ...
            this.MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(20, GridUnitType.Auto) });
            this.MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(20, GridUnitType.Auto) });

            // ... in einer Zeile
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Auto) });

            // spieler eins
            var rectPlayer1 = new Rectangle { Width = 200, Height = 100 };
            rectPlayer1.SetValue(Grid.ColumnProperty, 0);
            rectPlayer1.SetValue(Grid.RowProperty, 0);
            rectPlayer1.Fill = Brushes.Gray;
            rectPlayer1.Margin = new Thickness(5);
            this.MainGrid.Children.Add(rectPlayer1);

            // spieler zwei
            var rectPlayer2 = new Rectangle { Width = 200, Height = 100 };
            rectPlayer2.SetValue(Grid.ColumnProperty, 1);
            rectPlayer2.SetValue(Grid.RowProperty, 0);
            rectPlayer2.Fill = Brushes.Gray;
            rectPlayer2.Margin = new Thickness(5);
            this.MainGrid.Children.Add(rectPlayer2);

            // abstands Zeile
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10, GridUnitType.Pixel) });

            // gewinner Zeile
            this.MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(20, GridUnitType.Auto) });

            // gewinner
            var rectPlayerWinner = new Rectangle { Width = 200, Height = 100 };
            rectPlayerWinner.SetValue(Grid.ColumnProperty, 0);
            rectPlayerWinner.SetValue(Grid.ColumnSpanProperty, 2);
            rectPlayerWinner.SetValue(Grid.RowProperty, 2);
            rectPlayerWinner.Fill = Brushes.Gray;
            rectPlayerWinner.Margin = new Thickness(5);
            this.MainGrid.Children.Add(rectPlayerWinner);
        }
    }
}
