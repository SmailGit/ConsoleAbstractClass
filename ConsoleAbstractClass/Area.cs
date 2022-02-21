using System;

namespace ConsoleAbstractClass
{
    internal class Area
    {
        private readonly double estimation;

        public double GetEstimation()
        {
            return estimation;
        }

        internal object GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}