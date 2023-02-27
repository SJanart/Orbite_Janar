namespace Projet_Orbite_Janar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            navette.Location = new Point(10, 340); // position de base


        }

        private void start_game(object sender, EventArgs e)
        {
            chrono.Enabled = true; // pour activer le timer ( chrono = 10s )

        }


        private void chrono_Tick(object sender, EventArgs e) //boucle du jeu
        {
            navette.Location = new Point(101, 278);
            navette.Location = new Point(273, 211);
            navette.Location = new Point(441, 163);
            navette.Location = new Point(595, 102);
            navette.Location = new Point(680, 35); // position final

        }

    
    }


}