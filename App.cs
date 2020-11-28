using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    public enum Type { APP, GAME }
    class App
    {
        private string _name;
        public string Name { get { return _name; } }

        private string _version;

        public string Version { get { return _version; } }

        private Type _type;

        public Type Type { get { return _type; } set { _type = value; } }


        public App(string name, string version)
        {
            this._name = name;
            this._version = version;
            this._type = Type.APP;
        }
        public override string ToString()
        {
            return "App name: " + this._name +
                "\nVersion: " + this._version;
        }

        public virtual string Start()
        {
            return "App " + _name + " v" + _version + " is running...";
        }
    }
}
