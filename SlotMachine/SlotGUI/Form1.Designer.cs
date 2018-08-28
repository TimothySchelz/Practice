namespace SlotGUI
{
    partial class Form1
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
            this.betButton = new System.Windows.Forms.Button();
            this.rowArrowLeft = new System.Windows.Forms.Label();
            this.rowLabelRight = new System.Windows.Forms.Label();
            this.firstReelMiddleRow = new System.Windows.Forms.Label();
            this.firstReelTopRow = new System.Windows.Forms.Label();
            this.firstReelBottomRow = new System.Windows.Forms.Label();
            this.secondReelTopRow = new System.Windows.Forms.Label();
            this.secondReelMiddleRow = new System.Windows.Forms.Label();
            this.thirdReelTopRow = new System.Windows.Forms.Label();
            this.secondReelBottomRow = new System.Windows.Forms.Label();
            this.thirdReelMiddleRow = new System.Windows.Forms.Label();
            this.thirdReelBottomRow = new System.Windows.Forms.Label();
            this.betAmountLabel = new System.Windows.Forms.Label();
            this.PlayersMoneyLabel = new System.Windows.Forms.Label();
            this.PlayersMoney = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.alertPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(69, 102);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 0;
            this.betButton.Text = "BET!!!";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.doABet);
            // 
            // rowArrowLeft
            // 
            this.rowArrowLeft.AutoSize = true;
            this.rowArrowLeft.Location = new System.Drawing.Point(17, 45);
            this.rowArrowLeft.Name = "rowArrowLeft";
            this.rowArrowLeft.Size = new System.Drawing.Size(25, 13);
            this.rowArrowLeft.TabIndex = 1;
            this.rowArrowLeft.Text = "---->";
            // 
            // rowLabelRight
            // 
            this.rowLabelRight.AutoSize = true;
            this.rowLabelRight.Location = new System.Drawing.Point(173, 46);
            this.rowLabelRight.Name = "rowLabelRight";
            this.rowLabelRight.Size = new System.Drawing.Size(25, 13);
            this.rowLabelRight.TabIndex = 2;
            this.rowLabelRight.Text = "<----";
            // 
            // firstReelMiddleRow
            // 
            this.firstReelMiddleRow.AutoSize = true;
            this.firstReelMiddleRow.Location = new System.Drawing.Point(57, 45);
            this.firstReelMiddleRow.Name = "firstReelMiddleRow";
            this.firstReelMiddleRow.Size = new System.Drawing.Size(13, 13);
            this.firstReelMiddleRow.TabIndex = 3;
            this.firstReelMiddleRow.Text = "1";
            // 
            // firstReelTopRow
            // 
            this.firstReelTopRow.AutoSize = true;
            this.firstReelTopRow.Location = new System.Drawing.Point(57, 21);
            this.firstReelTopRow.Name = "firstReelTopRow";
            this.firstReelTopRow.Size = new System.Drawing.Size(13, 13);
            this.firstReelTopRow.TabIndex = 4;
            this.firstReelTopRow.Text = "1";
            // 
            // firstReelBottomRow
            // 
            this.firstReelBottomRow.AutoSize = true;
            this.firstReelBottomRow.Location = new System.Drawing.Point(57, 70);
            this.firstReelBottomRow.Name = "firstReelBottomRow";
            this.firstReelBottomRow.Size = new System.Drawing.Size(13, 13);
            this.firstReelBottomRow.TabIndex = 5;
            this.firstReelBottomRow.Text = "1";
            // 
            // secondReelTopRow
            // 
            this.secondReelTopRow.AutoSize = true;
            this.secondReelTopRow.Location = new System.Drawing.Point(103, 21);
            this.secondReelTopRow.Name = "secondReelTopRow";
            this.secondReelTopRow.Size = new System.Drawing.Size(13, 13);
            this.secondReelTopRow.TabIndex = 6;
            this.secondReelTopRow.Text = "1";
            // 
            // secondReelMiddleRow
            // 
            this.secondReelMiddleRow.AutoSize = true;
            this.secondReelMiddleRow.Location = new System.Drawing.Point(103, 45);
            this.secondReelMiddleRow.Name = "secondReelMiddleRow";
            this.secondReelMiddleRow.Size = new System.Drawing.Size(13, 13);
            this.secondReelMiddleRow.TabIndex = 7;
            this.secondReelMiddleRow.Text = "1";
            // 
            // thirdReelTopRow
            // 
            this.thirdReelTopRow.AutoSize = true;
            this.thirdReelTopRow.Location = new System.Drawing.Point(143, 21);
            this.thirdReelTopRow.Name = "thirdReelTopRow";
            this.thirdReelTopRow.Size = new System.Drawing.Size(13, 13);
            this.thirdReelTopRow.TabIndex = 8;
            this.thirdReelTopRow.Text = "1";
            // 
            // secondReelBottomRow
            // 
            this.secondReelBottomRow.AutoSize = true;
            this.secondReelBottomRow.Location = new System.Drawing.Point(103, 70);
            this.secondReelBottomRow.Name = "secondReelBottomRow";
            this.secondReelBottomRow.Size = new System.Drawing.Size(13, 13);
            this.secondReelBottomRow.TabIndex = 9;
            this.secondReelBottomRow.Text = "1";
            // 
            // thirdReelMiddleRow
            // 
            this.thirdReelMiddleRow.AutoSize = true;
            this.thirdReelMiddleRow.Location = new System.Drawing.Point(143, 45);
            this.thirdReelMiddleRow.Name = "thirdReelMiddleRow";
            this.thirdReelMiddleRow.Size = new System.Drawing.Size(13, 13);
            this.thirdReelMiddleRow.TabIndex = 10;
            this.thirdReelMiddleRow.Text = "1";
            // 
            // thirdReelBottomRow
            // 
            this.thirdReelBottomRow.AutoSize = true;
            this.thirdReelBottomRow.Location = new System.Drawing.Point(143, 70);
            this.thirdReelBottomRow.Name = "thirdReelBottomRow";
            this.thirdReelBottomRow.Size = new System.Drawing.Size(13, 13);
            this.thirdReelBottomRow.TabIndex = 11;
            this.thirdReelBottomRow.Text = "1";
            // 
            // betAmountLabel
            // 
            this.betAmountLabel.AutoSize = true;
            this.betAmountLabel.Location = new System.Drawing.Point(34, 141);
            this.betAmountLabel.Name = "betAmountLabel";
            this.betAmountLabel.Size = new System.Drawing.Size(105, 13);
            this.betAmountLabel.TabIndex = 12;
            this.betAmountLabel.Text = "Current Bet Amount: ";
            this.betAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayersMoneyLabel
            // 
            this.PlayersMoneyLabel.AutoSize = true;
            this.PlayersMoneyLabel.Location = new System.Drawing.Point(34, 172);
            this.PlayersMoneyLabel.Name = "PlayersMoneyLabel";
            this.PlayersMoneyLabel.Size = new System.Drawing.Size(98, 13);
            this.PlayersMoneyLabel.TabIndex = 13;
            this.PlayersMoneyLabel.Text = "Remaining Credits: ";
            // 
            // PlayersMoney
            // 
            this.PlayersMoney.AutoSize = true;
            this.PlayersMoney.Location = new System.Drawing.Point(145, 172);
            this.PlayersMoney.Name = "PlayersMoney";
            this.PlayersMoney.Size = new System.Drawing.Size(19, 13);
            this.PlayersMoney.TabIndex = 15;
            this.PlayersMoney.Text = "50";
            // 
            // betAmount
            // 
            this.betAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Location = new System.Drawing.Point(145, 141);
            this.betAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.ReadOnly = true;
            this.betAmount.Size = new System.Drawing.Size(53, 20);
            this.betAmount.TabIndex = 16;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.ValueChanged += new System.EventHandler(this.ChangeBet);
            // 
            // alertPanel
            // 
            this.alertPanel.Location = new System.Drawing.Point(13, 195);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(200, 100);
            this.alertPanel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 297);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.PlayersMoney);
            this.Controls.Add(this.PlayersMoneyLabel);
            this.Controls.Add(this.betAmountLabel);
            this.Controls.Add(this.thirdReelBottomRow);
            this.Controls.Add(this.thirdReelMiddleRow);
            this.Controls.Add(this.secondReelBottomRow);
            this.Controls.Add(this.thirdReelTopRow);
            this.Controls.Add(this.secondReelMiddleRow);
            this.Controls.Add(this.secondReelTopRow);
            this.Controls.Add(this.firstReelBottomRow);
            this.Controls.Add(this.firstReelTopRow);
            this.Controls.Add(this.firstReelMiddleRow);
            this.Controls.Add(this.rowLabelRight);
            this.Controls.Add(this.rowArrowLeft);
            this.Controls.Add(this.betButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label rowArrowLeft;
        private System.Windows.Forms.Label rowLabelRight;
        private System.Windows.Forms.Label firstReelMiddleRow;
        private System.Windows.Forms.Label firstReelTopRow;
        private System.Windows.Forms.Label firstReelBottomRow;
        private System.Windows.Forms.Label secondReelTopRow;
        private System.Windows.Forms.Label secondReelMiddleRow;
        private System.Windows.Forms.Label thirdReelTopRow;
        private System.Windows.Forms.Label secondReelBottomRow;
        private System.Windows.Forms.Label thirdReelMiddleRow;
        private System.Windows.Forms.Label thirdReelBottomRow;
        private System.Windows.Forms.Label betAmountLabel;
        private System.Windows.Forms.Label PlayersMoneyLabel;
        private System.Windows.Forms.Label PlayersMoney;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Panel alertPanel;
    }
}

