using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaCobrinha
{
    class Game
    {
        public Keys Direction { get; set; }
        public Keys Arrow { get; set; }

        private System.Windows.Forms.Timer Frame { get; set; }
        private System.Windows.Forms.Label Score_Point { get; set; }
        private System.Windows.Forms.Panel Panel_Screem { get; set; }

        private int poits = 0;

        private Food Food;
        private Snake Snake;

        private Bitmap offScreemBitmap;
        private Graphics bitmapGraphic;
        private Graphics screen;

        public Game(ref System.Windows.Forms.Timer timer, ref Label label, ref Panel panel)
        {
            Panel_Screem = panel;
            Frame = timer;
            Score_Point = label;
            offScreemBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Food = new Food();

            Direction = Keys.Left;
            Arrow = Direction;
        }

        public void StartGame()
        {
            Snake.Reset();
            Food.CreateFood();
            Direction = Keys.Left;
            bitmapGraphic = Graphics.FromImage(offScreemBitmap);
            screen = Panel_Screem.CreateGraphics();
            Frame.Enabled= true;
        }

        public void Update()
        {
            if(((Arrow == Keys.Left)&& (Direction != Keys.Right)) ||
                ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
                ((Arrow == Keys.Up) && (Direction != Keys.Down)) ||
                ((Arrow == Keys.Down) && (Direction != Keys.Up)))
            {
                Direction = Arrow;
            }

            switch (Direction)
            {
                case Keys.Left:
                    Snake.Left();
                    break;

                case Keys.Right:
                    Snake.Right();
                    break;

                case Keys.Up:
                    Snake.Up();
                    break;

                case Keys.Down:
                    Snake.Down();
                    break;
            }

            bitmapGraphic.Clear(Color.White);
            bitmapGraphic.DrawImage(Properties.Resources.apple, (Food.Location.X*15), (Food.Location.Y * 15), 15,15);
            bool gameOver = false;

            for (int i = 0; i < Snake.Length; i++)
            {
                if (i == 0)
                {
                    bitmapGraphic.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#000000")), (Snake.Location[i].X * 15),
                        (Snake.Location[i].Y * 15), 15, 15);
                }
                else
                {
                    bitmapGraphic.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#4F4F4F")), (Snake.Location[i].X * 15),
                        (Snake.Location[i].Y * 15), 15, 15);
                }

                if ((Snake.Location[i] == Snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }

            screen.DrawImage(offScreemBitmap,0,0);

            CheckColision();
            if (gameOver)
            {
                GameOver();
            }

        }

        public void CheckColision()
        {
            if (Snake.Location[0] == Food.Location)
            {
                Snake.Eat();
                Food.CreateFood();
                poits += 3;
                Score_Point.Text = $"Score: {poits}";
            }
        }

        public void GameOver()
        {
            Frame.Enabled= false;
            bitmapGraphic.Dispose();
            screen.Dispose();
            Score_Point.Text = $"Score: 000";
            poits = 0;
            MessageBox.Show("GameOver");
        }

    }
}
