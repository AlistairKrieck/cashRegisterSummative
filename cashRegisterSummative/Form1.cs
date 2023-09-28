using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace cashRegisterSummative
{
    public partial class GroceryStore : Form
    {

        //Variables
        int potatoCount;
        int tomatoCount;
        int brickCount;

        double potatoCost = 1.35;
        double tomatoCost = 1.5;
        double brickCost = 3;
        double taxRate = 0.13;

        double subtotal;
        double taxAmount;
        double totalCost;

        double change;
        double tendered;

        int receiptNumber;
        bool enoughPaid = true; //variable for detecting if there is still money owed
        int y = 60; // variable for simulating the print
        bool moneyOffered = false; // variable for detecting if money is tendered
        int waitTime = 1000;
        Random randGen = new Random();
        SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.printSound);

        public GroceryStore()
        {
            InitializeComponent();
            receiptNumber = randGen.Next(1, 10000);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void potatoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Declarations
                potatoCount = Convert.ToInt32(potatoInput.Text);
                tomatoCount = Convert.ToInt32(tomatoInput.Text);
                brickCount = Convert.ToInt32(brickInput.Text);

                //Calculations
                double totalPotatoCost = potatoCount * potatoCost;
                double totalTomatoCost = tomatoCount * tomatoCost;
                double totalBrickCost = brickCount * brickCost;
                subtotal = totalPotatoCost + totalTomatoCost + totalBrickCost;
                taxAmount = Math.Round(subtotal * taxRate, 2);
                totalCost = subtotal + taxAmount;

                //Outputs
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = taxAmount.ToString("C");
                totalCostOutput.Text = totalCost.ToString("C");

            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalCostOutput.Text = "ERROR";
                moneyOffered = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Declarations
                tendered = Convert.ToDouble(moneyInput.Text);

                //Calculations
                change = Math.Round(tendered - totalCost, 2);

                //Outputs
                if (change >= 0)
                {
                    changeOutput.Text = change.ToString("C");
                    changeLabel.Text = "Your change is";
                    enoughPaid = true;
                    moneyOffered = true;
                }
                else
                {
                    change = change * -1;
                    changeOutput.Text = change.ToString("C");
                    changeLabel.Text = "You still owe";
                    enoughPaid = false;
                    moneyOffered = true;
                }
            }
            catch
            {
                changeOutput.Text = "ERROR";
                moneyOffered = false;
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            y = 60;

            if (moneyOffered == true)
            {
                if (enoughPaid == true)
                {
                    if (totalCost > 0)
                    {
                        //allows for reset
                        receiptOutputCover.Location = new System.Drawing.Point(160, 35);
                        Refresh();
                        y = 60;

                        //Store Name
                        receiptOutput.Text = "Worlds First Grocery and Brick Store";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n\n        Receipt Number {receiptNumber}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 20);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n\n";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 30);
                        Thread.Sleep(waitTime);
                        Refresh();

                        //List of purchases
                        if (potatoCount > 0)
                        {

                            receiptOutput.Text += $"\n Potato(es)         {potatoCount}         {potatoCost.ToString("C")}";
                            receiptSound.Play();
                            receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                            Thread.Sleep(waitTime);
                            Refresh();
                        }

                        if (tomatoCount > 0)
                        {
                            receiptOutput.Text += $"\n Tomato(es)         {tomatoCount}         {tomatoCost.ToString("C")}";
                            receiptSound.Play();
                            receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                            Thread.Sleep(waitTime);
                            Refresh();
                        }

                        if (brickCount > 0)
                        {
                            receiptOutput.Text += $"\n Brick(s)           {brickCount}         {brickCost.ToString("C")}";
                            receiptSound.Play();
                            receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                            Thread.Sleep(waitTime);
                            Refresh();
                        }
                        receiptOutput.Text += $"\n";
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 20);
                        Thread.Sleep(waitTime);
                        Refresh();

                        //Cost
                        receiptOutput.Text += $"\n Subtotal:                    {subtotal.ToString("C")}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n Tax:                         {taxAmount.ToString("C")}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n Total:                       {totalCost.ToString("C")}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n";

                        //Tendered and change
                        receiptOutput.Text += $"\n Tendered:                    {tendered.ToString("C")}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n Change due:                  {change.ToString("C")}";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n\n\n";

                        for (int x = 1; x < 4; x++)
                        {
                            receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                            receiptSound.Play();
                            Thread.Sleep(waitTime);
                            Refresh();
                        }

                        //Final comments
                        receiptOutput.Text += $"\n\n        Have a mediocre day!";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 25);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n\n       308 Negra Arroyo Lane";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 25);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutput.Text += $"\n\n    Albequerque, New Mexico, 87104";
                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 25);
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptSound.Play();
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 25);
                        Thread.Sleep(waitTime);
                        Refresh();
                    } else if(totalCost == 0)
                    {
                        receiptOutputCover.Location = new System.Drawing.Point(160, 35);
                        Refresh();
                        y = 60;
                        receiptOutput.Text = $"\n Maybe buy something?";
                        receiptOutput.Text += $"\n\n Have a mediocre day!";
                        receiptOutput.Text += $"\n\n       308 Negra Arroyo Lane";
                        receiptOutput.Text += $"\n\n    Albequerque, New Mexico, 87104";


                        receiptOutputCover.Location = new System.Drawing.Point(160, 70);
                        receiptSound.Play();
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutputCover.Location = new System.Drawing.Point(160, 95);
                        receiptSound.Play();
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutputCover.Location = new System.Drawing.Point(160, 135);
                        receiptSound.Play();
                        Thread.Sleep(waitTime);
                        Refresh();

                        receiptOutputCover.Location = new System.Drawing.Point(160, 175);
                        receiptSound.Play();
                        Thread.Sleep(waitTime);
                        Refresh();
                    }
                }

                else if (enoughPaid == false)
                {
                    receiptOutputCover.Location = new System.Drawing.Point(160, 35);
                    Refresh();
                    y = 60;
                    receiptOutput.Text = $"\n You still owe me idiot";
                    receiptOutput.Text += $"\n\n Have a mediocre day!";
                    receiptOutput.Text += $"\n\n       308 Negra Arroyo Lane";
                    receiptOutput.Text += $"\n\n    Albequerque, New Mexico, 87104";


                    receiptOutputCover.Location = new System.Drawing.Point(160, 70);
                    receiptSound.Play();
                    Thread.Sleep(waitTime);
                    Refresh();

                    receiptOutputCover.Location = new System.Drawing.Point(160, 95);
                    receiptSound.Play();
                    Thread.Sleep(waitTime);
                    Refresh();

                    receiptOutputCover.Location = new System.Drawing.Point(160, 135);
                    receiptSound.Play();
                    Thread.Sleep(waitTime);
                    Refresh();

                    receiptOutputCover.Location = new System.Drawing.Point(160, 175);
                    receiptSound.Play();
                    Thread.Sleep(waitTime);
                    Refresh();
                }
            }
            else if (moneyOffered == false)
            {
                receiptOutputCover.Location = new System.Drawing.Point(160, 40);
                receiptOutput.Text = $"\n Whoops, something went wrong :/";
                receiptOutput.Text += $"\n\n       308 Negra Arroyo Lane";
                receiptOutput.Text += $"\n\n    Albequerque, New Mexico, 87104";

                receiptOutputCover.Location = new System.Drawing.Point(160, 70);
                receiptSound.Play();
                Thread.Sleep(waitTime);
                Refresh();

                receiptOutputCover.Location = new System.Drawing.Point(160, 95);
                receiptSound.Play();
                Thread.Sleep(waitTime);
                Refresh();

                receiptOutputCover.Location = new System.Drawing.Point(160, 135);
                receiptSound.Play();
                Thread.Sleep(waitTime);
                Refresh();

                receiptOutputCover.Location = new System.Drawing.Point(160, 175);
                receiptSound.Play();
                Thread.Sleep(waitTime);
                Refresh();

                receiptSound.Play();
            }
        }

        private void receiptOutputCover_Click(object sender, EventArgs e)
        {

        }

        private void brickLabel_Click(object sender, EventArgs e)
        {

        }

        private void potatoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tomatoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void brickInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void taxLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void moneyInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenderedLabel_Click(object sender, EventArgs e)
        {

        }

        private void receiptOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
