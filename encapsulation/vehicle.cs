using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class vehicle
    {
        private string _regno;
        int _wheels;
        int _litre;






        public int Wheels
        {
            get { return _wheels; }
            set
            {
                if (value >= 2 && value <= 20)
                {
                    _wheels = value;
                }
            }
        }

        


public int Litre
{
  get { return _litre; }

  set {
      
         if (value>=1&&value<100)
         {
      
      _litre = value;
  }
  }
}

        private string regno



public string Regno
{
  get { return regno; }
  set { regno = value; }
}}}

