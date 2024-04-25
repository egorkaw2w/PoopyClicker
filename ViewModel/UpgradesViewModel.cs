using Microsoft.Win32;
using PoopyClicker.Model;
using PoopyClicker.View;
using PoopyClicker.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PoopyClicker.ViewModel
{
    internal class UpgradesViewModel : BindingHelper
    {

        private BindableCommand viewer;

        public BindableCommand Viewer
        {
            get { return viewer; }
            set { viewer = value;
                OnPropertyChanged();
            }
        }


        public UpgradesViewModel()
        {
            viewer = new BindableCommand(_ => upgrview());
        }

        private List<upgrades> upgrList = new List<upgrades>();

        public List<upgrades>  UpgrList
        {
            get { return upgrList; }
            set { upgrList = value; OnPropertyChanged(); }
        }

        private void upgrview()
        {
            upgrades upg1 = new upgrades("что то", "нечто", 10);
            upgrList.Add(upg1);
            OnPropertyChanged();
        }

    }
}
