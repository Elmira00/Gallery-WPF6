using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp53
{
    /// <summary>
    /// Interaction logic for PictureWindow.xaml
    /// </summary>
    public partial class PictureWindow : Window, INotifyPropertyChanged
    {
        private Image image;

        public Image FullImage
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }
        public List<Image> images { get; set; }
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public PictureWindow()
        {
            InitializeComponent();          
            this.DataContext = this;
            //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {        
                if (FullImage.Id != images.Count)
                {               
                    FullImage = images[FullImage.Id];
                }

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
                dispatcherTimer.Tick += dispatcherTimer_Tick;
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick -= dispatcherTimer_Tick;
        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            FullImage = images[FullImage.Id];
        }

        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            FullImage = images[FullImage.Id-2];
        }
    }
}
