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
            Random randPaul = new Random();

            PlayerCredit = startingCredit;
            BetAmount = 5;
            firstReel = new Reel(randPaul);
            secondReel = new Reel(randPaul);
            thirdReel = new Reel(randPaul);
        }

        public int BetAmount { get => betAmount; set => betAmount = value; }
        public int PlayerCredit { get => playerCredit; private set => playerCredit = value; }

        /*
         * Spins the reels and returns how much is won.
         */
        public int Spin()
        {
            PlayerCredit -= betAmount;
            firstReel.spin();
            secondReel.spin();
            thirdReel.spin();

            if(firstReel.getCurrentSymbol() == secondReel.getCurrentSymbol() && secondReel.getCurrentSymbol() == thirdReel.getCurrentSymbol())
            {
                PlayerCredit += betAmount * firstReel.getCurrentSymbol();

                return betAmount * firstReel.getCurrentSymbol();
            }

            return -betAmount;
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

        public List<int> GetMiddleRow()
        {
            List<int> middleRow = new List<int>();

            middleRow.Add(firstReel.getCurrentSymbol());
            middleRow.Add(secondReel.getCurrentSymbol());
            middleRow.Add(thirdReel.getCurrentSymbol());

            return middleRow;
        }
    }
}
