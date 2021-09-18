using BlackJack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    
    public partial class Form1 : Form
    {
        int handCardWait = 0;
        int PlayerHand = 0;
        int DealerHand = 0;
        int bet = 0;
        int Playerchips = 5;
        static Random r = new Random();
        int randomNumber = r.Next(1, 52);
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"You balance: {Playerchips.ToString()}";
            Start_Button.Enabled = false;
            button_DOUBLE.Enabled = false;
            button_HIT.Enabled = false;
            button_STAND.Enabled = false;
            button_SPLIT.Enabled = false;

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            button_DOUBLE.Enabled = true;
            button_HIT.Enabled = true;
            button_STAND.Enabled = true;
            button_SPLIT.Enabled = true;
            Start_Button.Enabled = false;

            handCardWait = MyExtensions.randNumToCard(randomNumber);
            PlayerHand += handCardWait;
            MyExtensions.Pboxmethod(randomNumber, pictureBox1);
            //pictureBox1.Image = Image.FromFile(MyExtensions.PboxString(randomNumber));
            randomNumber = r.Next(1, 52);

            handCardWait = MyExtensions.randNumToCard(randomNumber);
            MyExtensions.Pboxmethod(randomNumber, pictureBox2);
            //pictureBox2.Image = Image.FromFile(MyExtensions.PboxString(randomNumber));
            PlayerHand += handCardWait;

            if (PlayerHand > 21 && handCardWait == 11)
                PlayerHand -= 10;
            label5.Text = $"You score: {PlayerHand.ToString()}";

            
            randomNumber = r.Next(1, 52);
            handCardWait = MyExtensions.randNumToCard(randomNumber);
            DealerHand += handCardWait;
            MyExtensions.Pboxmethod(randomNumber, pictureBox11);
            //pictureBox11.Image = Image.FromFile(MyExtensions.PboxString(randomNumber));
            label6.Text = $"Dealer score: {DealerHand.ToString()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_STAND.Enabled = false;
            button_SPLIT.Enabled = false;
            button_HIT.Enabled = false;
            button_DOUBLE.Enabled = false;
            while (DealerHand < 17)
            {
                randomNumber = r.Next(1, 52);
                handCardWait = MyExtensions.randNumToCard(randomNumber);
                DealerHand += handCardWait;
                if (DealerHand > 21 && randomNumber == 11)
                    DealerHand -= 10;

                if (pictureBox12.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox12);
                else if (pictureBox13.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox13);
                else if (pictureBox14.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox14);
                else if (pictureBox15.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox15);
                else if (pictureBox16.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox16);
                else if (pictureBox17.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox17);
                else if (pictureBox18.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox18);
                else if (pictureBox19.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox19);
                else if (pictureBox20.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox20);
            }
            label6.Text = $"Dealer score: {DealerHand.ToString()}";
            /*1(d > 21 && y <= 21), 2(d > 21 && y > 21), 3(y > d), 4(y < d), 5(y == d) 6(y > 21 && d <= 21), 7(y > 21 && d > 21) */
            if (DealerHand > 21 && PlayerHand <= 21)
            {
                Playerchips += bet;
                bet = 0;
                label1.Text = $"You balance: {Playerchips.ToString()}";
                label3.Text = $"You bet: {bet}";
                MessageBox.Show("У дилера перебор, вы выиграли.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
            else if (DealerHand > 21 && PlayerHand > 21)
            {
                bet = 0;
                label3.Text = $"You bet: {bet}";
                MessageBox.Show("Ничья. Вы оба обосрались.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
            else if (PlayerHand > DealerHand && PlayerHand <= 21)
            {
                Playerchips += bet;
                bet = 0;
                label1.Text = $"You balance: {Playerchips.ToString()}";
                label3.Text = $"You bet: {bet}";
                MessageBox.Show("Вы выиграли.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
            else if (PlayerHand < DealerHand && DealerHand <= 21)
            {
                Playerchips -= bet;
                bet = 0;
                label1.Text = $"You balance: {Playerchips.ToString()}";
                label3.Text = $"You bet: {bet}";
                MessageBox.Show("Дилер победил.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
            else if (PlayerHand == DealerHand)
            {
                bet = 0;
                label1.Text = $"You balance: {Playerchips.ToString()}";
                label3.Text = $"You bet: {bet}";
                MessageBox.Show("Ничья.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
            else if (DealerHand <= 21 && PlayerHand > 21)
            {
                Playerchips -= bet;
                bet = 0;
                MessageBox.Show("У вас перебор.");
                Start_Button.Enabled = false;
                button_DOUBLE.Enabled = false;
                button_HIT.Enabled = false;
                button_STAND.Enabled = false;
                button_SPLIT.Enabled = false;
                button5.Enabled = true;

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PlayerHand = 0;
            DealerHand = 0;
            label5.Text = $"You score: {PlayerHand.ToString()}";
            label6.Text = $"Dealer score: {DealerHand.ToString()}";
            label1.Text = $"You balance: {Playerchips.ToString()}";
            bet = 0;
            if (textBox1.TextLength == 0)
                MessageBox.Show("Введите значение");
                bet = Int32.Parse(textBox1.Text);// берет число с текстбоса1 и записывает в bet
            if (bet <= Playerchips && bet > 0)
            {
                Start_Button.Enabled = true;
                button5.Enabled = false;
                label3.Text = $"You bet: {bet}";
            }
            else if (bet > Playerchips)
            {
                MessageBox.Show("У вас нет столько фишек");
            }
            else if (bet <= 0)
            {
                MessageBox.Show("Ты кого наебать пытаешься ?");
            }
        }

        private void button_HIT_Click(object sender, EventArgs e)
        {
            button_DOUBLE.Enabled = false;
            randomNumber = r.Next(1, 52);
            handCardWait = MyExtensions.randNumToCard(randomNumber);
            PlayerHand += handCardWait;
            if (PlayerHand > 21 && handCardWait == 11)
                PlayerHand -= 10;

            label5.Text = $"You score: {PlayerHand.ToString()}";
            if (pictureBox3.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox3);
            else if (pictureBox4.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox4);
            else if (pictureBox5.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox5);
            else if (pictureBox6.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox6);
            else if (pictureBox7.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox7);
            else if (pictureBox8.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox8);
            else if (pictureBox9.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox9);
            else if (pictureBox10.Image == null)
                MyExtensions.Pboxmethod(randomNumber, pictureBox10);

            if (PlayerHand > 21)
            {
                button_HIT.Enabled = false;
                button_STAND.PerformClick();
            }
        }

        private void button_DOUBLE_Click(object sender, EventArgs e)
        {
            button_DOUBLE.Enabled = false;
            button_HIT.Enabled = false;
            if (pictureBox3.Image == null)
            {
                bet = bet * (3/2);
                label3.Text = $"You bet: {bet}";
                randomNumber = r.Next(1, 52);
                handCardWait = MyExtensions.randNumToCard(randomNumber);
                PlayerHand += handCardWait;
                if (PlayerHand > 21 && handCardWait == 11)
                    PlayerHand -= 10;

                label5.Text = $"You score: {PlayerHand.ToString()}";
                if (pictureBox3.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox3);
                else if (pictureBox4.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox4);
                else if (pictureBox5.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox5);
                else if (pictureBox6.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox6);
                else if (pictureBox7.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox7);
                else if (pictureBox8.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox8);
                else if (pictureBox9.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox9);
                else if (pictureBox10.Image == null)
                    MyExtensions.Pboxmethod(randomNumber, pictureBox10);
            }
            button_STAND.PerformClick();
        }
    }
}
