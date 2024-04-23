using Microsoft.Win32;
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
		private int upgrades;

		public int UpgradeView
		{
			get { return upgrades; }
			set { upgrades = value; }
		}

		private void upgrview()
		{
			 
		}

	}
}
