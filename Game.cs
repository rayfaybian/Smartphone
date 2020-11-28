using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    class Game : App
    {
        private string _genre;

        

        public Game(string name, string version, string genre) : base(name, version)
        {
            
            this._genre = genre;
            this.Type = Type.GAME;

            
        }

        public override string ToString()
        {
            return "Game name: " + Name
                + "\nVersion: " +Version
                + "\nGenre: " + this._genre;
        }

        public override string Start()
        {
            return "Game " + Name + " v" + Version + " is running...";
        }
    }
}
