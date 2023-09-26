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
        int x = 1; //variable for detecting if there is still money owed
        int y = 60; // variable for simulating the print
        int z = 1; // variable for detecting if money is tendered
        Random randGen = new Random();

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

                z = 1;
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalCostOutput.Text = "ERROR";
                z = 0;
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
                    x = 1;
                    z = 1;
                }
                else
                {
                    change = change * -1;
                    changeOutput.Text = change.ToString("C");
                    changeLabel.Text = "You still owe";
                    x = 0;
                    z = 1;
                }
            } catch
            {
                changeOutput.Text = "ERROR";
                z = 0;
            }

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            y = 60;
            if (z == 1)
            {
                if (x == 1)
                {
                    //Store Name
                    receiptOutput.Text = "Worlds First Grocery and Brick Store";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n\n Recipet Number {receiptNumber}";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 20);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n\n";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 30);
                    Thread.Sleep(500);
                    Refresh();

                    //List of purchases
                    if (potatoCount > 0)
                    {

                        receiptOutput.Text += $"\n {potatoCount} Potato(es) @ {potatoCost.ToString("C")}";

                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(500);
                        Refresh();
                    }

                    if (tomatoCount > 0)
                    {
                        receiptOutput.Text += $"\n {tomatoCount} Tomato(es) @ {tomatoCost.ToString("C")}";

                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(500);
                        Refresh();
                    }

                    if (brickCount > 0)
                    {
                        receiptOutput.Text += $"\n {brickCount} Brick(s) @ {brickCost.ToString("C")}";

                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                        Thread.Sleep(500);
                        Refresh();
                    }
                    receiptOutput.Text += $"\n";
                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 20);
                    Thread.Sleep(500);
                    Refresh();

                    //Cost
                    receiptOutput.Text += $"\n Subtotal: {subtotal.ToString("C")}";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n Tax: {taxAmount.ToString("C")}";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n Total: {totalCost.ToString("C")}";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 12);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n";

                    //Tendered and change
                    receiptOutput.Text += $"\n Tendered: {tendered.ToString("C")}";


                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n Change due: {change.ToString("C")}";


                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n\n\n";

                    for (int z = 1; z < 4; z++)
                    {
                        receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 15);
                        Thread.Sleep(500);
                        Refresh();
                    }

                    //Final comments
                    receiptOutput.Text += $"\n\n Have a mediocre day!";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 25);
                    Thread.Sleep(500);
                    Refresh();

                    receiptOutput.Text += $"\n\n 308 Negra Arroyo Lane, Albequerque, New Mexico, 87104";

                    receiptOutputCover.Location = new System.Drawing.Point(160, y = y + 45);
                    Thread.Sleep(500);
                    Refresh();
                }

                else if (x == 0)
                {
                    y = 60;
                    receiptOutput.Text = $"\n You still owe me idiot";
                    receiptOutput.Text += $"\n\n Have a mediocre day!";
                    receiptOutput.Text += $"\n\n 308 Negra Arroyo Lane, Albequerque, New Mexico, 87104";
                    receiptOutputCover.Location = new System.Drawing.Point(160, 70);
                    Thread.Sleep(500);
                    Refresh();
                    receiptOutputCover.Location = new System.Drawing.Point(160, 95);
                    Thread.Sleep(500);
                    Refresh();
                    receiptOutputCover.Location = new System.Drawing.Point(160, 135);
                    Thread.Sleep(500);
                    Refresh();
                }
            } else if (z == 0)
            {
                receiptOutput.Text = $"\n Whoops, something went wrong :/";
                receiptOutput.Text += $"\n\n Have a mediocre day!";
                receiptOutput.Text += $"\n\n 308 Negra Arroyo Lane, Albequerque, New Mexico, 87104";
                receiptOutputCover.Location = new System.Drawing.Point(160, 70);
                Thread.Sleep(500);
                Refresh();
                receiptOutputCover.Location = new System.Drawing.Point(160, 95);
                Thread.Sleep(500);
                Refresh();
                receiptOutputCover.Location = new System.Drawing.Point(160, 135);
                Thread.Sleep(500);
                Refresh();
            }
        }

        private void receiptOutputCover_Click(object sender, EventArgs e)
        {

        }
    }
}
