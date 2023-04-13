using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Papalagi_Ground_Station.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papalagi_Ground_Station.data
{
    public class FirebaseBase
    {
      public  IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "idZMyIfi8eXUlMmDq73ntt60sK4kA8tXFCBzHtMY",
            BasePath = "https://emergency-call-7884a-default-rtdb.firebaseio.com/"
        };

       public IFirebaseClient client;

        public FirebaseBase()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
               // MessageBox.Show("Connection Established");
            }
            else
            {
                MessageBox.Show("Connection error");

            }
        }

      

    }
}
