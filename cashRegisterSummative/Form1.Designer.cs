namespace cashRegisterSummative
{
    partial class GroceryStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroceryStore));
            this.calculateButton = new System.Windows.Forms.Button();
            this.brickLabel = new System.Windows.Forms.Label();
            this.tomatoLabel = new System.Windows.Forms.Label();
            this.potatoLabel = new System.Windows.Forms.Label();
            this.potatoInput = new System.Windows.Forms.TextBox();
            this.tomatoInput = new System.Windows.Forms.TextBox();
            this.brickInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.receiptOutputCover = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(29, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(151, 29);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // brickLabel
            // 
            this.brickLabel.AutoSize = true;
            this.brickLabel.ForeColor = System.Drawing.Color.White;
            this.brickLabel.Location = new System.Drawing.Point(20, 162);
            this.brickLabel.Name = "brickLabel";
            this.brickLabel.Size = new System.Drawing.Size(47, 16);
            this.brickLabel.TabIndex = 1;
            this.brickLabel.Text = "Bricks:";
            this.brickLabel.Click += new System.EventHandler(this.brickLabel_Click);
            // 
            // tomatoLabel
            // 
            this.tomatoLabel.AutoSize = true;
            this.tomatoLabel.ForeColor = System.Drawing.Color.White;
            this.tomatoLabel.Location = new System.Drawing.Point(20, 118);
            this.tomatoLabel.Name = "tomatoLabel";
            this.tomatoLabel.Size = new System.Drawing.Size(72, 16);
            this.tomatoLabel.TabIndex = 2;
            this.tomatoLabel.Text = "Tomatoes:";
            this.tomatoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // potatoLabel
            // 
            this.potatoLabel.AutoSize = true;
            this.potatoLabel.ForeColor = System.Drawing.Color.White;
            this.potatoLabel.Location = new System.Drawing.Point(20, 70);
            this.potatoLabel.Name = "potatoLabel";
            this.potatoLabel.Size = new System.Drawing.Size(64, 16);
            this.potatoLabel.TabIndex = 3;
            this.potatoLabel.Text = "Potatoes:";
            this.potatoLabel.Click += new System.EventHandler(this.potatoLabel_Click);
            // 
            // potatoInput
            // 
            this.potatoInput.ForeColor = System.Drawing.Color.Black;
            this.potatoInput.Location = new System.Drawing.Point(92, 67);
            this.potatoInput.Name = "potatoInput";
            this.potatoInput.Size = new System.Drawing.Size(100, 22);
            this.potatoInput.TabIndex = 4;
            this.potatoInput.Text = "0";
            this.potatoInput.TextChanged += new System.EventHandler(this.potatoInput_TextChanged);
            // 
            // tomatoInput
            // 
            this.tomatoInput.ForeColor = System.Drawing.Color.Black;
            this.tomatoInput.Location = new System.Drawing.Point(92, 112);
            this.tomatoInput.Name = "tomatoInput";
            this.tomatoInput.Size = new System.Drawing.Size(100, 22);
            this.tomatoInput.TabIndex = 5;
            this.tomatoInput.Text = "0";
            this.tomatoInput.TextChanged += new System.EventHandler(this.tomatoInput_TextChanged);
            // 
            // brickInput
            // 
            this.brickInput.ForeColor = System.Drawing.Color.Black;
            this.brickInput.Location = new System.Drawing.Point(92, 159);
            this.brickInput.Name = "brickInput";
            this.brickInput.Size = new System.Drawing.Size(100, 22);
            this.brickInput.TabIndex = 6;
            this.brickInput.Text = "0";
            this.brickInput.TextChanged += new System.EventHandler(this.brickInput_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-8, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 18);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(38, 227);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(59, 16);
            this.subtotalLabel.TabIndex = 10;
            this.subtotalLabel.Text = "Subtotal:";
            this.subtotalLabel.Click += new System.EventHandler(this.subtotalLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(38, 257);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 16);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.Click += new System.EventHandler(this.taxLabel_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostLabel.Location = new System.Drawing.Point(38, 288);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(41, 16);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total:";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.ForeColor = System.Drawing.Color.White;
            this.subtotalOutput.Location = new System.Drawing.Point(144, 227);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(15, 16);
            this.subtotalOutput.TabIndex = 13;
            this.subtotalOutput.Text = "X";
            this.subtotalOutput.Click += new System.EventHandler(this.label8_Click);
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.ForeColor = System.Drawing.Color.White;
            this.taxOutput.Location = new System.Drawing.Point(144, 257);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(15, 16);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.Text = "X";
            this.taxOutput.Click += new System.EventHandler(this.label9_Click);
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.AutoSize = true;
            this.totalCostOutput.ForeColor = System.Drawing.Color.White;
            this.totalCostOutput.Location = new System.Drawing.Point(144, 288);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(15, 16);
            this.totalCostOutput.TabIndex = 11;
            this.totalCostOutput.Text = "X";
            this.totalCostOutput.Click += new System.EventHandler(this.label10_Click);
            // 
            // moneyInput
            // 
            this.moneyInput.ForeColor = System.Drawing.Color.Black;
            this.moneyInput.Location = new System.Drawing.Point(89, 344);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(100, 22);
            this.moneyInput.TabIndex = 16;
            this.moneyInput.TextChanged += new System.EventHandler(this.moneyInput_TextChanged);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(16, 347);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(67, 16);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.Click += new System.EventHandler(this.tenderedLabel_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.ForeColor = System.Drawing.Color.White;
            this.changeOutput.Location = new System.Drawing.Point(144, 411);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(15, 16);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.Text = "X";
            this.changeOutput.Click += new System.EventHandler(this.label7_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(40, 411);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(83, 16);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change due:";
            this.changeLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.White;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Black;
            this.calculateChangeButton.Location = new System.Drawing.Point(29, 372);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(151, 29);
            this.calculateChangeButton.TabIndex = 19;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.White;
            this.receiptButton.ForeColor = System.Drawing.Color.Black;
            this.receiptButton.Location = new System.Drawing.Point(29, 440);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(151, 29);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.receiptOutput.Location = new System.Drawing.Point(231, 46);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(369, 479);
            this.receiptOutput.TabIndex = 21;
            this.receiptOutput.Click += new System.EventHandler(this.receiptOutput_Click);
            // 
            // receiptOutputCover
            // 
            this.receiptOutputCover.BackColor = System.Drawing.Color.Black;
            this.receiptOutputCover.ForeColor = System.Drawing.SystemColors.Control;
            this.receiptOutputCover.Location = new System.Drawing.Point(231, 47);
            this.receiptOutputCover.Name = "receiptOutputCover";
            this.receiptOutputCover.Size = new System.Drawing.Size(377, 479);
            this.receiptOutputCover.TabIndex = 22;
            this.receiptOutputCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptOutputCover.Click += new System.EventHandler(this.receiptOutputCover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::cashRegisterSummative.Properties.Resources.icon_2_;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // GroceryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(587, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.receiptOutputCover);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brickInput);
            this.Controls.Add(this.tomatoInput);
            this.Controls.Add(this.potatoInput);
            this.Controls.Add(this.potatoLabel);
            this.Controls.Add(this.tomatoLabel);
            this.Controls.Add(this.brickLabel);
            this.Controls.Add(this.calculateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroceryStore";
            this.Tag = "";
            this.Text = "Grocery and Brick Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label brickLabel;
        private System.Windows.Forms.Label tomatoLabel;
        private System.Windows.Forms.Label potatoLabel;
        private System.Windows.Forms.TextBox potatoInput;
        private System.Windows.Forms.TextBox tomatoInput;
        private System.Windows.Forms.TextBox brickInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label receiptOutputCover;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

