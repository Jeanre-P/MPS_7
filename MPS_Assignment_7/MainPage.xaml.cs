using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewSong
{
    public partial class MainPage : ContentPage
    {
        public IList<Song> Songs{ get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Songs = new List<Songs>();
            Songs.Add(new Song
            {
                Title = "Mockingbird",
                Artist = "Eminem",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            Songs.Add(new Song
            {
                Title = "The Real Slim Shady",
                Artist = "Eminem",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            Songs.Add(new Song
            {
                Title = "Godzilla",
                Artist = "Eminem",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            Songs.Add(new Song
            {
                Title = "Loose Yourself",
                Artist = "Eminem",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            Songs.Add(new Song
            {
                Title = "Hotline Bling",
                Artist = "Drake",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            Songs.Add(new Song
            {
                Title = "Popstar",
                Artist = "Drake",
                ImageUrl = "iconfinder_Musical_note_2638326.png"
            });

            BindingContext = this;
        }
    }
}
