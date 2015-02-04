using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{

    internal class PointCS5
    {
        private readonly int x;
        private readonly int y;

        internal PointCS5(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }
    }

    #region CS6
    internal class PointCS6
    {
        internal PointCS6(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; }
        public int Y { get; }
    }
    #endregion

    #region CS7
    //internal class PointCS7(int x, int y) 
    //{
    //    public int X { get; } = x;
    //    public int Y { get; } = y;
    //}
    #endregion
}