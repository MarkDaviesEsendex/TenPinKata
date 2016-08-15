using System.Collections.Generic;
using System.Linq;

namespace TenPin
{
    public class Frame
    {
        private List<int> _PinsKnockedDown;
        private int _SpareBonus;

        public Frame()
        {
            _PinsKnockedDown = new List<int>();
            _SpareBonus = 0;
        }

        public int CurrentBall
        {
            get { return _PinsKnockedDown.Count; }
        }

        public bool IsSpare
        {
            get
            {
                if (Complete())
                {
                    var firstBall = _PinsKnockedDown[0];
                    var secondBall = _PinsKnockedDown[1];
                    return firstBall + secondBall == 10;
                }
                return false;
            }
        }

        public int Score
        {
            get { return _PinsKnockedDown.Sum() + _SpareBonus; }
        }

        public void Roll(int pins)
        {
            _PinsKnockedDown.Add(pins);
        }

        public void SetSpareBonus(int bonus)
        {
            _SpareBonus = bonus;
        }

        public bool Complete()
        {
            return _PinsKnockedDown.Count == 2;
        }
    }
}