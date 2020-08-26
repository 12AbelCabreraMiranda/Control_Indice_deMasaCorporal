using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Control_IMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Altura.Text) &&
               !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                //Convertir a Kilogramo
                var kilo = 0.453592;
                var totalKilo = peso * kilo;

                //Convertir a Metros
                var totalMetros = (altura / 100);

                //Resultado del Índece Masa Corporal
                var imc = totalKilo / (totalMetros * totalMetros);
                IMC.Text = imc.ToString();

                string resultado = "";
                
                //Sentencia
                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if(imc>=18.5 && imc <= 24.9)
                {
                    if (imc >= 22 && imc <= 22.9)
                    {
                        resultado = "Peso Ideal. Continúa cuidándote.!";
                    }else
                    resultado = "Tu peso es normal. Estás cuidándote...!";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tienes sobrepeso...!";
                }
                else
                {
                    resultado = "Controle su peso, ¡Cuídate..!";
                }
                DisplayAlert("Resultado", resultado, "Ok");
            }
            else
            {
                DisplayAlert("Datos Inválidos", "Por favor llene toda la información", "Ok");
            }

        }
    }
}
