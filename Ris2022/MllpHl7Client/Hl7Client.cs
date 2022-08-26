using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Ris2022.Data.Models;
namespace Ris2022.MllpHl7Client
{
        public class Hl7Client
        {
            private static char START_OF_BLOCK = (char)0x0B;
            private static char END_OF_BLOCK = (char)0x1C;
            private static char CARRIAGE_RETURN = (char)13;

            public static bool SendHl7Msg(HL7message hL7Message)
            {
                TcpClient ourTcpClient = null!;
                NetworkStream networkStream = null!;

            var testHl7MessageToTransmit = new StringBuilder();

            //a HL7 test message that is enveloped with MLLP as described in my article
            testHl7MessageToTransmit.Append(START_OF_BLOCK)
                .Append("MSH|^~\\&|DCM4CHEE|DCM4CHEE|DCM4CHEE|DCM4CHEE|")
                .Append(hL7Message.startDateTime+"||ORM^O01^ORM_O01|168715|P|2.5")
                    .Append(CARRIAGE_RETURN)
                    .Append("PID||"+hL7Message.patientId+"|"+hL7Message.patientGivenId+"||"+hL7Message.patientFirstName+"^"+hL7Message.patientLastName)
                    .Append(CARRIAGE_RETURN)
                    .Append("ORC|NW|" + hL7Message.commOrderPONum + "|||||^^^"+hL7Message.startDateTime)
            .Append(CARRIAGE_RETURN)
                    .Append("OBR|1|1|2|" + hL7Message.procedureId + "^^^" + hL7Message.procedureId + "^" + hL7Message.procedureName + "|||||||||||||" +hL7Message.aeTitle+"|"+hL7Message.sStationName+"|"+hL7Message.obsOrderPFNum+ "|" + hL7Message.obsOrderPFNum +"|"+hL7Message.accessionNumber+"|||"+hL7Message.modalityName+"||||||||||PERFOMING_TECH|||||||||||")
                    .Append(CARRIAGE_RETURN)
                    .Append("ZDS|"+hL7Message.studyId+"^DCM4CHEE^StationName")
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
                var sendMessageByteBuffer = Encoding.UTF8.GetBytes(testHl7MessageToTransmit.ToString());

                //send a message through this connection using the IO stream
                //networkStream.Write(sendMessageByteBuffer, 0, sendMessageByteBuffer.Length);
                if (networkStream.CanWrite)
                {
                    //send a message through this connection using the IO stream
                    networkStream.Write(sendMessageByteBuffer, 0, sendMessageByteBuffer.Length);

                    //Console.WriteLine("Data was sent data to server successfully....");

                    var receiveMessageByteBuffer = Encoding.UTF8.GetBytes(testHl7MessageToTransmit.ToString());
                    var bytesReceivedFromServer = networkStream.Read(receiveMessageByteBuffer, 0, receiveMessageByteBuffer.Length);
                    return true;
                    // Our server for this example has been designed to echo back the message
                    // keep reading from this stream until the message is echoed back
                    //while (bytesReceivedFromServer > 0)
                    //{
                    //    if (networkStream.CanRead)
                    //    {
                    //        bytesReceivedFromServer = networkStream.Read(receiveMessageByteBuffer, 0, receiveMessageByteBuffer.Length);
                    //        if (bytesReceivedFromServer == 0)
                    //        {
                    //            break;
                    //        }
                    //    }

                    //}
                    //var receivedMessage = Encoding.UTF8.GetString(receiveMessageByteBuffer);

                }
                return false;
            }
            catch (Exception ex)
            {
                //display any exceptions that occur to console
                Console.WriteLine(ex.Message);
                return false;
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
