using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp53
{
    public class Image: INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; OnPropertyChanged(); }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value;OnPropertyChanged(); }
        }

        private string source;

        public string Source
        {
            get { return source; }
            set { source = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}
