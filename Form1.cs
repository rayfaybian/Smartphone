using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartphone
{
    public partial class Form1 : Form
    {
        Smartphone myPhone = new Smartphone();
        List<string> appSelection = new List<string>();


        public Form1()
        {
            InitializeComponent();
            myPhone.InstallAppsAndGames();
            selectALL();

        }


        private void updateList(List<string> applist, int selection)
        {
            lbAppList.DataSource = null;
            lbAppList.DataSource = applist;

            switch (selection)
            {
                case 1:
                    labelLB.Text = "Apps and Games";
                    break;

                case 2:
                    labelLB.Text = "Apps";
                    break;

                case 3:
                    labelLB.Text = "Games";
                    break;
            }

            lbAppList.ClearSelected();
            clearDisplay();

        }

        private void atAll_Click(object sender, EventArgs e)
        {
            selectALL();

        }

        private void btApps_Click(object sender, EventArgs e)
        {
            selectApps();
        }

        private void btGames_Click(object sender, EventArgs e)
        {
            selectGames();
        }
     
        private void btStart_Click(object sender, EventArgs e)
        {
            string selection = lbAppList.SelectedItem as string;

            foreach (var item in myPhone.apps)
            {
                if (item.Name.Equals(selection))
                {
                    labelDisplay.Text = item.Start();
                }
            }

            lbAppList.ClearSelected();
        }

        private void btInstall_Click(object sender, EventArgs e)
        {
            var name = tbName.Text;
            var version = tbVersion.Text;
            var genre = tbGenre.Text;

            if (!cbApp.Checked && !cbGame.Checked)
            {
                labelDisplay.Text = "Select a Type";
            }
            if (cbApp.Checked && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(version))
            {
                App newApp = new App(name, version);
                myPhone.apps.Add(newApp);

                labelDisplay.Text = name + " " + version + "\n\nINSTALLING APP";
                ClearForm();
            }

            if (cbGame.Checked && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(version) && !string.IsNullOrEmpty(genre))
            {
                Game newGame = new Game(name, version, genre);
                myPhone.apps.Add(newGame);

                labelDisplay.Text = "INSTALLING GAME";
                ClearForm();
            }
            
            
        }

        private void cbGame_CheckedChanged(object sender, EventArgs e)
        {
            cbApp.Checked = false;
        }

        private void cbApp_CheckedChanged(object sender, EventArgs e)
        {
            cbGame.Checked = false;

        }

        private void ClearForm()
        {
            tbGenre.Text = "";
            tbName.Text = "";
            tbVersion.Text = "";
            cbApp.Checked = false;
            cbGame.Checked = false;
        }

        private void selectALL()
        {
            var filtered = from a in myPhone.apps
                           orderby a.Name
                           select a.Name;

            updateList(filtered.ToList(), 1);
        }

        private void selectApps()
        {
            var filtered = from a in myPhone.apps
                           where a.Type.Equals(Type.APP)
                           orderby a.Name
                           select a.Name;

            updateList(filtered.ToList(), 2);
        }

        private void selectGames()
        {
            var filtered = from a in myPhone.apps
                           where a.Type.Equals(Type.GAME)
                           orderby a.Name
                           select a.Name;

            updateList(filtered.ToList(), 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selection = lbAppList.SelectedItem as string;

            if (!string.IsNullOrEmpty(selection))
            {
                foreach(var item in myPhone.apps)
                {
                    if (selection.Equals(item.Name))
                    {
                        labelDisplay.Text = item.ToString();
                    }
                }
            }
        }

        private void clearDisplay()
        {
            labelDisplay.Text = "";
        }
    }
}
