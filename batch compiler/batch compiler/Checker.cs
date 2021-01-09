using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace batch_compiler
{
    class Checker
    {
        public string findWord(int lengt)
        {
            switch (lengt)
            {
                case 1:
                    return "echo";
                case 2:
                    return "msg *";
                case 3:
                    return "if";
                case 4:
                    return "@echo off";
                case 5:
                    return "goto";
                case 6:
                    return "timeout";
                case 7:
                    return "/nobreak";
                case 8:
                    return "shutdown";
                case 9:
                    return "/p";
                case 10:
                    return "/t";
                case 11:
                    return "color";
                case 12:
                    return "XCOPY";
                case 13:
                    return "Mystring=";
                case 14:
                    return "del";
                case 15:
                    return "/s";
                case 16:
                    return "/q";
                case 17:
                    return "/a";
                case 18:
                    return "-s";
                case 19:
                    return "-r";
                case 20:
                    return "-h";
                case 21:
                    return "attrib";
                case 22:
                    return "/d";
                case 23:
                    return "cls";
                case 24:
                    return "set";
                case 25:
                    return "sfc";
                case 26:
                    return "/scannow";
                case 27:
                    return "pause";
                case 28:
                    return "start";
                case 29:
                    return "DISM.exe";
                case 30:
                    return "/Cleanup-Image";
                case 31:
                    return "/RestoreHealth";
                case 32:
                    return "/Online";
                case 33:
                    return "exit";
                case 34:
                    return "cd";
                case 35:
                    return "color";
                case 36:
                    return "copy";
                case 37:
                    return "exit";
                case 38:
                    return "taskkill";
                /*case 39:
                    return "";*/
                default:
                    return "find";
                
            }
        }
    }
}
