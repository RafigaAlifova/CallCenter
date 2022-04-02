using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Extension
{
     public static class ObjectExtensions
    {
        public static int ToInt( this object value)
        {
            var availability =
                int.TryParse(value?.ToString(), out int result);

            if (!availability)
            {
                BigInteger.TryParse
                    (value.ToString(), out BigInteger temp);
                if (temp < int.MinValue)
                {
                    result = int.MinValue;
                }
                else if (temp < int.MaxValue)
                {
                    result = int.MaxValue;
                }
                else
                    result= 0;
            }

            return result;


        }
        
    }
}
