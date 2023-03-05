namespace JogoDaCobrinha
{
    public partial class Form1 : Form
    {
        Game Game;
        public Form1()
        {
            InitializeComponent();
            Game = new Game(ref Frame, ref Score_Point, ref Panel_Screem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciarGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.StartGame();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            Game.Update();
        }

        private void Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                Game.Arrow = e.KeyCode;
            }
        }

        private void sobreOGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por Miller Vasco - @vascodeveloper");
        }
    }
}