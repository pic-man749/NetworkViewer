using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkViewer {
    // ------------------------------------------------------------
    //  general
    // ------------------------------------------------------------
    class General {

        // show err message box
        public static void ShowErrMsgBox(string str) {
            MessageBox.Show(str, "Error", MessageBoxButtons.OK);
        }

        // get payload data
        public static Byte[] String2Bytes(string str, bool isHexMode, bool needLn) {
            if(isHexMode) {
                // Hex mode
                List<byte> sendByteList = new List<byte>();
                for(int i = 0; i < str.Length; i += 2) {
                    try {
                        sendByteList.Add(Convert.ToByte(str.Substring(i, 2), 16));
                    } catch {
                        throw new Exception("Failed to convert str to hexbyte");
                    }
                }
                if(needLn) { sendByteList.Add(0x0A); }
                return sendByteList.ToArray();
            } else {
                // ASCII mode
                // なんか納得いかない書き方
                string tmp;
                if(needLn) {
                    tmp = str + '\n';
                } else {
                    tmp = str;
                }
                Byte[] ret = Encoding.UTF8.GetBytes(tmp);
                return ret;
            }
        }

        // get payload hex string
        public static string GetHexDataString(string str) {
            string result = "";
            result += "      | 00 01 02 03 04 05 06 07  08 09 0A 0B 0C 0D 0E 0F" + Environment.NewLine;
            result += "------+--------------------------------------------------" + Environment.NewLine;
            result += " 0000 | ";
            Byte[] data = Encoding.UTF8.GetBytes(str);
            for(int i = 0; i < data.Length; i++) {
                // print data
                result += string.Format("{0:X2} ", data[i]);

                if((i + 1) % 0x10 == 0) {
                    result += String.Format(Environment.NewLine + " {0:X4} | ", i + 1);
                } else if((i + 1) % 0x8 == 0) {
                    result += " ";
                }
            }
            result += Environment.NewLine;
            return result;
        }

        public static string GetLogTime() {
            return String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}]", DateTime.Now);
        }
    }
}
