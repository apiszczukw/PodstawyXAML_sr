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
		Uczestnicy uczestnicy = new Uczestnicy();

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
				Rok = int.Parse(rokTxt.Text),
				Przedmioty = new List<Przedmiot>()
				{
					new Przedmiot() { Nazwa = "Analiza matematyczna", IleGodzin = 2 },
					new Przedmiot() { Nazwa = "Programowanie", IleGodzin = 4 },
				}
			};

			var message = new ContentDialog()
			{
				Title = "Pomyślnie zapisano osobę",
				Content = $"{osoba.ToString()}\nKierunek: {osoba.Kierunek}\nRok: {osoba.Rok}",
				CloseButtonText = "Zamknij"
			};

			await message.ShowAsync();

			uczestnicy.osoby.Add(osoba);

			CleanFields();
		}

		private void CleanFields()
		{
			imieTxt.Text = "";
			nazwiskoTxt.Text = "";
			kierunekTxt.Text = "";
			rokTxt.Text = "";
		}

		private void XMLBtn_Click(object sender, RoutedEventArgs e)
		{
			var path = ApplicationData.Current.LocalFolder.Path;

			XmlHelper.SerializeToXml<Uczestnicy>(uczestnicy, path + "\\osoby.xml");
		}
	}
}
