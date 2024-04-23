using PoopyClicker.Model;
using PoopyClicker.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PoopyClicker.ViewModel.Helpers
{
    internal class MainViewModel : BindingHelper
    {


        public BindableCommand addcount { get; set; }

        private int clicks = 0;

        public int Clicks
        {
            get { return clicks; }
            set
            {
                clicks = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            addcount = new BindableCommand(_ => Counter());
            open = new BindableCommand(_ => updOpen());


        }

        public void Counter()
        {
            Clicks++;
        }


        private int updvis;
        public BindableCommand open { get; set; }

        public int Updvis
        {
            get { return updvis; }
            set
            {
                updvis = value;
                OnPropertyChanged();
            }
        }


        private void updOpen()
        {
            Upgrades upg = new Upgrades();
            upg.Show();
         
            
        }

    }
}


