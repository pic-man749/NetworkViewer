using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkViewer {
    internal class TcpController {

        private TcpClient _tcpClient;
        private String payload;

        public TcpController(string ip, int port, string payload) {
            IPAddress remoteIpAddr = IPAddress.Parse(ip);
            IPEndPoint remoteEp = new IPEndPoint(remoteIpAddr, port);
            this.payload = payload;

            _tcpClient = new TcpClient(remoteEp);
        }




    }
}
