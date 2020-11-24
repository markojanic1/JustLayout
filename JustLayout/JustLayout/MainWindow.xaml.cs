using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JustLayout
{
    

    public partial class MainWindow : Window
    {

        ComboBox albumCombobox;
        TextBlock myTextblock;
        Grid grid;
        ListBox myListbox;

        

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            // Window options
            Title = "GUI App";
            Width = 1000;
            Height = 800;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Scrolling
            ScrollViewer root = new ScrollViewer();
            root.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            Content = root;

            // Main grid
            Grid grid = new Grid();
            root.Content = grid;
            grid.Margin = new Thickness(5);
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            Grid leftGrid = LeftGrid();
            grid.Children.Add(leftGrid);
            Grid.SetRow(leftGrid, 0);
            Grid.SetColumn(leftGrid, 0);

            Grid rightGrid = RightGrid();
            grid.Children.Add(rightGrid);
            Grid.SetRow(rightGrid, 0);
            Grid.SetColumn(rightGrid, 1);

            


        }

        private Grid LeftGrid()
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition {Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());

            myTextblock = new TextBlock
            {
                Text = "Affär",
                Margin = new Thickness(5),
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Center,

            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 0);
            Grid.SetRow(myTextblock, 0);
            Grid.SetColumnSpan(myTextblock, 2);

            myTextblock = new TextBlock
            {
                Text = "Välj Album:",
                Margin = new Thickness(5),
                FontSize = 15,
                TextAlignment = TextAlignment.Left,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 0);
            Grid.SetRow(myTextblock, 3);

            myListbox = new ListBox { Margin = new Thickness(5) };
            grid.Children.Add(myListbox);
            myListbox.Items.Add("Speak & Spell");
            myListbox.Items.Add("A Broken Frame");
            myListbox.Items.Add("Construction Time Again");
            myListbox.Items.Add("Some Great Reward");
            myListbox.Items.Add("Black Celebration");
            myListbox.Items.Add("Music for the Masses");
            myListbox.Items.Add("Violator");
            myListbox.Items.Add("Songs of Faith and Devotion");
            myListbox.Items.Add("ULTRA");
            myListbox.Items.Add("Exciter");
            myListbox.Items.Add("Playing the Angel");
            myListbox.Items.Add("Sounds of the Universe");
            myListbox.Items.Add("Delta Machine");
            myListbox.Items.Add("Spirit");
            Grid.SetColumn(myListbox, 0);
            Grid.SetRow(myListbox, 4);

            Image normalImage = CreateImage("Images/ss.jpg");
            normalImage.Stretch = Stretch.None;
            grid.Children.Add(normalImage);
            Grid.SetRow(normalImage, 5);
            Grid.SetColumn(normalImage, 0);


            myTextblock = new TextBlock
            {
                Text = "Info:",
                Margin = new Thickness(5),
                FontSize = 15,
                VerticalAlignment = VerticalAlignment.Bottom,
                TextAlignment = TextAlignment.Center,
            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 3);

           

            myTextblock = new TextBlock
            {
                Text = "Lite info om album",
                Margin = new Thickness(5),
                FontSize = 13,
                TextAlignment = TextAlignment.Right,

            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 4);


            return grid;
        }

        private Grid RightGrid()
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition {Height = GridLength.Auto});
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition());

            myTextblock = new TextBlock
            {
                Text = "Kassa",
                Margin = new Thickness(5),
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Center,

            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 0);
            Grid.SetColumnSpan(myTextblock, 2);

            myTextblock = new TextBlock
            {
                Text = "Vill du spara varukorg till senare?",
                Margin = new Thickness(5),
                FontSize = 15,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 1);
            Grid.SetColumnSpan(myTextblock, 2);

            CheckBox checkBox = new CheckBox
            {
                Content = "Checkbox",
                Margin = new Thickness(5),
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center

            };
            grid.Children.Add(checkBox);
            Grid.SetColumn(checkBox, 1);
            Grid.SetRow(checkBox, 1);
            Grid.SetColumnSpan(checkBox, 2);

            

            myTextblock = new TextBlock
            {
                Text = "Välj rabbatkod:",
                Margin = new Thickness(5),
                FontSize = 15,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Right
            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 3);

            myListbox = new ListBox 
            {
                Margin = new Thickness(5),

            };
            grid.Children.Add(myListbox);
            Grid.SetColumn(myListbox, 2);
            Grid.SetRow(myListbox, 3);
            
            myListbox.Items.Add("VR1O5N - 10%");
            myListbox.Items.Add("Y7KA5R - 15%");
            myListbox.Items.Add("MP6XQJ - 20%");

            Button button = new Button
            {
                Content = "Köp",
                Margin = new Thickness(5),
            };
            grid.Children.Add(button);
            Grid.SetColumn(button, 1);
            Grid.SetRow(button, 5);
            Grid.SetColumnSpan(button, 2);

            myTextblock = new TextBlock
            {
                Text = "Kvitto:",
                Margin = new Thickness(5),
                FontSize = 15,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Left
            };
            grid.Children.Add(myTextblock);
            Grid.SetColumn(myTextblock, 1);
            Grid.SetRow(myTextblock, 6);

            return grid;
        }


        private Image CreateImage(string filePath)
        {
            ImageSource source = new BitmapImage(new Uri(filePath, UriKind.Relative));
            Image image = new Image
            {
                Source = source,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5)
            };
            RenderOptions.SetBitmapScalingMode(image, BitmapScalingMode.HighQuality);
            return image;
        }

    }
}
