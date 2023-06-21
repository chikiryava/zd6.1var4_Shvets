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

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch1Label.Text = "on";
            }
            else
            {
                switch1Label.Text = "off";
            }

        }

        private void Switch_Toggled_1(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch2Label.Text = "on";
            }
            else
            {
                switch2Label.Text = "off";
            }
        }

        private void Switch_Toggled_2(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch3Label.Text = "on";
            }
            else
            {
                switch3Label.Text = "off";
            }
        }

        private void Switch_Toggled_3(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch4Label.Text = "on";
            }
            else
            {
                switch4Label.Text = "off";
            }
        }

        private void Switch_Toggled_4(object sender, ToggledEventArgs e)
        {
          
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch5Label.Text = "✓";
            }
            else
            {
                switch5Label.Text = "×";
            }

        }

        private void Switch_Toggled_5(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch6Label.Text = "✓";
            }
            else
            {
                switch6Label.Text = "×";
            }

        }

        private void Switch_Toggled_6(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch7Label.Text = "✓";
            }
            else
            {
                switch7Label.Text = "×";
            }

        }

        private void Switch_Toggled_7(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;
            if (switcher.IsToggled)
            {
                switch8Label.Text = "✓";
            }
            else
            {
                switch8Label.Text = "×";
            }
        }

        private void button1Static_Clicked(object sender, EventArgs e)
        {
             List<Slider> sliders = new List<Slider>()
        {
            slider1, slider2, slider3, slider4, slider5, slider6,
        };
            if (picker1.SelectedItem != null)
                infoLabel.Text = $"Выбранный элемент: {picker1.SelectedItem.ToString()}";
            else
                infoLabel.Text = "Вы не выбрали элемент";
           
            double maxValue = -1;
            foreach(Slider slider in sliders)
            {
                if (slider.Value > maxValue)
                    maxValue = slider.Value;
            }
            infoLabel1.Text = $"Максимальное значение слайдера: {Math.Round(maxValue,2)}";
            carousel.CurrentPage = second;

        }    
    }
}