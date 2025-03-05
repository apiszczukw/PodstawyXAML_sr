using PodstawyXAML_sr.Klasy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
        }

		private async void Button_Click(object sender, RoutedEventArgs e)
		{
            Osoba osoba = new Osoba()
            {
                Imie = imieTxt.Text,
                Nazwisko = nazwiskoTxt.Text,
                Kierunek = kierunekTxt.Text,
                Rok = int.Parse(rokTxt.Text)
            };

            var message = new ContentDialog()
            {
                Title = "Powitanie",
                Content = $"{osoba.ToString()}\nKierunek: {osoba.Kierunek}\nRok: {osoba.Rok}",
                CloseButtonText = "Zamknij"
            };

            await message.ShowAsync();

            var path = ApplicationData.Current.LocalFolder;

            XmlHelper.SerializeToXml<Osoba>(osoba, path.Path + "\\osoby.xml");
		}


	}
}
