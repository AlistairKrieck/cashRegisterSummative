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
            this.label5 = new System.Windows.Forms.Label();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.receiptOutputCover = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
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
            this.brickLabel.Location = new System.Drawing.Point(20, 162);
            this.brickLabel.Name = "brickLabel";
            this.brickLabel.Size = new System.Drawing.Size(47, 16);
            this.brickLabel.TabIndex = 1;
            this.brickLabel.Text = "Bricks:";
            // 
            // tomatoLabel
            // 
            this.tomatoLabel.AutoSize = true;
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
            this.potatoLabel.Location = new System.Drawing.Point(20, 70);
            this.potatoLabel.Name = "potatoLabel";
            this.potatoLabel.Size = new System.Drawing.Size(64, 16);
            this.potatoLabel.TabIndex = 3;
            this.potatoLabel.Text = "Potatoes:";
            // 
            // potatoInput
            // 
            this.potatoInput.Location = new System.Drawing.Point(92, 67);
            this.potatoInput.Name = "potatoInput";
            this.potatoInput.Size = new System.Drawing.Size(100, 22);
            this.potatoInput.TabIndex = 4;
            this.potatoInput.TextChanged += new System.EventHandler(this.potatoInput_TextChanged);
            // 
            // tomatoInput
            // 
            this.tomatoInput.Location = new System.Drawing.Point(92, 112);
            this.tomatoInput.Name = "tomatoInput";
            this.tomatoInput.Size = new System.Drawing.Size(100, 22);
            this.tomatoInput.TabIndex = 5;
            // 
            // brickInput
            // 
            this.brickInput.Location = new System.Drawing.Point(92, 159);
            this.brickInput.Name = "brickInput";
            this.brickInput.Size = new System.Drawing.Size(100, 22);
            this.brickInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(-8, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(26, 228);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(59, 16);
            this.subtotalLabel.TabIndex = 10;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(26, 258);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 16);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(26, 289);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(41, 16);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total:";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Location = new System.Drawing.Point(132, 228);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(15, 16);
            this.subtotalOutput.TabIndex = 13;
            this.subtotalOutput.Text = "X";
            this.subtotalOutput.Click += new System.EventHandler(this.label8_Click);
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Location = new System.Drawing.Point(132, 258);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(15, 16);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.Text = "X";
            this.taxOutput.Click += new System.EventHandler(this.label9_Click);
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.AutoSize = true;
            this.totalCostOutput.Location = new System.Drawing.Point(132, 289);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(15, 16);
            this.totalCostOutput.TabIndex = 11;
            this.totalCostOutput.Text = "X";
            this.totalCostOutput.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(-1, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(601, 52);
            this.label5.TabIndex = 14;
            this.label5.Text = "Grocery and Brick Store";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moneyInput
            // 
            this.moneyInput.Location = new System.Drawing.Point(101, 338);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(100, 22);
            this.moneyInput.TabIndex = 16;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(28, 341);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(67, 16);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(156, 405);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(15, 16);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.Text = "X";
            this.changeOutput.Click += new System.EventHandler(this.label7_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(52, 405);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(83, 16);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change due:";
            this.changeLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.White;
            this.calculateChangeButton.Location = new System.Drawing.Point(41, 366);
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
            this.receiptButton.Location = new System.Drawing.Point(41, 434);
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
            this.receiptOutput.Location = new System.Drawing.Point(231, 46);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(369, 497);
            this.receiptOutput.TabIndex = 21;
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptOutputCover
            // 
            this.receiptOutputCover.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptOutputCover.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.receiptOutputCover.Location = new System.Drawing.Point(231, 46);
            this.receiptOutputCover.Name = "receiptOutputCover";
            this.receiptOutputCover.Size = new System.Drawing.Size(369, 479);
            this.receiptOutputCover.TabIndex = 22;
            this.receiptOutputCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptOutputCover.Click += new System.EventHandler(this.receiptOutputCover_Click);
            // 
            // GroceryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(587, 518);
            this.Controls.Add(this.receiptOutputCover);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.label5);
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
            this.Name = "GroceryStore";
            this.Tag = "";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label receiptOutputCover;
    }
}

