using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTestRevision
{
    class StandardDelivery
    { 
        public int Distance { get; set; }

        public StandardDelivery() { }
        public StandardDelivery(string n, string a, int d)
        {
            // code omitted to save time
            Distance = d;
        }

        public virtual double CalculateCost()
        {
            return 0.0; // code omitted to save time
        }
    }

    /*
    (a)	List ONE method that is overloaded in Figure 2. Give your reason.
    The constructors of either StandardDelivery or InstantDelivery are overloaded. There are 2
    constructors (with the same name) but different parameters.
    (b) 	List ONE method that is overridden in Figure 2. Give your reason.
    ToString() in StandardDelivery is overridden in InstantDelivery. The methods have the 
    same method signatures but are in 2 different classes.

    +InstantDelivery()
    +InstantDelivery(string,string,int,double)
    +CalculateCost():double
    +ToString():string

    */
    class InstantDelivery : StandardDelivery
    {
        // -baseFee:double
        public double BaseFee { get; set; }

        public InstantDelivery() : base()
        {
        }
        public InstantDelivery(string n, string a, int d, double b) : base(n, a, d)
        {
            BaseFee = b;
        }

        public override double CalculateCost()
        {
            double cost;
            if (Distance <= 5)
            {
                cost = BaseFee + Distance * 1;
            }
            else
            {
                cost = BaseFee + 5 * 1 + (Distance - 5) * 0.7;
            }
            return cost;
        }

        public override string ToString()
        {
            return base.ToString() + "\tBaseFee:" + BaseFee;
        }
    }
}
