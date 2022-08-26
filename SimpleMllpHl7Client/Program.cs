using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SimpleMllpHl7Client
{
    public class Program
    {
        private static char START_OF_BLOCK = (char)0x0B;
        private static char END_OF_BLOCK = (char)0x1C;
        private static char CARRIAGE_RETURN = (char)13;

        static void Main(string[] args)
        {
            TcpClient ourTcpClient = null;
            NetworkStream networkStream = null;

            var testHl7MessageToTransmit = new StringBuilder();

            //a HL7 test message that is enveloped with MLLP as described in my article
            testHl7MessageToTransmit.Append(START_OF_BLOCK)
                .Append("MSH|^~\\&|DCM4CHEE|DCM4CHEE|DCM4CHEE|DCM4CHEE|20220419183649||ORM^O01^ORM_O01|168715|P|2.5")
                .Append(CARRIAGE_RETURN)
                .Append("PID||1|5614936||Maher^Maher\r\nORC|NW|561|||||^^^20220419183649")
                .Append(CARRIAGE_RETURN)
                .Append("ORC|NW|561|||||^^^20220419183649")
                .Append(CARRIAGE_RETURN)
                .Append("OBR|1|1|2|1^^^1^Sholder|||||||||||||DR_ROOM_7|Dr7|561|561|4936561|||DX||||||||||PERFOMING_TECH|||||||||||")
                .Append(CARRIAGE_RETURN)
                .Append("ZDS|1.2.4.0.13.1.4.2252867.561^DCM4CHEE^StationName")
                .Append(CARRIAGE_RETURN)
                .Append(END_OF_BLOCK)
                .Append(CARRIAGE_RETURN);

            try
            {
                //initiate a TCP client connection to local loopback address at port 1080
                ourTcpClient = new TcpClient();

                ourTcpClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2575));

                Console.WriteLine("Connected to server....");

                //get the IO stream on this connection to write to
                networkStream = ourTcpClient.GetStream();

                //use UTF-8 and either 8-bit encoding due to MLLP-related recommendations
                var byteBuffer = Encoding.UTF8.GetBytes(testHl7MessageToTransmit.ToString());

                //send a message through this connection using the IO stream
                networkStream.Write(byteBuffer, 0, byteBuffer.Length);

                Console.WriteLine("Data was sent data to server successfully....");

                Console.WriteLine("This client is not technically complete as it does not receive MLLP message acknowledgement back....");

                Console.WriteLine("Press any key to exit program...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //display any exceptions that occur to console
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close the IO strem and the TCP connection
                networkStream?.Close();
                networkStream?.Dispose();
                ourTcpClient?.Close();
            }
        }
    }
}
