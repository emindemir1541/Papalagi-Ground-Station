using Papalagi_Ground_Station.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papalagi_Ground_Station.helper
{
   public static class Helper
    {
      /*  public static List<T> responseToList<T>(String body)
        {
            body.Split()
            return 
        }*/

        public static string arrayToString(String[] array)
        {
            string data = "";
            foreach (var item in array)
            {
                data+= item;
            }
            return data;
        }

    

    }
}
