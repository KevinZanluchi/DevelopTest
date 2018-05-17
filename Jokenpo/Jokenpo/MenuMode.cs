using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class MenuMode : Form
    {
        int mode = 0;
        int round = 0;
        int i = 1;
        int move_Player = 0;
        int move_Comp1 = 0;
        int move_Comp2 = 0;
        int score_Player = 0;
        int score_Comp1 = 0;
        int score_Comp2 = 0;
        public MenuMode()
        {
            InitializeComponent();
        }

        //mode player vs computer checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ModePlayerVsComp.Checked)
            {
                mode = 1;
            }
            else
            {
                mode = 0;
            }
        }

        // play buttom
        private void PlayButtom_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    LabelWarning.Text = "Escolha uma das opções para prosseguir!";
                    break;
                case 1:
                    if (round != 0)
                    {
                        MenuChooseModeExit();
                        MenuPlayerVsCompEnter();
                    }
                    else
                    {
                        LabelWarning.Text = "Insira o número de rodadas!";
                    }
                    break;
                case 2:
                    if (round != 0)
                    {
                        MenuChooseModeExit();
                        MenuCompVsCompEnter();
                    }
                    else
                    {
                        LabelWarning.Text = "Insira o número de rodadas!";
                    }
                    break;
            }
        }

        // mode computer vs computer  checkbox
        private void ModeCompVsComp_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeCompVsComp.Checked)
            {
                mode = 2;
            }
            else
            {
                mode = 0;
            }
        }

        //clear the main menu
        private void MenuChooseModeExit()
        {
            PlayButton.Visible = false;
            ModePlayerVsComp.Visible = false;
            ModeCompVsComp.Visible = false;
            LabelWarning.Text = "";
            LabelRound.Visible = false;
            TextBoxNumRound.Visible = false;
        }

        //set the main menu
        private void MenuChooseModeEnter()
        {
            LabelDescription.Text = "Escolha o modo de jogo desejado!";
            PlayButton.Visible = true;
            ModePlayerVsComp.Visible = true;
            ModeCompVsComp.Visible = true;
            LabelWarning.Text = "";
            LabelRound.Visible = true;
            TextBoxNumRound.Visible = true;
        }

        //set player vs computer game
        private void MenuPlayerVsCompEnter()
        {
            LabelDescription.Text = "Rodada " + i ;
            LabelScoreboard.Visible = true;
            LabelScoreboard.Text = " PLACAR: Player " + score_Player + "Vs Computador " + score_Comp1;
            LabelMovePlayer.Visible = true;
            LabelMoveComp.Visible = true;
            LabelVs.Visible = true;
            StoneButton.Visible = true;
            PaperButton.Visible = true;
            ScissorsButton.Visible = true;
        }

        //reset to a new round
        private void MenuPlayerVsCompStay()
        {
            StoneButton.Visible = true;
            PaperButton.Visible = true;
            ScissorsButton.Visible = true;
            NextPVsCButton.Visible = false;
            LabelWinRound.Visible = false;
            LabelDescription.Text = "Rodada " + i;
            LabelScoreboard.Text = " PLACAR: Player " + score_Player + " Vs Computador " + score_Comp1;
            LabelMovePlayer.Text = "?";
            LabelMoveComp.Text = "?";
            move_Player = 0;
            move_Comp1 = 0;
        }

        //clear player vs computer game
        private void MenuPlayerVsCompExit()
        {
            LabelScoreboard.Visible = false;
            LabelWinRound.Visible = false;
            LabelMovePlayer.Visible = false;
            LabelMoveComp.Visible = false;
            LabelVs.Visible = false;
            StoneButton.Visible = false;
            PaperButton.Visible = false;
            ScissorsButton.Visible = false;
            NextPVsCButton.Visible = false;
        }

        // see who won the player vs computer round
        private void MenuWinRoundPlayerVsComp()
        {
            LabelWinRound.Visible = true;
            switch (Win_round(move_Player, move_Comp1))
            {
                case 0:
                    LabelWinRound.Text = "Computador ganhou essa rodada!";
                    score_Comp1++;
                    break;
                case 1:
                    LabelWinRound.Text = "Você ganhou essa rodada!";
                    score_Player++;
                    break;
                case 2:
                    LabelWinRound.Text = "Empate!";
                    break;
            }
            NextPVsCButton.Visible = true;
            StoneButton.Visible = false;
            PaperButton.Visible = false;
            ScissorsButton.Visible = false;

        }

        // see who won computer vs comuter round
        private void MenuWinRoundCompVsComp()
        {
            LabelWinRound.Visible = true;
            switch (Win_round(move_Comp1, move_Comp2))
            {
                case 0:
                    LabelWinRound.Text = "Computador2 ganhou essa rodada!";
                    score_Comp2++;
                    break;
                case 1:
                    LabelWinRound.Text = "Computador1 ganhou essa rodada!";
                    score_Comp1++;
                    break;
                case 2:
                    LabelWinRound.Text = "Empate!";
                    break;
            }
        }

        // set computer vs computer game
        private void MenuCompVsCompEnter()
        {
            i = 0;
            LabelDescription.Text = "";
            LabelScoreboard.Visible = true;
            LabelScoreboard.Text = " PLACAR: Computador1 " + score_Comp1 + "Vs Computador2 " + score_Comp2;
            LabelMovePlayer.Visible = true;
            LabelMoveComp.Visible = true;
            LabelVs.Visible = true;
            NextComVsCompButton.Visible = true;
        }

        // reset to a new round
        private void MenuCompVsCompStay()
        {
            LabelDescription.Text = "Rodada " + i;
            LabelScoreboard.Text = "PLACAR: Computador1 " + score_Comp1 + "Vs Computador2 " + score_Comp2;
            move_Comp2 = 0;
            move_Comp1 = 0;
        }

        //clear computer vs computer game
        private void MenuCompVsCompExit()
        {
            LabelWinRound.Visible = false;
            LabelScoreboard.Visible = false;
            LabelMovePlayer.Visible = false;
            LabelMoveComp.Visible = false;
            LabelVs.Visible = false;
            NextComVsCompButton.Visible = false;
        }

        //return who won the round
        private int Win_round(int player1, int player2)
        {
            switch (player1)
            {
                case 1:
                    switch (player2)
                    {
                        case 1:
                            return 2;
                        case 2:
                            return 0;
                        case 3:
                            return 1;
                    }
                    break;
                case 2:
                    switch (player2)
                    {
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        case 3:
                            return 0;
                    }
                    break;
                case 3:
                    switch (player2)
                    {
                        case 1:
                            return 0;
                        case 2:
                            return 1;
                        case 3:
                            return 2;
                    }
                    break;
            }
            return 4;

        }

        // see who won the game
        private void Win(int score_Player1, int score_Player2, int mode)
        {
            if (mode == 1)
            {

                if (score_Player1 > score_Player2)
                {
                    LabelDescription.Text = "Meu Parabéns!!! Você Ganhou!!!";
                }
                else if (score_Player1 < score_Player2)
                {
                    LabelDescription.Text = "Você Perdeu...";
                }
                else if (score_Player1 == score_Player2)
                {
                    LabelDescription.Text = "Empate!";
                }
            }
            else
            {
                if (score_Player1 > score_Player2)
                {
                    LabelDescription.Text = "Computador 1 é o vencedor!!!";
                }
                else if (score_Player1 < score_Player2)
                {
                    LabelDescription.Text = "Computador 2 é o vencedor!!!";
                }
                else if (score_Player1 == score_Player2)
                {
                    LabelDescription.Text = "Empate!";
                }
            }

        }

        //set menu after  game
        private void MenuFinalEnter(int mode)
        {
            if (mode == 1)
            {
                Win(score_Player,score_Comp1,mode);
            }
            else
            {
                Win(score_Comp1, score_Comp2,mode);
            }

            ContinuesButton.Visible = true;
            ExitButton.Visible = true;
        }

        //clear menu after game
        private void MenuFinalExit()
        {
            ContinuesButton.Visible = false;
            ExitButton.Visible = false;
        }

            private void MenuMode_Load(object sender, EventArgs e)
        {

        }

        // convert string of textbox to int
        private void TextBoxNumRound_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxNumRound.Text, out round))
            {
                round = int.Parse(TextBoxNumRound.Text);
            }
        }

        //button stone in player vs computer mode
        private void StoneButton_Click(object sender, EventArgs e)
        {
            LabelMovePlayer.Text = "Pedra";
            move_Player = 1;
            MoveComp(LabelMoveComp,1);
            MenuWinRoundPlayerVsComp();
        }

        //button paper in player vs computer mode
        private void PaperButton_Click(object sender, EventArgs e)
        {
            LabelMovePlayer.Text = "Papel";
            move_Player = 2;
            MoveComp(LabelMoveComp, 1);
            MenuWinRoundPlayerVsComp();
        }

        //button scissor in player vs computer mode
        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            LabelMovePlayer.Text = "Tesoura";
            move_Player = 3;
            MoveComp(LabelMoveComp, 1);
            MenuWinRoundPlayerVsComp();
        }

        //return random number
        private int MoveRandComp()
        {
            Random rand = new Random();
            Thread.Sleep(20);
            return rand.Next(1, 4);
        }

        //computer' move
        private void MoveComp(Label comp, int comput)
        {
            switch (MoveRandComp())
            {
                case 1:
                    comp.Text = "Pedra";
                    if (comput == 1)
                    {
                        move_Comp1 = 1;
                    }
                    else
                    {
                        move_Comp2 = 1;
                    }
                    break;
                case 2:
                    comp.Text = "Papel";
                    if (comput == 1)
                    {
                        move_Comp1 = 2;
                    }
                    else
                    {
                        move_Comp2 = 2;
                    }
                    break;
                case 3:
                    comp.Text = "Tesoura";
                    if (comput == 1)
                    {
                        move_Comp1 = 3;
                    }
                    else
                    {
                        move_Comp2 = 3;
                    }
                    break;
            }
        }

        //button to go to new round or end game in player vs computer
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (i < round)
            {
                i++;
                MenuPlayerVsCompStay();
            }
            else
            {
                MenuPlayerVsCompExit();
                MenuFinalEnter(1);
            }
        }

        // reset variables
        private void Reset()
        {
            mode = 0;
            round = 0;
            i = 1;
            move_Player = 0;
            move_Comp1 = 0;
            move_Comp2 = 0;
            score_Player = 0;
            score_Comp1 = 0;
            score_Comp2 = 0;
            LabelMovePlayer.Text = "?";
            LabelMoveComp.Text = "?";
            ModePlayerVsComp.Checked = false;
            ModeCompVsComp.Checked = false;
            TextBoxNumRound.Text = "";
        }

        //to continue in the game
        private void ContinuesButton_Click(object sender, EventArgs e)
        {
            Reset();
            MenuFinalExit();
            MenuChooseModeEnter();
        }

        //exit the game
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //button to go to new round or end game in computer vs computer
        private void NextComVsCompButton_Click(object sender, EventArgs e)
        {
            if (i < round)
            {
                MoveComp(LabelMovePlayer, 1);
                MoveComp(LabelMoveComp, 2);
                MenuWinRoundCompVsComp();
                i++;
                MenuCompVsCompStay();
            }
            else
            {
                MenuCompVsCompExit();
                MenuFinalEnter(2);
            }
        }
    }
}
