using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkViewer {
    public partial class Form1 {
        Socket tcpConClientSocket = null;
        Socket tcpConServerSocket = null;
        CancellationTokenSource cts4TcpConServer = new CancellationTokenSource();

        private void btnTcpConConnect_Click(object sender, EventArgs e) {
            // open
            if(btnTcpConConnect.Text == "connect") {
                IPAddress ipAddr;
                int portNum;
                try {
                    ipAddr = IPAddress.Parse(tbTcpConIp.Text);
                    portNum = int.Parse(tbTcpConPort.Text);
                    if(!(0 <= portNum && portNum <= 65534)) {
                        throw new Exception("invalid port num.");
                    }
                } catch {
                    General.ShowErrMsgBox("invalid ip address or port num");
                    return;
                }

                IPEndPoint ipep = new IPEndPoint(ipAddr, portNum);
                try {
                    tcpConClientSocket = new Socket(ipep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    tcpConClientSocket.Connect(ipep);
                } catch(Exception ex) {
                    writeTcpConClientTb("Exception : " + ex.Message);
                    return;
                }
                writeTcpConClientTb("Connection established @" + ipAddr.ToString() + ":" + portNum.ToString());
                btnTcpConConnect.Text = "close";
            }
            // close
            else {
                if(tcpConClientSocket != null) {
                    tcpConClientSocket.Close();
                    tcpConClientSocket.Dispose();
                    tcpConClientSocket = null;
                    writeTcpConClientTb("Connection closed.");
                }
                btnTcpConConnect.Text = "connect";
            }
        }

        private void btnTcpConClientSend_Click(object sender, EventArgs e) {
            if(tcpConClientSocket == null) {
                General.ShowErrMsgBox("Connection does not established.");
                return;
            }

            var data = General.String2Bytes(tbTcpConClientReq.Text, cbTcpConClientHexMode.Checked, cbTcpConClientAddLf.Checked);
            tcpConClientSocket.Send(data);
        }

        private void btnTcpConClientClear_Click(object sender, EventArgs e) {
            tbTcpConClientLog.Clear();
            tbTcpConClientBin.Clear();
        }

        private void btnTcpConListen_Click(object sender, EventArgs e) {
            // listen start
            if(btnTcpConListen.Text == "listen") {
                int portNum;
                try {
                    portNum = int.Parse(tbTcpConServerPort.Text);
                    if(!(0 <= portNum && portNum <= 65534)) {
                        throw new Exception("invalid port num.");
                    }
                } catch {
                    General.ShowErrMsgBox("invalid port num");
                    return;
                }

                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, portNum);
                if(tcpConServerSocket != null) {
                    tcpConServerSocket.Close();
                }
                tcpConServerSocket = new Socket(ipep.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                tcpConServerSocket.Bind(ipep);
                tcpConServerSocket.Listen(100);

                writeTcpConServerTb("Listen start @" + ipep.AddressFamily.ToString() + ":" + portNum.ToString());

                btnTcpConListen.Text = "stop";

                Thread t = new Thread(new ParameterizedThreadStart(ThreadTcpConServerRecv));
                cts4TcpConServer = new CancellationTokenSource();
                t.Start(cts4TcpConServer.Token);

            } 
            // stop
            else {
                if(tcpConServerSocket != null) {
                    tcpConServerSocket.Close();
                    tcpConServerSocket.Dispose();
                    tcpConServerSocket = null;
                    cts4TcpConServer.Cancel();
                }
                writeTcpConServerTb("Stop Listening port");
                btnTcpConListen.Text = "listen";
            }

        }

        private void ThreadTcpConServerRecv(object ct) {
            Socket handler;

            try {
                handler = tcpConServerSocket.Accept();
                // handler.ReceiveTimeout = 100;
            } catch {
                writeTcpConServerTb("Canceled waiting accept");
                return;
            }

            writeTcpConServerTb("Request accepted.");
            while(true) {
                if(((CancellationToken)ct).IsCancellationRequested) {
                    writeTcpConServerTb("Thread exit.");
                    return;
                }
                var buffer = new byte[1600];
                int received;
                try {
                    received = handler.Receive(buffer, SocketFlags.None);
                } catch (TimeoutException ex) {
                    continue;
                } catch {
                    return;
                }
                byte[] tmp = new byte[received];
                Array.Copy(buffer, 0, tmp, 0, received);
                string data = System.Text.Encoding.UTF8.GetString(tmp);
                writeTcpConServerTb("Recved Data " + received.ToString() + "[byte] : " + data);
                writeTcpConServerBinTb(tmp);
            }
        }

        private void btnTcpConServerSend_Click(object sender, EventArgs e) {

        }

        private void btnTcpConServerClear_Click(object sender, EventArgs e) {
            tbTcpConServerLog.Clear();
            tbTcpConServerBin.Clear();
        }

        private void writeTcpConClientTb(string str) {
            if(this.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpConClientTb(str); });
            } else {
                tbTcpConClientLog.AppendText(General.GetLogTime() + str + Environment.NewLine);
            }
        }

        private void writeTcpConClientBinTb(byte[] data) {
            if(this.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpConClientBinTb(data); });
            } else {
                tbTcpConClientBin.AppendText(General.GetLogTime() + Environment.NewLine + General.GetHexDataString(data) + Environment.NewLine);
            }
        }

        private void writeTcpConServerTb(string str) {
            if(this.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpConServerTb(str); });
            } else {
                tbTcpConServerLog.AppendText(General.GetLogTime() + str + Environment.NewLine);
            }
        }

        private void writeTcpConServerBinTb(byte[] data) {
            if(this.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpConServerBinTb(data); });
            } else {
                tbTcpConServerBin.AppendText(General.GetLogTime() + Environment.NewLine + General.GetHexDataString(data) + Environment.NewLine);
            }
        }
    }
}
