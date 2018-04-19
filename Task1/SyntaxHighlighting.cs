using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class SyntaxHighlighting
    {
        public static bool IsOn { get; set; } = false;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(HandleRef hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);

        static void EnableRepaint(HandleRef handle, bool enable)
        {
            const int WM_SETREDRAW = 0x000B;
            SendMessage(handle, WM_SETREDRAW, new IntPtr(enable ? 1 : 0), IntPtr.Zero);
        }
        class Selection
        {
            public int Start { get; set; }
            public int End { get; set; }
            public static bool IsInner(Selection[] selections, int index)
            {
                foreach (var item in selections)
                {
                    if (index >= item.Start && index <= item.End)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public static void RePaint(ref RichTextBox textBoxText,Color textColor)
        {
            if (!IsOn)
                return;
            HandleRef gh = new HandleRef(textBoxText, textBoxText.Handle);
            EnableRepaint(gh, false);

            // we need at least one repaint to happen...

            List<Selection> selections = new List<Selection>();
            MatchCollection allWords = Regex.Matches(textBoxText.Text, @"\busing\b|\bnamespace\b|\bpublic\b|\bvoid\b|\bprivate\b|\bint\b", RegexOptions.Multiline | RegexOptions.Compiled);
            int currentSelection = textBoxText.SelectionStart;
            Color currentColor = Color.Black;
            foreach (Match ip in allWords)
            {
                textBoxText.SelectionStart = ip.Index;
                textBoxText.SelectionLength = ip.Length;
                
                    textBoxText.SelectionColor = Color.FromArgb(86, 150, 183);

                selections.Add(new Selection { Start = ip.Index, End = ip.Index + ip.Length-1 });
            }
            if (selections.Count != 0)
            {
                int start = 0;
                for (int i = 0; i < selections.Count; i++)
                {

                    textBoxText.SelectionStart = start;
                    textBoxText.SelectionLength = selections[i].Start - start;
                    start = selections[i].End + 1;
                    textBoxText.SelectionColor = textColor;
                    

                }
                textBoxText.SelectionStart = start;
                if(start<textBoxText.TextLength)
                    textBoxText.SelectionLength = textBoxText.TextLength - start;
                else
                    textBoxText.SelectionLength = textBoxText.TextLength - (start-1);
                textBoxText.SelectionColor = textColor;
            }
            else
            {
                textBoxText.SelectionStart = 0;
                textBoxText.SelectionLength = textBoxText.TextLength;
                textBoxText.SelectionColor = textColor;
            }
            textBoxText.SelectionStart = currentSelection;
            textBoxText.SelectionLength = 0;
            textBoxText.SelectionColor = textColor;
            EnableRepaint(gh, true);
            textBoxText.Invalidate();
        }
    }
}
