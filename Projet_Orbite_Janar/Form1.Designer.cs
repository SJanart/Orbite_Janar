namespace Projet_Orbite_Janar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navette = new System.Windows.Forms.PictureBox();
            this.chrono = new System.Windows.Forms.Timer(this.components);
            this.launch_game = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navette)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Projet_Orbite_Janar.Properties.Resources.planet;
            this.pictureBox1.Location = new System.Drawing.Point(699, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // navette
            // 
            this.navette.BackColor = System.Drawing.Color.Transparent;
            this.navette.Image = global::Projet_Orbite_Janar.Properties.Resources.Navette;
            this.navette.Location = new System.Drawing.Point(12, 340);
            this.navette.Name = "navette";
            this.navette.Size = new System.Drawing.Size(98, 98);
            this.navette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navette.TabIndex = 1;
            this.navette.TabStop = false;
            // 
            // chrono
            // 
            this.chrono.Interval = 500;
            this.chrono.Tick += new System.EventHandler(this.chrono_Tick);
            // 
            // launch_game
            // 
            this.launch_game.AutoSize = true;
            this.launch_game.BackColor = System.Drawing.Color.White;
            this.launch_game.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.launch_game.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.launch_game.Location = new System.Drawing.Point(12, 9);
            this.launch_game.Name = "launch_game";
            this.launch_game.Size = new System.Drawing.Size(96, 36);
            this.launch_game.TabIndex = 2;
            this.launch_game.Text = "Launch";
            this.launch_game.Click += new System.EventHandler(this.start_game);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Orbite_Janar.Properties.Resources.Background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.launch_game);
            this.Controls.Add(this.navette);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Projet Orbite ( By Janar )";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox navette;
        private System.Windows.Forms.Timer chrono;
        private Label launch_game;
    }
}