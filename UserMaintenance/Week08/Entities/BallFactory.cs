using System;
using System.Collections.Generic;
using System.Text;

namespace Week08.Entities
{
    public class BallFactory
    {
        public Ball CreateNew()
        {
            return new Ball();
        }
    }
}
