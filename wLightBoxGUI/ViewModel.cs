using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wLightBoxGUI
{
    public class ViewModel
    {
        public ObservableCollection<string> CmbContent { get; private set; }
        public ObservableCollection<int> CmbContentEffect { get; private set; }



        public ViewModel()
        {
            CmbContent = new ObservableCollection<string>
            {
                "http://192.168.1.11/",
                "http://device.blebox/",
            };

            CmbContentEffect = new ObservableCollection<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };
        }
    }
}
