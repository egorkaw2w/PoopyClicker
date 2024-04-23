using PoopyClicker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoopyClicker.ViewModel.Helpers
{
    internal class MainViewModel : BindingHelper
    {

        #region Команды
        public BindableCommand clicking { get; set; }
        #endregion

        
/*        public MainViewModel()
        {
            clicking = new BindableCommand(_ => clicking());
        }*/




    }

}
