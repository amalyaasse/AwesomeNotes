using AwesomeNotes.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace AwesomeNotes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimePicker : ContentPage
    {
        

        public TimePicker()
        {
            InitializeComponent();
            
        }

        

        

        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                
            }
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            
        }

       

        public void OnClicked1(object sender, EventArgs e)
        {
          
           String ArbeitszeitBruto;//gesamte Arbeitszeit mit Stunden Plus Pause
            
            
            ArbeitszeitBruto =(_timePicker2.Time -_timePicker1.Time).ToString();//Arbeitsende - Arbeitsbegin

            (sender as Button).Text = ArbeitszeitBruto.ToString();
            
        }

        public void OnClicked2(object sender, EventArgs e)
        {

            String Pause;//gesamte Arbeitszeit mit Stunden Plus Pause


            Pause = (_Pause2.Time-_Pause1.Time).ToString();

            (sender as Button).Text = Pause.ToString();

        }


        public void OnClicked3(object sender, EventArgs e)
        {
            
            string Netto;
            Netto = ((_timePicker2.Time-_timePicker1.Time)-(_Pause2.Time-_Pause1.Time)).ToString();

            
            (sender as Button).Text = Netto.ToString();
           
        }



    }





}
   

