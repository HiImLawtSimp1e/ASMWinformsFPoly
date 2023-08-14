using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    { 
        int CHESS_WIDTH;
        int CHESS_HEIGHT;

        int CHESS_BOARD_WIDTH;
        int CHESS_BOARD_HEIGHT;
        private List<Player> pler;

        internal List<Player> Pler { get => pler; set => pler = value; }

        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        public Form1()
        {
            InitializeComponent();
            this.Pler = new List<Player>()
            {
                new Player("O",Image.FromFile(Application.StartupPath + "\\Image\\O.PNG")),
                new Player("X",Image.FromFile(Application.StartupPath + "\\Image\\X.PNG")),
            };
            CurrentPlayer = 0;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            pnl_ChessBoard.Controls.Clear();
            if(rdoBtn_15x15.Checked)
            {
                CHESS_WIDTH = 30;
                CHESS_HEIGHT = 30;

                CHESS_BOARD_WIDTH = 15;
                CHESS_BOARD_HEIGHT = 15;
            }
            else if (rdoBtn_5x5.Checked)
            {
                CHESS_WIDTH = 90;
                CHESS_HEIGHT = 90;

                CHESS_BOARD_WIDTH = 5;
                CHESS_BOARD_HEIGHT = 5;
            }
            else if (rdoBtn_10x10.Checked)
            {
                CHESS_WIDTH = 45;
                CHESS_HEIGHT = 45;

                CHESS_BOARD_WIDTH = 10;
                CHESS_BOARD_HEIGHT = 10;
            }
            DrawChessBoard();
        }

        void DrawChessBoard()
        {
            Matrix = new List<List<Button>>(); //
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0;i < CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>()); //
                for (int j =0;j <= CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = CHESS_WIDTH,
                        Height = CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() //
                    };

                    btn.Click += Btn_Click;

                    pnl_ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn); //

                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
            
        }

        private bool isEndGame(Button btn)
        {
            return winHorizontal(btn) || winVertical(btn) || winDepth1(btn) || winDepth2(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal,vertical);

            return point;
        }
        private bool winHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for(int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight >= 5;
        }
        private bool winVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = point.Y + 1; i < CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }

            return countTop + countBot >= 5;
        }
        private bool winDepth1(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <= CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= CHESS_BOARD_HEIGHT || point.X + i >= CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }

            return countTop + countBot >= 5;
        }
        private bool winDepth2(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <= CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBot++;
                }
                else
                    break;
            }

            return countTop + countBot >= 5;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            btn.BackgroundImage = Pler[CurrentPlayer].Mark;

            if (isEndGame(btn)) //
            {
                MessageBox.Show("Người chơi " + Pler[CurrentPlayer].Name + " đã thắng");
            }

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

    }
}
