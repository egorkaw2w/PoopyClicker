using PoopyClicker.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PoopyClicker.ViewModel
{
    internal class GaleryViewModel
    {
        private string galery;

        public string Gallery
        {
            get { return galery; }
            set { galery = value; }
        }
        private SoundPlayer player;

        public BindableCommand titri { get; set; }

/*        public GaleryViewModel()
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\egrok\Source\Repos\egorkaw2w\PoopyClicker\Model\pictures\star.wav");
            soundPlayer.Load();
            soundPlayer.PlaySync();
            
        }*/ //если вы это почините, вы увидите самую лучшую отсылку ever! (почините пж пж пж)

    }
}

