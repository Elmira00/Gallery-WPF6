using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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

namespace WpfApp53
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged();}
        }
        public List<Image> images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            images =new List<Image>{ new Image { Id = 1, Height = 30, Width = 30, Source = "Pictures/img1.png" },
             new Image { Id = 2, Height = 30, Width = 30, Source = "Pictures/img4.png" },
             new Image { Id = 3, Height = 30, Width = 30, Source = "Pictures/img5.png" },
             new Image { Id = 4, Height = 30, Width = 30, Source = "Pictures/img6.png" },
             new Image { Id = 5, Height = 30, Width = 30, Source = "Pictures/img8.png" },
             new Image { Id = 6, Height = 30, Width = 30, Source = "Pictures/img9.png" },
             new Image { Id = 7, Height = 30, Width = 30, Source = "Pictures/img15.png" },
             new Image { Id = 8, Height = 30, Width = 30, Source = "Pictures/img16.png" },
             new Image { Id = 9, Height = 30, Width = 30, Source = "Pictures/img17.png" },
             new Image { Id =10, Height = 30, Width = 30, Source = "Pictures/img18.png" },
             new Image { Id = 11, Height = 30, Width = 30, Source = "Pictures/img19.png" },
             new Image { Id = 12, Height = 30, Width = 30, Source = "Pictures/img20.png" },
            };
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
        private void myListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var image = myListBox.SelectedItem as Image;
            PictureWindow window = new PictureWindow();
            window.FullImage = image;
            window.images = this.images;
            window.ShowDialog();
        }

        public void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //tiles
        }
    }
}
