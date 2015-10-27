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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HockeyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const String Salavat = "Салават Юлаев";
        const String AkBars = "Ак Барс";

        List<Game> Games;
        public MainPage()
        {
            this.InitializeComponent();

            #region gamesInitialization
            Games = new List<Game>()
            {
                new Game() {
                    GameDate = DateTime.Parse("2015.10.26"),
                    HomeTeamName = "Адмирал",
                    GuestTeamName = Salavat,
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.24"),
                    HomeTeamName = "Салават Юлаев",
                    GuestTeamName = "Йокерит"
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.22"),
                    HomeTeamName = "Салават Юлаев",
                    GuestTeamName = "Динамо Рига"
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.20"),
                    HomeTeamName = "Салават Юлаев",
                    GuestTeamName = "Ак Барс"
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.20"),
                    HomeTeamName = "Металлург Мг",
                    GuestTeamName = Salavat
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.20"),
                    HomeTeamName = "Торпедо",
                    GuestTeamName = Salavat
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.10.30"),
                    HomeTeamName = "Динамо Минск",
                    GuestTeamName = Salavat
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.11.10"),
                    HomeTeamName = "Ак Барс",
                    GuestTeamName = Salavat
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.11.12"),
                    HomeTeamName = "Лада",
                    GuestTeamName = Salavat
                },
                new Game()
                {
                    GameDate = DateTime.Parse("2015.11.17"),
                    HomeTeamName = Salavat,
                    GuestTeamName = "Локомотив"
                }
            };
            #endregion gamesInitialization

            lstViewGames.ItemsSource = Games;
        }
    }
}
