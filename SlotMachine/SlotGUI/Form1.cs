using SlotMachineModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotGUI
{
    public partial class Form1 : Form
    {
        SlotMachine guts;

        public Form1()
        {
            InitializeComponent();

            guts = new SlotMachine(50);
        }

        private void doABet(object sender, EventArgs e)
        {
            alertPanel.BackColor = SystemColors.Control;

            if (guts.PlayerCredit < guts.BetAmount)
            {
                alertPanel.BackColor = Color.Red;
                UpdateDisplays();
                return;
            }

            int winnings = guts.Spin();

            if (winnings > 0)
            {
                alertPanel.BackColor = Color.Green;
            }

            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            List<int> topRow = guts.GetTopRow();
            List<int> middleRow = guts.GetMiddleRow();
            List<int> bottomRow = guts.GetBottomRow();

            // Update the reels
            firstReelTopRow.Text = topRow[0].ToString();
            secondReelTopRow.Text = topRow[1].ToString();
            thirdReelTopRow.Text = topRow[2].ToString();

            firstReelMiddleRow.Text = middleRow[0].ToString();
            secondReelMiddleRow.Text = middleRow[1].ToString();
            thirdReelMiddleRow.Text = middleRow[2].ToString();

            firstReelBottomRow.Text = bottomRow[0].ToString();
            secondReelBottomRow.Text = bottomRow[1].ToString();
            thirdReelBottomRow.Text = bottomRow[2].ToString();

            //update the money bits
            PlayersMoney.Text = guts.PlayerCredit.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBet(object sender, EventArgs e)
        {
            guts.BetAmount = (int)betAmount.Value;
        }
    }
}
