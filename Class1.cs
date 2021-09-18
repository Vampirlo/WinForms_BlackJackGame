using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using BlackJack.Properties;


namespace BlackJack
{
    public  class MyExtensions
    {

        public static int randNumToCard(int randomNumber)
        {
            int hand = 0;
            if (randomNumber >= 1 && randomNumber <= 4)
                hand = 11;
            else if (randomNumber >= 5 && randomNumber <= 8)
                hand = 2;
            else if (randomNumber >= 9 && randomNumber <= 12)
                hand = 3;
            else if (randomNumber >= 13 && randomNumber <= 16)
                hand = 4;
            else if (randomNumber >= 17 && randomNumber <= 20)
                hand = 5;
            else if (randomNumber >= 21 && randomNumber <= 24)
                hand = 6;
            else if (randomNumber >= 25 && randomNumber <= 28)
                hand = 7;
            else if (randomNumber >= 29 && randomNumber <= 32)
                hand = 8;
            else if (randomNumber >= 33 && randomNumber <= 36)
                hand = 9;
            else if (randomNumber >= 37 && randomNumber <= 52)
                hand = 10;
            return hand;
        }

    public static void Pboxmethod(int randnum, PictureBox pbox)
        {
            switch (randnum)
            {
                case 1:
                    pbox.Image = Resources._1;
                    break;
                case 2:
                    pbox.Image = Resources._2;
                    break;
                case 3:
                    pbox.Image = Resources._3;
                    break;
                case 4:
                    pbox.Image = Resources._4;
                    break;
                case 5:
                    pbox.Image = Resources._5;
                    break;
                case 6:
                    pbox.Image = Resources._6;
                    break;
                case 7:
                    pbox.Image = Resources._7;
                    break;
                case 8:
                    pbox.Image = Resources._8;
                    break;
                case 9:
                    pbox.Image = Resources._9;
                    break;
                case 10:
                    pbox.Image = Resources._10;
                    break;
                case 11:
                    pbox.Image = Resources._11;
                    break;
                case 12:
                    pbox.Image = Resources._12;
                    break;
                case 13:
                    pbox.Image = Resources._13;
                    break;
                case 14:
                    pbox.Image = Resources._14;
                    break;
                case 15:
                    pbox.Image = Resources._15;
                    break;
                case 16:
                    pbox.Image = Resources._16;
                    break;
                case 17:
                    pbox.Image = Resources._17;
                    break;
                case 18:
                    pbox.Image = Resources._18;
                    break;
                case 19:
                    pbox.Image = Resources._19;
                    break;
                case 20:
                    pbox.Image = Resources._20;
                    break;
                case 21:
                    pbox.Image = Resources._21;
                    break;
                case 22:
                    pbox.Image = Resources._22;
                    break;
                case 23:
                    pbox.Image = Resources._23;
                    break;
                case 24:
                    pbox.Image = Resources._24;
                    break;
                case 25:
                    pbox.Image = Resources._25;
                    break;
                case 26:
                    pbox.Image = Resources._26;
                    break;
                case 27:
                    pbox.Image = Resources._27;
                    break;
                case 28:
                    pbox.Image = Resources._28;
                    break;
                case 29:
                    pbox.Image = Resources._29;
                    break;
                case 30:
                    pbox.Image = Resources._30;
                    break;
                case 31:
                    pbox.Image = Resources._31;
                    break;
                case 32:
                    pbox.Image = Resources._32;
                    break;
                case 33:
                    pbox.Image = Resources._33;
                    break;
                case 34:
                    pbox.Image = Resources._34;
                    break;
                case 35:
                    pbox.Image = Resources._35;
                    break;
                case 36:
                    pbox.Image = Resources._36;
                    break;
                case 37:
                    pbox.Image = Resources._37;
                    break;
                case 38:
                    pbox.Image = Resources._38;
                    break;
                case 39:
                    pbox.Image = Resources._39;
                    break;
                case 40:
                    pbox.Image = Resources._40;
                    break;
                case 41:
                    pbox.Image = Resources._41;
                    break;
                case 42:
                    pbox.Image = Resources._42;
                    break;
                case 43:
                    pbox.Image = Resources._43;
                    break;
                case 44:
                    pbox.Image = Resources._44;
                    break;
                case 45:
                    pbox.Image = Resources._45;
                    break;
                case 46:
                    pbox.Image = Resources._46;
                    break;
                case 47:
                    pbox.Image = Resources._47;
                    break;
                case 48:
                    pbox.Image = Resources._48;
                    break;
                case 49:
                    pbox.Image = Resources._49;
                    break;
                case 50:
                    pbox.Image = Resources._50;
                    break;
                case 51:
                    pbox.Image = Resources._51;
                    break;
                case 52:
                    pbox.Image = Resources._52;
                    break;


            }
        }

    }
}
