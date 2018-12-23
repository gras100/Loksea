using System.Windows.Forms;

namespace Loksea
{
    public static class KeyState
    {

        public static KeyStateFlags get()
        {
            return CapsLock | ScrollLock | NumLock | Insert;
        }

        private static KeyStateFlags CapsLock
        {
            get {
                return Control.IsKeyLocked(Keys.CapsLock) ? KeyStateFlags.CapsLock : KeyStateFlags.None;
            }
        }

        private static KeyStateFlags ScrollLock
        {
            get
            {
                return Control.IsKeyLocked(Keys.Scroll) ? KeyStateFlags.ScrollLock : KeyStateFlags.None;
            }
        }

        private static KeyStateFlags NumLock
        {
            get {
                return Control.IsKeyLocked(Keys.NumLock) ? KeyStateFlags.NumLock : KeyStateFlags.None;
            }
        }

        private static KeyStateFlags Insert
        {
            get
            {
                return Control.IsKeyLocked(Keys.Insert) ? KeyStateFlags.Insert : KeyStateFlags.None;
            }   
        }
    }
}
