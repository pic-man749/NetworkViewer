using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkViewer {
    public partial class Form1 : Form {
        private UdpClient udpClientRecv;
        private UdpClient udpAsClient;
        UdpController udpController4Client;
        private TcpListener tcpListener;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // nothing to do
        }
 
        // ------------------------------------------------------------
        //  UDP send
        // ------------------------------------------------------------
        private async void btnUdpSend_Click(object sender, EventArgs e) {
            string ipAddr = tbUdpSendIp.Text;
            int port;
            try {
                port = int.Parse(tbUdpSendPort.Text);
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                return;
            }
            string payload = tbUdpSendPayload.Text;

            UdpController uc = new UdpController();

            var amount = await uc.Send(ipAddr, port, payload, cbUdpSendHexMode.Checked, cbUdpSendAddLn.Checked);
            if(0 <= amount) {
                writeUdpSendTb("Send UDP packet " + amount + "[byte] to " + ipAddr + ":" + port.ToString());
            } else {
                General.ShowErrMsgBox("Cannot send UDP packet.");
            }
            uc.Close();
        }

        // update UDP send TextBox
        private void writeUdpSendTb(string str) {
            if(this.tbUdpSend.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeUdpSendTb(str); });
            } else {
                tbUdpSend.AppendText(General.GetLogTime() + " " + str + Environment.NewLine);
            }
        }

        private void btnUdpSendClear_Click(object sender, EventArgs e) {
            this.tbUdpSend.Text = string.Empty;
        }

        // ------------------------------------------------------------
        //  UDP recv
        // ------------------------------------------------------------
        private void btnUdpListen_Click(object sender, EventArgs e) {
            if(this.btnUdpRecvListen.Text == "listen") {
                this.btnUdpRecvListen.Text = "stop";
                UdpRecv();
            } else {
                this.udpClientRecv.Close();
                this.btnUdpRecvListen.Text = "listen";
            }
        }

        // recv UDP loop
        private async void UdpRecv() {
            IPEndPoint clientEp;
            try {
                clientEp = new IPEndPoint(IPAddress.Any, int.Parse(tbUdpRecvPort.Text));
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                this.btnUdpRecvListen.Text = "listen";
                return;
            }
            writeUdpRecvTb("start listen @localhost:" + tbUdpRecvPort.Text);
            using(udpClientRecv = new UdpClient(clientEp)) {
                while(true) {
                    UdpReceiveResult res;
                    try {
                        res = await udpClientRecv.ReceiveAsync();
                    } catch(ObjectDisposedException err) {
                        writeUdpRecvTb("closed.");
                        return;
                    }
                    var requestBytes = res.Buffer;
                    var req = Encoding.UTF8.GetString(requestBytes);

                    string senderAddr = res.RemoteEndPoint.Address.ToString() + ":" + res.RemoteEndPoint.Port.ToString();
                    writeUdpRecvTb("request from " + senderAddr + ", data : " + req);
                    if(cbUdpRecvShowHexData.Checked) {
                        writeUdpRecvTb("hex data:" + Environment.NewLine + General.GetHexDataString(requestBytes));
                    }
                }
            }
        }

        private void btnUdpRecvClear_Click(object sender, EventArgs e) {
            this.tbUdpRecv.Text = string.Empty;
        }

        // update UDP send TextBox
        private void writeUdpRecvTb(string str) {
            if(this.tbUdpRecv.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeUdpRecvTb(str); });
            } else {
                tbUdpRecv.AppendText(General.GetLogTime() + " " + str + Environment.NewLine);
            }
        }

        // ------------------------------------------------------------
        //  UDP client
        // ------------------------------------------------------------
        private async void btnUdpClientSend_Click(object sender, EventArgs e) {
            if(btnUdpClientSend.Text == "send") {
                btnUdpClientSend.Text = "abort";
                var task = RequestUdpAsync();
                await task;
            } else if(btnUdpClientSend.Text == "abort") {
                udpController4Client.Close();
                btnUdpClientSend.Text = "send";
            }
        }

        private async Task RequestUdpAsync() {
            string ip = tbUdpClientIp.Text;
            int port;
            try {
                port = int.Parse(tbUdpClientPort.Text);
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                btnUdpClientSend.Text = "send";
                return;
            }
            writeUdpClientTb("send request to " + ip + ":" + port);
            // send request
            string payload = tbUdpClientRequest.Text;
            udpController4Client = new UdpController();
            UdpReceiveResult result;
            try {
                // send request and get response
                result = await udpController4Client.SendRecv(ip, port, payload, cbUdpClientHexMode.Checked, cbUdpClientAddTailLn.Checked);
            } catch(SocketException err) {
                writeUdpClientTb("err : " + err.Message);
                btnUdpClientSend.Text = "send";
                return;
            } catch(Exception err) {
                writeUdpClientTb(err.Message);
                btnUdpClientSend.Text = "send";
                return;
            }

            var responseBytes = result.Buffer;
            var res = Encoding.UTF8.GetString(responseBytes);
            string serverAddr = result.RemoteEndPoint.Address.ToString() + ":" + result.RemoteEndPoint.Port.ToString();
            writeUdpClientTb("response from " + serverAddr + ", data : " + res);
            if(cbUdpClientShowHexData.Checked) {
                writeUdpClientTb("hex data:" + Environment.NewLine + General.GetHexDataString(responseBytes));
            }
            btnUdpClientSend.Text = "send";

        }
        // update UDP client TextBox
        private void writeUdpClientTb(string str) {
            if(tbUdpClientResponse.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeUdpClientTb(str); });
            } else {
                tbUdpClientResponse.AppendText(General.GetLogTime() + " " + str + Environment.NewLine);
            }
        }

        private void btnUdpClientClear_Click(object sender, EventArgs e) {
            tbUdpClientResponse.Text = String.Empty;
        }

        // ------------------------------------------------------------
        //  UDP server
        // ------------------------------------------------------------
        private void btnUdpServerListen_Click(object sender, EventArgs e) {
            if(btnUdpServerListen.Text == "listen") {
                btnUdpServerListen.Text = "stop";
                UdpServer();
            } else if(btnUdpServerListen.Text == "stop") {
                btnUdpServerListen.Text = "listen";
                udpAsClient.Close();
            }
        }
        private async void UdpServer() {
            IPEndPoint clientEp;
            try {
                clientEp = new IPEndPoint(IPAddress.Any, int.Parse(tbUdpServerPort.Text));
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                return;
            }
            writeUdpServerLogTb("start listen @localhost:" + tbUdpServerPort.Text);
            using(udpAsClient = new UdpClient(clientEp)) {
                while(true) {
                    UdpReceiveResult res;
                    try {
                        res = await udpAsClient.ReceiveAsync();
                    } catch(ObjectDisposedException err) {
                        writeUdpServerLogTb("closed.");
                        return;
                    }
                    var requestBytes = res.Buffer;
                    var req = Encoding.UTF8.GetString(requestBytes);

                    string senderAddr = res.RemoteEndPoint.Address.ToString() + ":" + res.RemoteEndPoint.Port.ToString();
                    writeUdpServerLogTb("request from " + senderAddr + ", data : " + req);
                    if(cbUdpServerShowHexData.Checked) {
                        writeUdpServerLogTb("hex data:" + Environment.NewLine + General.GetHexDataString(requestBytes));
                    }

                    var sender = Task.Run(async () => {

                        Byte[] responseBytes;
                        if(cbUdpServerEchoMode.Checked) {
                            responseBytes = requestBytes;
                        } else {
                            responseBytes = Encoding.UTF8.GetBytes(tbUdpServerResponse.Text + (cbUdpServerAddTailLn.Checked ? "\n" : ""));
                        }
                        await udpAsClient.SendAsync(responseBytes, responseBytes.Length, res.RemoteEndPoint);

                        writeUdpServerLogTb("send response.");

                    });
                }
            }
        }
        // update UDP server TextBox
        private void writeUdpServerLogTb(string str) {
            if(tbUdpServerLog.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeUdpServerLogTb(str); });
            } else {
                tbUdpServerLog.AppendText(General.GetLogTime() + str + Environment.NewLine);
            }
        }

        // ------------------------------------------------------------
        //  TCP Client
        // ------------------------------------------------------------
        private async void btnTcpClientSend_Click(object sender, EventArgs e) {
            btnTcpClientSend.Enabled = false;
            var task = tcpAsClient();
            await task;
        }
        private async Task tcpAsClient() { 
            string ipAddr = tbTcpClientIp.Text;

            int port;
            try {
                port = int.Parse(tbTcpClientPort.Text);
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                btnTcpClientSend.Enabled = true;
                return;
            }
            string payload = tbTcpClientRequest.Text;

            byte[] sendBytes = General.String2Bytes(payload, cbTcpClientHexMode.Checked, cbTcpClientAddTailLn.Checked);

            writeTcpClientTb("send request to " + ipAddr + ":" + port);

            TcpClient client = new TcpClient();
            // timeout setting
            client.SendTimeout = 5000;
            client.ReceiveTimeout = 5000;
            try {
                var task = client.ConnectAsync(ipAddr, port);
                await task;
            } catch {
                writeTcpClientTb("err : connection rejected.");
                btnTcpClientSend.Enabled = true;
                return;
            }

            var stream = client.GetStream();
            // timeout setting
            stream.ReadTimeout = 5000;
            stream.WriteTimeout = 5000;
            // rend request
            writeTcpClientTb("Connected.");
            await stream.WriteAsync(sendBytes, 0, sendBytes.Length);

            // recv response
            Byte[] buffer = new byte[1024];
            int size;
            MemoryStream msResponse = new MemoryStream();
            do {
                try {
                    // get response stream
                    size = await stream.ReadAsync(buffer, 0, buffer.Length);
                } catch(Exception err) {
                    writeTcpClientTb("err : " + err.Message);
                    msResponse.Close();
                    stream.Close();
                    client.Close();
                    btnTcpClientSend.Enabled = true;
                    return;
                }
                if(size == 0) {
                    break;
                }
                // put data to ms
                await msResponse.WriteAsync(buffer, 0, size);
            } while(stream.DataAvailable || buffer[size - 1] != '\n');
            // convert to string
            Byte[] byteData = msResponse.GetBuffer();
            string response = Encoding.UTF8.GetString(byteData, 0, (int)byteData.Length);
            msResponse.Close();

            writeTcpClientTb("receive response, data : " + response);
            if(cbTcpClientShowHexData.Checked) {
                writeTcpClientTb("hex data:" + Environment.NewLine + General.GetHexDataString(byteData));
            }
            stream.Close();
            client.Close();

            btnTcpClientSend.Enabled = true;

            return;
        }
        // update TCP client TextBox
        private void writeTcpClientTb(string str) {
            if(tbTcpClientResponse.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpClientTb(str); });
            } else {
                tbTcpClientResponse.AppendText(General.GetLogTime() + str + Environment.NewLine);
            }
        }

        // ------------------------------------------------------------
        //  TCP Server
        // ------------------------------------------------------------
        private async void btnTcpServerListen_Click(object sender, EventArgs e) {
            if(btnTcpServerListen.Text == "listen") {
                btnTcpServerListen.Text = "stop";
                await tcpServer();
            } else if(btnTcpServerListen.Text == "stop") {
                tcpListener.Stop();
                btnTcpServerListen.Text = "listen";
            }
        }

        private async Task tcpServer() {


            int port;
            try {
                port = int.Parse(tbTcpServerPort.Text);
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                btnTcpServerListen.Text = "listen";
                return;
            }

            IPEndPoint serverEp;
            try {
                serverEp = new IPEndPoint(IPAddress.Any, port);
            } catch {
                General.ShowErrMsgBox("Please input valid port num.");
                return;
            }
            writeTcpServerTb("TCP listener start @localhost:" + port);
            try {
                tcpListener = new TcpListener(serverEp);
                tcpListener.Start();
            } catch {
                General.ShowErrMsgBox("Cannot open tcpListener.");
                return;
            }

            while(true) {
                TcpClient client;
                try {
                    client = await tcpListener.AcceptTcpClientAsync();
                } catch(ObjectDisposedException err) {
                    writeTcpServerTb("Listener stopped.");
                    return;
                }
                string clientIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                string clientPort = ((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString();
                writeTcpServerTb("Establish connection from " + clientIp + ":" + clientPort);

                // get ns
                NetworkStream stream = client.GetStream();
                // timeout setting
                stream.ReadTimeout = 5000;
                stream.WriteTimeout = 5000;

                // recv request
                Byte[] buffer = new byte[256];
                int size = 0;
                MemoryStream msRequest = new MemoryStream();
                while(stream.DataAvailable) {
                    // get response stream
                    try {
                        size = stream.Read(buffer, 0, buffer.Length);
                    } catch(Exception err) {
                        writeTcpServerTb("err : " + err.Message);
                        stream.Close();
                        client.Close();
                        return;
                    }
                    if(size == 0) {
                        break;
                    }
                    // put data to ms
                    msRequest.Write(buffer, 0, size);
                }
                // convert to string
                Byte[] byteData = msRequest.GetBuffer();
                string request = Encoding.UTF8.GetString(byteData, 0, (int)byteData.Length);

                writeTcpServerTb("receive request, data : " + request);
                if(cbTcpServerShowHexData.Checked) {
                    writeTcpServerTb("hex data:" + Environment.NewLine + General.GetHexDataString(byteData));
                }

                // send response
                if(cbTcpServerEchoMode.Checked) {
                    byte[] resBytes = msRequest.ToArray();
                    stream.Write(resBytes, 0, (int)resBytes.Length);
                } else {
                    string response = tbTcpServerResponse.Text;
                    byte[] resBytes = General.String2Bytes(response, false, cbTcpServerAddTailLn.Checked);
                    stream.Write(resBytes, 0, resBytes.Length);
                }
                writeTcpServerTb("send response.");
                msRequest.Close();
                stream.Close();
                client.Close();
            }
        }

        // update TCP server TextBox
        private void writeTcpServerTb(string str) {
            if(tbTcpServerRequest.InvokeRequired) {
                this.Invoke((MethodInvoker)delegate { writeTcpServerTb(str); });
            } else {
                tbTcpServerRequest.AppendText(General.GetLogTime() + str + Environment.NewLine);
            }
        }

        // ------------------------------------------------------------
        //  UI
        // ------------------------------------------------------------
        private void btnTcpClientClear_Click(object sender, EventArgs e) {
            tbTcpClientResponse.Text = string.Empty;
        }

        private void btnTcpServerClear_Click(object sender, EventArgs e) {
            tbTcpServerRequest.Text = string.Empty;
        }

        private void btnTcpClientClear_Click_1(object sender, EventArgs e) {
            tbTcpClientResponse.Text = string.Empty;
        }
        private void btnUdpServerClear_Click(object sender, EventArgs e) {
            tbUdpServerLog.Text = String.Empty;
        }

        private void cbUdpServerEchoMode_CheckedChanged(object sender, EventArgs e) {
            this.tbUdpServerResponse.ReadOnly = cbUdpServerEchoMode.Checked;
            this.cbUdpServerAddTailLn.Enabled = !cbUdpServerEchoMode.Checked;
        }

        private void cbTcpServerEchoMode_CheckedChanged(object sender, EventArgs e) {
            this.tbTcpServerResponse.ReadOnly = cbTcpServerEchoMode.Checked;
            this.cbTcpServerAddTailLn.Enabled = !cbTcpServerEchoMode.Checked;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
            cts4TcpConServer.Cancel();
            cts4TcpConClient.Cancel();

            if(tcpConClientSocket != null) {
                tcpConClientSocket.Close();
            }
            if(tcpConServerSocket != null) {
                tcpConServerSocket.Close();
            }
            if(tcpConServerHandler != null) {
                tcpConServerHandler.Close();
            }
        }

        private void Form1_Shown(object sender, EventArgs e) {
            // window position setting
            int needRestorePosition = 0;
            foreach(Screen scr in Screen.AllScreens) {
                if(scr.WorkingArea.Contains(this.Location.X, this.Location.Y)) {
                    needRestorePosition++;
                }
            }
            if(needRestorePosition == 0) {
                this.Location = new System.Drawing.Point(100, 100);
            }
        }
    }
}
