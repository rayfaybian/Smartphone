
namespace Smartphone
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbAppList = new System.Windows.Forms.ListBox();
            this.labelLB = new System.Windows.Forms.Label();
            this.btApps = new System.Windows.Forms.Button();
            this.atAll = new System.Windows.Forms.Button();
            this.btGames = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.labelNewVersion = new System.Windows.Forms.Label();
            this.lableNewGenre = new System.Windows.Forms.Label();
            this.labelNewAppOrGame = new System.Windows.Forms.Label();
            this.btInstall = new System.Windows.Forms.Button();
            this.cbApp = new System.Windows.Forms.CheckBox();
            this.cbGame = new System.Windows.Forms.CheckBox();
            this.btStart = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(210, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smartphone";
            // 
            // lbAppList
            // 
            this.lbAppList.FormattingEnabled = true;
            this.lbAppList.ItemHeight = 16;
            this.lbAppList.Location = new System.Drawing.Point(34, 175);
            this.lbAppList.Name = "lbAppList";
            this.lbAppList.Size = new System.Drawing.Size(241, 276);
            this.lbAppList.TabIndex = 1;
            // 
            // labelLB
            // 
            this.labelLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLB.Location = new System.Drawing.Point(34, 136);
            this.labelLB.Name = "labelLB";
            this.labelLB.Size = new System.Drawing.Size(242, 25);
            this.labelLB.TabIndex = 2;
            this.labelLB.Text = "Apps and Games";
            this.labelLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btApps
            // 
            this.btApps.Location = new System.Drawing.Point(34, 505);
            this.btApps.Name = "btApps";
            this.btApps.Size = new System.Drawing.Size(75, 42);
            this.btApps.TabIndex = 3;
            this.btApps.Text = "Apps";
            this.btApps.UseVisualStyleBackColor = true;
            this.btApps.Click += new System.EventHandler(this.btApps_Click);
            // 
            // atAll
            // 
            this.atAll.Location = new System.Drawing.Point(118, 505);
            this.atAll.Name = "atAll";
            this.atAll.Size = new System.Drawing.Size(75, 42);
            this.atAll.TabIndex = 3;
            this.atAll.Text = "Show all";
            this.atAll.UseVisualStyleBackColor = true;
            this.atAll.Click += new System.EventHandler(this.atAll_Click);
            // 
            // btGames
            // 
            this.btGames.Location = new System.Drawing.Point(201, 505);
            this.btGames.Name = "btGames";
            this.btGames.Size = new System.Drawing.Size(75, 42);
            this.btGames.TabIndex = 3;
            this.btGames.Text = "Games";
            this.btGames.UseVisualStyleBackColor = true;
            this.btGames.Click += new System.EventHandler(this.btGames_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(380, 183);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(213, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(380, 229);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(213, 22);
            this.tbVersion.TabIndex = 4;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(380, 278);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(213, 22);
            this.tbGenre.TabIndex = 4;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(377, 163);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(45, 17);
            this.labelNewName.TabIndex = 2;
            this.labelNewName.Text = "Name";
            // 
            // labelNewVersion
            // 
            this.labelNewVersion.AutoSize = true;
            this.labelNewVersion.Location = new System.Drawing.Point(377, 208);
            this.labelNewVersion.Name = "labelNewVersion";
            this.labelNewVersion.Size = new System.Drawing.Size(56, 17);
            this.labelNewVersion.TabIndex = 2;
            this.labelNewVersion.Text = "Version";
            // 
            // lableNewGenre
            // 
            this.lableNewGenre.AutoSize = true;
            this.lableNewGenre.Location = new System.Drawing.Point(377, 258);
            this.lableNewGenre.Name = "lableNewGenre";
            this.lableNewGenre.Size = new System.Drawing.Size(48, 17);
            this.lableNewGenre.TabIndex = 2;
            this.lableNewGenre.Text = "Genre";
            // 
            // labelNewAppOrGame
            // 
            this.labelNewAppOrGame.AutoSize = true;
            this.labelNewAppOrGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNewAppOrGame.Location = new System.Drawing.Point(375, 127);
            this.labelNewAppOrGame.Name = "labelNewAppOrGame";
            this.labelNewAppOrGame.Size = new System.Drawing.Size(172, 25);
            this.labelNewAppOrGame.TabIndex = 5;
            this.labelNewAppOrGame.Text = "New App or Game";
            // 
            // btInstall
            // 
            this.btInstall.Location = new System.Drawing.Point(380, 357);
            this.btInstall.Name = "btInstall";
            this.btInstall.Size = new System.Drawing.Size(117, 30);
            this.btInstall.TabIndex = 6;
            this.btInstall.Text = "Install App";
            this.btInstall.UseVisualStyleBackColor = true;
            this.btInstall.Click += new System.EventHandler(this.btInstall_Click);
            // 
            // cbApp
            // 
            this.cbApp.AutoSize = true;
            this.cbApp.Location = new System.Drawing.Point(380, 318);
            this.cbApp.Name = "cbApp";
            this.cbApp.Size = new System.Drawing.Size(55, 21);
            this.cbApp.TabIndex = 7;
            this.cbApp.Text = "App";
            this.cbApp.UseVisualStyleBackColor = true;
            this.cbApp.CheckedChanged += new System.EventHandler(this.cbApp_CheckedChanged);
            // 
            // cbGame
            // 
            this.cbGame.AutoSize = true;
            this.cbGame.Location = new System.Drawing.Point(460, 318);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(68, 21);
            this.cbGame.TabIndex = 7;
            this.cbGame.Text = "Game";
            this.cbGame.UseVisualStyleBackColor = true;
            this.cbGame.CheckedChanged += new System.EventHandler(this.cbGame_CheckedChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(35, 553);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(117, 40);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDisplay.Location = new System.Drawing.Point(34, 454);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(241, 48);
            this.labelDisplay.TabIndex = 9;
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.cbGame);
            this.Controls.Add(this.cbApp);
            this.Controls.Add(this.btInstall);
            this.Controls.Add(this.labelNewAppOrGame);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btGames);
            this.Controls.Add(this.atAll);
            this.Controls.Add(this.btApps);
            this.Controls.Add(this.lableNewGenre);
            this.Controls.Add(this.labelNewVersion);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.labelLB);
            this.Controls.Add(this.lbAppList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAppList;
        private System.Windows.Forms.Label labelLB;
        private System.Windows.Forms.Button btApps;
        private System.Windows.Forms.Button atAll;
        private System.Windows.Forms.Button btGames;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Label labelNewVersion;
        private System.Windows.Forms.Label lableNewGenre;
        private System.Windows.Forms.Label labelNewAppOrGame;
        private System.Windows.Forms.Button btInstall;
        private System.Windows.Forms.CheckBox cbApp;
        private System.Windows.Forms.CheckBox cbGame;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Button button1;
    }
}

