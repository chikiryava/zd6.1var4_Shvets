using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_1_Shvets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : CarouselPage
    {
        public Main (string login,string password)
        {
            InitializeComponent();
        }
    }
}