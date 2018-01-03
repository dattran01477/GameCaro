using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{

    class BoardChessManager
    {
        Button[,] btn = new Button[30, 30];
        Button btnToSent;
        List<List<Button>> matrixBtn = new List<List<Button>>();
        TextBox txtName;
        Panel PanelBoardChess;
        List<Player> player = new List<Player> { };
        int currentPlayer = 0;
        int[,] maxtrixPlaying = new int[30, 30];
     
        //int[,] maxtrixOfPlayer2 = new int[30, 30];



        public BoardChessManager(Panel pn)
        {
            this.PanelBoardChess = pn;

            player.Add(new Player { Img = Propertie.imgX });
            player.Add(new Player { Img = Propertie.img0 });
            DrawBoard();
        }




        public void DrawBoard()
        {
            Button oldBtn = new Button();

            oldBtn.Location = new Point(0, 0);
            for (int i = 0; i < PanelBoardChess.Height / 50; i++)
            {
                matrixBtn.Add(new List<Button>());
                for (int j = 0; j < PanelBoardChess.Width / 50; j++)
                {
                    maxtrixPlaying[i, j] = 0;//ma trận tương đương của button


                    btn[i, j] = new Button();

                    btn[i, j].Width = 50;
                    btn[i, j].Height = 50;
                    btn[i, j].Tag = i.ToString();
                    btn[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[i, j].Location = new Point(oldBtn.Location.X + btn[i, j].Width, i * 50);

                    PanelBoardChess.Controls.Add(btn[i, j]);

                    btn[i, j].Click += Btn_Click;

                    oldBtn = btn[i, j];

                    matrixBtn[i].Add(btn[i, j]);
                }
                oldBtn.Location = new Point(0, i * 50);
            }


        }


        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            int row = Convert.ToInt32(btn.Tag);
            btnToSent = btn;
            int column = matrixBtn[row].IndexOf(btn);

            if (currentPlayer == 0)
            {

                player[currentPlayer].Play(btn);
                btn.Enabled = false;
                maxtrixPlaying[row, column+1] = 1;
                if (isEndGame(row, column+1))
                {
                    endGame();
                    return;
                }
                else
                    currentPlayer = 1;
                return;

            }
            if (currentPlayer == 1)
            {
                player[currentPlayer].Play(btn);
                btn.Enabled = false;
                maxtrixPlaying[row, column+1] = 2;
                if (isEndGame(row, column+1))
                {
                    endGame();
                    return;
                }
                else
                    currentPlayer = 0;
                return;
            }


            //btn.BackgroundImage = 
        }

        /// <summary>
        /// Sent button được đánh
        /// </summary>
        /// <param name="btn"></param>
        /// <returns></returns>
        public Button SentBtn()
        {
            return btnToSent;
        }
        

        
        /// <summary>
        /// kiểm tra kết thúc game
        /// </summary>
        /// <param name="_row"></param>
        /// <param name="_column"></param>
        /// <returns></returns>
        
        private bool isEndGame(int _row,int _column)
        {
            bool check = false;
            if (isVerticalLine(_row,_column) || isDiagonalLeft(_row, _column) || isDiagonalRight(_row, _column) || isHorizontalLine(_row, _column))
                check = true;
            return check;
        }
        private void endGame()
        {
            MessageBox.Show("nguoi choi:"+currentPlayer+" ban da thang");
        }


        /// <summary>
        /// kiem tra cac truong hop win
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool isVerticalLine(int i,int j)//hang doc
        {
            bool check = false;
            int coutTop=0;
            int coutDown=0;
            for(int t=i-1;t>=0;t--)
            {
                if (maxtrixPlaying[t, j] == maxtrixPlaying[i, j])
                    coutTop++;
                else
                    break;
            }
            for(int t=i+1;t< PanelBoardChess.Height/50;t++)
            {
                if (maxtrixPlaying[t, j] == maxtrixPlaying[i, j])
                    coutDown++;
                else
                    break;
            }
            if (coutTop + coutDown == 4)
                check = true;

            return check;

        }
        private bool isDiagonalLeft(int i, int j)//cheo trai
        {
            bool check = false;
            int coutDiagonalTop = 0;
            int coutDiagonalDown = 0;

            int jTemp1 = j;
            int jTemp2 = j;

            for (int t = i - 1; t >= 0&&jTemp1>0; t--)
            {
                if (maxtrixPlaying[t, jTemp1 - 1] == maxtrixPlaying[i, j])
                {
                    jTemp1--;
                    coutDiagonalTop++;
                }
                else
                    break;
            }
            for (int t = i + 1; t < PanelBoardChess.Height / 50&&jTemp2<PanelBoardChess.Height/50; t++)
            {
                if (maxtrixPlaying[t, jTemp2 + 1] == maxtrixPlaying[i, j])
                {
                    jTemp2++;
                    coutDiagonalDown++;
                }
                else
                    break;
            }

            if (coutDiagonalTop + coutDiagonalDown == 4)
                check = true;
            return check;
        }
        private bool isDiagonalRight(int i, int j)
        {
            bool check = false;
            int coutDiagonalTop = 0;
            int coutDiagonalDown = 0;

            int jTemp1 = j;
            int jTemp2 = j;

            for (int t = i - 1; t >= 0 && jTemp1 < PanelBoardChess.Height / 50; t--)
            {
                if (maxtrixPlaying[t, jTemp1 + 1] == maxtrixPlaying[i, j])
                {
                    jTemp1++;
                    coutDiagonalTop++;
                }
                else
                    break;
            }
            for (int t = i + 1; t < PanelBoardChess.Height / 50 && jTemp2 >0; t++)
            {
                if (maxtrixPlaying[t, jTemp2 -1] == maxtrixPlaying[i, j])
                {
                    jTemp2--;
                    coutDiagonalDown++;
                }
                else
                    break;
            }

            if (coutDiagonalTop + coutDiagonalDown == 4)
                check = true;
            return check;
        }
        private bool isHorizontalLine(int i, int j)
        {
            bool check = false;
            int coutTop = 0;
            int coutDown = 0;
            for (int t = j - 1; t >= 0; t--)
            {
                if (maxtrixPlaying[i, t] == maxtrixPlaying[i, j])
                    coutTop++;
                else
                    break;
            }
            for (int t = j + 1; t < PanelBoardChess.Height / 50; t++)
            {
                if (maxtrixPlaying[i, t] == maxtrixPlaying[i, j])
                    coutDown++;
                else
                    break;
            }
            if (coutTop + coutDown == 4)
                check = true;
            return check;
        }
    }

}
