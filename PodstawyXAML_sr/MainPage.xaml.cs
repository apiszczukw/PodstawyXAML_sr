using PodstawyXAML_sr.Klasy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PodstawyXAML_sr
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Osoba osoba = new Osoba();

            List<Przedmiot> przedmioty = new List<Przedmiot>()
            {
                new Przedmiot()
                {
                    Nazwa = "prawo",
                    IleGodzin = 14
                },
                new Przedmiot()
                {
                    Nazwa = "finanse",
                    IleGodzin = 20
                },
                new Przedmiot()
                {
                    Nazwa = "zarządzanie zasobami ludzkimi",
                    IleGodzin = 8
                }
            };

            osoba.Przedmioty = przedmioty;
            osoba.Lp = 1;
            osoba.Imie = "Natalia";
            osoba.Nazwisko = "Bany";
            osoba.Dojazd = "Tak";
            osoba.Rok = 2011;

            var message = new ContentDialog()
            {
                Title = "Powitanie",
                Content = osoba.ToString(),
                CloseButtonText = "Zamknij"
            };

            message.ShowAsync();
        }
    }
}
