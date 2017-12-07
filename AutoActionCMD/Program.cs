using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AutoActionCMD
{
    class Program
    {
        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;

        //This simulates a left mouse click
        public static void MouseClick(int xpos, int ypos, int up, int down, int delay = 0)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(down, xpos, ypos, 0, 0);
            System.Threading.Thread.Sleep(delay);
            mouse_event(up, xpos, ypos, 0, 0);
        }
        static void Main(string[] args)
        {
            try {
                switch (args[0])
                {
                    case "mouse":
                        int up = 0;
                        int down = 0;
                        switch (args[1])
                        {
                            case "left":
                                up = MOUSEEVENTF_LEFTUP;
                                down = MOUSEEVENTF_LEFTDOWN;
                                break;
                            case "right":
                                up = MOUSEEVENTF_RIGHTUP;
                                down = MOUSEEVENTF_RIGHTDOWN;
                                break;
                            case "middle":
                                up = MOUSEEVENTF_MIDDLEUP;
                                down = MOUSEEVENTF_MIDDLEDOWN;
                                break;
                            default:
                                up = MOUSEEVENTF_LEFTUP;
                                down = MOUSEEVENTF_LEFTDOWN;
                                break;
                        }
                        try
                        {
                            MouseClick(int.Parse(args[2]), int.Parse(args[3]), up, down, int.Parse(args[4]));
                            Console.WriteLine("Mouse clicked");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "key":
                        try
                        {
                            SendKeys.SendWait(args[1]);
                            Console.WriteLine("Sent");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "wait":
                        try
                        {
                            System.Threading.Thread.Sleep(int.Parse(args[1]));
                            Console.WriteLine("Waited");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "processwait":
                        try
                        {
                            if (args.Length==2)
                            {
                                System.Diagnostics.Process.Start(args[1]).WaitForExit();
                            }
                            if(args.Length ==3)
                            {
                                System.Diagnostics.Process.Start(args[1], args[2]).WaitForExit();
                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "process":
                        try
                        {
                            if (args.Length == 2)
                            {
                                System.Diagnostics.Process.Start(args[1]);
                            }
                            if (args.Length == 3)
                            {
                                System.Diagnostics.Process.Start(args[1], args[2]);
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid arguments");
            }
        }
    }
}
