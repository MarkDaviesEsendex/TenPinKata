using System.Collections.Generic;
using System.Linq;

namespace TenPin
{
    public class Game
    {
        private List<Frame> _frame;
        private int _rollsPerFrame;
        private int _CurrentFrame { get; set; }

        public Game()
        {
            _frame = new List<Frame>();
            _CurrentFrame = 0;
            _rollsPerFrame = 2;
        }

        public void Roll(int pins)
        {
            if (_frame.Count < (_CurrentFrame + 1))
            {
                _frame.Add(new Frame());
            }

            _frame[_CurrentFrame].Roll(pins);

            if (_CurrentFrame != 0)
            {
                var lastFrame = _CurrentFrame - 1;
                if (_frame[lastFrame].IsSpare && _frame[_CurrentFrame].CurrentBall == 1)
                {
                    _frame[lastFrame].SetSpareBonus(pins);
                }
            }


            if (_frame[_CurrentFrame].Complete())
            {
                _CurrentFrame++;
            }
        }

        public int Score()
        {
            return this._frame.Sum(frame => frame.Score);
        }
    }
}