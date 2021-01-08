//This class uses a tuple to represent both the real and imaginary parts of a complex number.
// a + bi ==> (a,b)

using System;

namespace Mandelbrot_Pic_Generator_v1._2
{
    class MyComNum
    {
        //Data
        private (double, double) comTuple;

        //Default constructor
        public MyComNum()
        {
            comTuple.Item1 = 0.0;
            comTuple.Item2 = 0.0;
        }
        //Constructor with tuple arg
        public MyComNum((double, double) argNumTuple)
        {
            comTuple.Item1 = argNumTuple.Item1;
            comTuple.Item2 = argNumTuple.Item2;
        }
        //Constructor with two doubles as arguments
        public MyComNum(double argRealNum, double argImNum)
        {
            comTuple.Item1 = argRealNum;
            comTuple.Item2 = argImNum;
        }
        //Copy constructor
        public MyComNum(MyComNum argMyComNum)
        {
            comTuple.Item1 = argMyComNum.getTup.Item1;
            comTuple.Item2 = argMyComNum.getTup.Item2;
        }

        public double realNum() => comTuple.Item1;
        public double imNum() => comTuple.Item2;
        //Operator overloads:
        public static MyComNum operator +(MyComNum LHS, MyComNum RHS) => new MyComNum((LHS.realNum() + RHS.realNum(), LHS.imNum() + RHS.imNum()));
        public static MyComNum operator -(MyComNum LHS, MyComNum RHS) => new MyComNum((LHS.realNum() - RHS.realNum(), LHS.imNum() - RHS.imNum()));
        public static MyComNum operator /(MyComNum comNum, double dem) => new MyComNum((comNum.realNum() / dem, comNum.imNum() / dem));
        public static MyComNum operator *(MyComNum LHS, MyComNum RHS)
        {
            double newRealNum = ((LHS.realNum() * RHS.realNum()) - (LHS.imNum() * LHS.imNum()));
            double newImNum = ((LHS.realNum() * RHS.imNum()) + (LHS.imNum() * RHS.realNum()));
            return new MyComNum(newRealNum, newImNum);
        }
        public double mod()
        {
            double val = (comTuple.Item1 * comTuple.Item1) + (comTuple.Item2 * comTuple.Item2);
            if (val < 0)
            {
                val = 0 - val;
            }
            val = Math.Sqrt(val);
            return val;
        }


        //Properties
        public (double, double) getTup => comTuple;
        public void set((double, double) argTuple)
        {
            comTuple.Item1 = argTuple.Item1;
            comTuple.Item2 = argTuple.Item2;
        }

    }
}
