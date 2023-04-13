using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace Papalagi_Ground_Station.data.server
{
   public class LocalServerHandler
    {
        private Socket httpServer;
        private int serverPort = 8080;
        private Thread thread;

        public void startServer()
        {
            httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

            thread = new Thread(new ThreadStart(this.connectionThreatMethod));
            thread.Start();


        }


        public void stopServer()
        {
            httpServer.Close();

            thread.Abort();
        }



        private void connectionThreatMethod()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endPoint);
                httpServer.Listen(1);
                startListeningForConnection();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void startListeningForConnection()
        {
            while (true)
            {
                DateTime time = DateTime.Now;
                String data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept();


                while (true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                    {
                        break;
                    }
                }

                //read data

                //data?



                //send back the response
                String resHeader = "HTTP/1.1 200 MyTitle \nServer: my_csharp_server\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = "<!DOCTYE html> " +
                    "<html>" +
                    "<head><title>My Server</title></head>" +
                    "<body>" +
                    "<h4>Server Time is: " + time.ToString() + "</h4>" +
                    "</body></html>";

                String resStr = resBody + resHeader;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);
                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();



            }
        }
    }
}
