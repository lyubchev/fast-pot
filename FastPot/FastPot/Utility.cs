using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPot
{
    class Utility
    {
        public static KeyboardHook.VKeys ConvertToBindable(KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Length > 1 && e.KeyCode.ToString().StartsWith("F"))
                return (KeyboardHook.VKeys)e.KeyCode;
            if (e.KeyCode == Keys.ShiftKey)
                return KeyboardHook.VKeys.RSHIFT;
            if ((int)e.KeyCode >= 65 && (int)e.KeyCode <= 90 || (int)e.KeyCode >= 48 && (int)e.KeyCode <= 57)
                return (KeyboardHook.VKeys)e.KeyCode;
            return KeyboardHook.VKeys.NOT_A_KEY;
        }
    }
}
