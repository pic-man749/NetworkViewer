using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace NetworkViewer {
    internal class UdpController {

        UdpClient udpClient;

        public UdpController() {

        }

        // UDP Send
        public async Task<int> Send(string ipAddr, int port, string payload, bool isHexMode, bool needLn) {
            udpClient = new UdpClient();
            return await Send(ipAddr, port, payload, isHexMode, needLn, udpClient);
        }
        public async Task<int> Send(string ipAddr, int port, string payload, bool isHexMode, bool needLn, UdpClient udpClient) {
            // check ip and port
            IPAddress remoteIp;
            IPEndPoint remoteEp;
            try {
                remoteIp = IPAddress.Parse(ipAddr);
                remoteEp = new IPEndPoint(remoteIp, port);
            } catch {
                General.ShowErrMsgBox("Please input valid ip address and port num.");
                return -1;
            }

            Byte[] sendBytes;
            try {
                sendBytes = General.String2Bytes(payload, isHexMode, needLn);
            } catch {
                General.ShowErrMsgBox("Please input valid hex char(0-f) and enter in 8bit units.");
                return -1;
            }

            try {
                udpClient.Connect(remoteEp);
            } catch {
                General.ShowErrMsgBox("Cannot connect.");
                return -1;
            }

            try {
                return await udpClient.SendAsync(sendBytes, sendBytes.Length);
            } catch {
                General.ShowErrMsgBox("Cannot send UDP packet.");
                return -1;
            }
        }

        // Send and Recv
        public async Task<UdpReceiveResult> SendRecv(string ipAddr, int port, string payload, bool isHexMode, bool needLn) {
            udpClient = new UdpClient();
            int res = await Send(ipAddr, port, payload, isHexMode, needLn, udpClient);


            UdpReceiveResult result;
            try {
                result = await udpClient.ReceiveAsync();
            } catch {
                throw new Exception("aborted");
            }
            
            return result;
        }

        public void Close() {
            udpClient.Close();
        }

        // UDP Recv

    }
}
