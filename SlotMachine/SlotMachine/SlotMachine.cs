using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachineModel
{
    public class SlotMachine
    {
        private int playerCredit;
        private int betAmount;
        private Reel firstReel;
        private Reel secondReel;
        private Reel thirdReel;

        public SlotMachine(int startingCredit)
        {
            playerCredit = startingCredit;
            BetAmount = 5;
            firstReel = new Reel();
            secondReel = new Reel();
            thirdReel = new Reel();
        }

        public int BetAmount { get => betAmount; set => betAmount = value; }

        /*
         * Spins the reels and returns how much is won.
         */
        public int Spin()
        {
            playerCredit -= betAmount;
            firstReel.spin();
            secondReel.spin();
            thirdReel.spin();

            if(firstReel.getCurrentSymbol() == secondReel.getCurrentSymbol() && secondReel.getCurrentSymbol() == thirdReel.getCurrentSymbol())
            {
                playerCredit += betAmount * firstReel.getCurrentSymbol();
            }

            return betAmount * firstReel.getCurrentSymbol();
        }

        public List<int> GetTopRow()
        {
            List<int> topRow = new List<int>();

            topRow.Add(firstReel.getAboveSymbol());
            topRow.Add(secondReel.getAboveSymbol());
            topRow.Add(thirdReel.getAboveSymbol());

            return topRow;
        }

        public List<int> GetBottomRow()
        {
            List<int> bottomRow = new List<int>();

            bottomRow.Add(firstReel.getBelowSymbol());
            bottomRow.Add(secondReel.getBelowSymbol());
            bottomRow.Add(thirdReel.getBelowSymbol());
            return bottomRow;
        }

        public List<int> getMiddleRow()
        {
            List<int> middleRow = new List<int>();

            middleRow.Add(firstReel.getBelowSymbol());
            middleRow.Add(secondReel.getBelowSymbol());
            middleRow.Add(thirdReel.getBelowSymbol());

            return middleRow;
        }
    }
}
