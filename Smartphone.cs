using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    class Smartphone
    {
        public List<App> apps;

        public Smartphone()
        {
            this.apps = new List<App>();
        }

        public void InstallAppsAndGames()
        {
            App app1 = new App("Notes", "5.8");
            apps.Add(app1);
            App app2 = new App("Contacts", "10.4");
            apps.Add(app2);
            App app3 = new App("Appstore", "17.1");
            apps.Add(app3);
            App app4 = new App("News", "7.0");
            apps.Add(app4);
            App app5 = new App("Weather", "9.3");
            apps.Add(app5);

            Game game1 = new Game("Snake", "215.4.9", "Snake");
            apps.Add(game1);
            Game game2 = new Game("Flappy Bird", "2.4", "Jump 'n' Run");
            apps.Add(game2);
            Game game3 = new Game("Farm Hero", "5.7", "Simulation");
            apps.Add(game3);
        }

    }
}
