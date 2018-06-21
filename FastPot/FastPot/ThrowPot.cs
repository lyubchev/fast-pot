using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPot
{
    class ThrowPot
    {
        public KeyboardHook.VKeys KeyBind { get; set; } = KeyboardHook.VKeys.KEY_Z;
        public KeyboardHook.VKeys FirstPot { get; set; } = KeyboardHook.VKeys.KEY_3;
        public KeyboardHook.VKeys LastPot { get; set; } = KeyboardHook.VKeys.KEY_8;
        public bool IsToggled { get; set; }

        KeyboardHook keyboardHook = new KeyboardHook();

        public ThrowPot()
        {
            keyboardHook.KeyUp += KeyboardHook_KeyUp;
            keyboardHook.Install();
        }

        void KeyboardHook_KeyUp(KeyboardHook.VKeys key)
        {
            if (key == KeyBind || key == KeyboardHook.VKeys.SHIFT)
            {
                IsToggled = !IsToggled;
                MainForm.MainFr.label1.Text = IsToggled ? "TOGGLED: YES" : "TOGGLED: NO";
            }
        }
    }
}
