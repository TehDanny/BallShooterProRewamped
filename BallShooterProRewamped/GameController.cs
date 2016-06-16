using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallShooterProRewamped
{
    class GameController
    {
        Game game = new Game();

        public void Setup()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Concede()
        {
            throw new NotImplementedException();
        }

        public void EndGame()
        {
            game.RemoveBalls();
            game.RemoveBullets();
            game.PrintWinningStatus();
        }
    }
}
