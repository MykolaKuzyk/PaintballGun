using System;
using System.Collections.Generic;
using System.Text;

namespace PaintballGun
{
    class PGun
    {

        private int balls = 0;
        public int Magazine_Size { get; private set; } = 16;
        public int BallsLoaded { get; private set; }
        public int Balls
        {
            get { return balls; }
            set { if (value > 0) balls = value; Reload(); }
        }
        public PGun( int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            Magazine_Size = magazineSize;
            if (!loaded) Reload();

        }
        public bool IsEmpty()  { return BallsLoaded == 0; }
        public int GetBalls() { return balls; }

        public void SetBalls (int numberOfBalls)
        {
            if (numberOfBalls > 0)
                balls = numberOfBalls;
            Reload();
        }
        public void Reload()
        {
            if (balls > Magazine_Size)
                BallsLoaded = Magazine_Size;
            else
                BallsLoaded = balls;
        }
        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
    }
}
