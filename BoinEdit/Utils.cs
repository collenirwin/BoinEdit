using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace BoinEditNS {
    public static class Utils {
        public static DirectoryInfo scratchDir = new DirectoryInfo("scratch");
        public static DirectoryInfo scratchNewDir = new DirectoryInfo("scratch\\new");

        public static bool safeGenDir(DirectoryInfo dir) {
            if (!Directory.Exists(dir.FullName)) {
                try {
                    dir.Create();
                    return true;
                } catch {
                    return false;
                }
            }

            return true;
        }

        public static int getUnnamedFileCount() {
            if (safeGenDir(scratchNewDir)) {
                return scratchNewDir.GetFiles().Length;
            }

            return -1;
        }

        public static string getHash(string input) {
            string name = "";

            using (MD5 md5 = MD5.Create()) {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                for (int x = 0; x < data.Length; x++) {
                    name += data[x].ToString("x2"); // format as hex
                }
            }

            return name;
        }

        public static bool hashesMatch(string plainValue, string hashedValue) {
            string hashOfInput = getHash(plainValue);
            
            return (hashOfInput == hashedValue);
        }

        public static void purgeNewScratchFiles() {
            if (safeGenDir(scratchNewDir)) {
                foreach (FileInfo file in scratchNewDir.GetFiles()) {
                    try {
                        file.Delete();
                    } catch { }
                }
            }
        }
    }
}
