using Gra2D.Characters;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Gra2D
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonFight_Click(object sender, RoutedEventArgs e)
        {
            buttonFight.IsEnabled = false;
            buttonTravel.IsEnabled = true;
            buttonRetreat.IsEnabled = false;
            Hero hero = new Hero();
            zycieBohater.Text = hero.Hp.ToString();
            obrazeniaBohater.Text = hero.Dmg.ToString();
            //Przebieg.Text = "Hp bohatera: " + hero.Hp.ToString();
            switch (nazwaPrzeciwnik.Text)
            {
                case "Podejrzany Królik":
                    {
                        SuspectedBunny s = new SuspectedBunny();

                        Przebieg.Text = "Hp przeciwnika: " + s.Hp.ToString();
                        Przebieg.Text += "\nHp bohatera: " + hero.Hp.ToString();

                        for (int i = 1; i <= 10; i++)
                        {
                            Przebieg.Text += "\n\nRUNDA " + i;
                            Random random = new Random();
                            s.Hp += random.Next(hero.Attack()-4, hero.Attack()+4);
                            if (s.Hp <= 0)
                            {
                                Przebieg.Text += "\nWygrałeś.";
                                break;
                            }

                            //Dispatcher.Invoke(() =>

                            Przebieg.Text += "\nHp królika: " + s.Hp.ToString();
                            hero.Hp += s.Attack();
                            if (hero.Hp <= 0)
                            {
                                Przebieg.Text += "\nPrzegrałeś.";
                                break;
                            }
                            Przebieg.Text += "\nTwoje aktualne hp: " + hero.Hp.ToString();
                        }
                        break;
                    }
                case "Czarny Rycerz":
                    {
                        BlackKnight b = new BlackKnight();

                        Przebieg.Text = "Hp przeciwnika: " + b.Hp.ToString();
                        Przebieg.Text += "\nHp bohatera: " + hero.Hp.ToString();

                        for (int i = 1; i <= 10; i++)
                        {
                            Przebieg.Text += "\n\nRUNDA " + i;

                            b.Hp += hero.Attack();
                            if (b.Hp <= 0)
                            {
                                Przebieg.Text += "\nWygrałeś.";
                                break;
                            }
                            Przebieg.Text += "\nHp Rycerza: " + b.Hp.ToString();
                            hero.Hp += b.Attack();
                            if (hero.Hp <= 0)
                            {
                                Przebieg.Text += "\nPrzegrałeś.";
                                break;
                            }
                            Przebieg.Text += "\nTwoje aktualne hp: " + hero.Hp.ToString();
                        }
                        break;
                    }
                case "Mroczny Mag":
                    {
                        DarkMage d = new DarkMage();

                        Przebieg.Text = "Hp przeciwnika: " + d.Hp.ToString();
                        Przebieg.Text += "\nHp bohatera: " + hero.Hp.ToString();

                        for (int i = 1; i <= 10; i++)
                        {
                            Przebieg.Text += "\n\nRUNDA " + i;
                            d.Hp += hero.Attack();
                            if (d.Hp <= 0)
                            {
                                Przebieg.Text += "\nWygrałeś.";
                                break;
                            }

                            Przebieg.Text += "\nHp Maga: " + d.Hp.ToString();
                            hero.Hp += d.Attack();
                            if (hero.Hp <= 0)
                            {
                                Przebieg.Text += "\nPrzegrałeś.";
                                break;
                            }
                            Przebieg.Text += "\nTwoje aktualne hp: " + hero.Hp.ToString();
                        }
                        break;
                    }
            }
        }

        private void buttonTravel_Click(object sender, RoutedEventArgs e)
        {
            Szukaj();

            
        }

        private void buttonRetreat_Click(object sender, RoutedEventArgs e)
        {
            Szukaj();
        }


        void Szukaj()
        {
            buttonFight.IsEnabled = true;
            buttonTravel.IsEnabled = false;
            buttonRetreat.IsEnabled = true;
            Random x = new Random();
            int num = x.Next(1, 4);
            switch (num)
            {
                case 1:
                    {
                        SuspectedBunny s = new SuspectedBunny();
                        zycieWrog.Text = s.Hp.ToString();
                        obrazeniaWrog.Text = s.Dmg.ToString();
                        przeciwnikWyglad.Source = new BitmapImage(new Uri("ms-appx:///Assets/SuspectedBunny.jpg"));
                        nazwaPrzeciwnik.Text = "Podejrzany Królik";
                        break;
                    }
                case 2:
                    {
                        BlackKnight b = new BlackKnight();
                        zycieWrog.Text = b.Hp.ToString();
                        obrazeniaWrog.Text = b.Dmg.ToString();
                        przeciwnikWyglad.Source = new BitmapImage(new Uri("ms-appx:///Assets/BlackKnight.jpg")); ;
                        nazwaPrzeciwnik.Text = "Czarny Rycerz"; ;
                        break;
                    }
                case 3:
                    {
                        DarkMage d = new DarkMage();
                        zycieWrog.Text = d.Hp.ToString();
                        obrazeniaWrog.Text = d.Dmg.ToString();
                        przeciwnikWyglad.Source = new BitmapImage(new Uri("ms-appx:///Assets/DarkMage.jpg"));
                        nazwaPrzeciwnik.Text = "Mroczny Mag";
                        break;
                    }
            }
        }

        private void checkBoxAtak_Click(object sender, RoutedEventArgs e)
        {
            checkBoxObrona.IsChecked = true;
            checkBoxObrona.IsEnabled = false;
            checkBoxAtak.IsEnabled = true;
        }

        private void checkBoxObrona_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxObrona.IsChecked == true)
            {
                checkBoxAtak.IsChecked = false;
            }
        }
    }
}
