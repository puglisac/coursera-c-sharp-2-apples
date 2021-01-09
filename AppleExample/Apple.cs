using System;
namespace AppleExample
{
    public class Apple
    {
        #region fields
        float amountLeft;
        bool organic;
        #endregion

        #region properties
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }
        #endregion

        public void TakeBite(float size)
        {
            amountLeft -= size;
        }

        public Apple()
        {
        }
    }
}
