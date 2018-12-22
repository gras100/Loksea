using System;
using System.Windows.Forms;

namespace Loksea
{
    class IconUpdater : IDisposable
    {
        static long updateFrequency = 2;
        System.Threading.Timer timer;
        NotifyIcon ni;

        public IconUpdater()
        {
            ni = new NotifyIcon();
            ni.Text = "LockSea lock key indicator";
            ni.Visible = true;
            Update(null);
            ni.ContextMenuStrip = new ContextMenu().Create();
        }

        public void Start()
        {
            timer = new System.Threading.Timer(Update, null, TimeSpan.FromSeconds(0.25), TimeSpan.FromSeconds(0.25));
        }

        private void Update(object alwaysNull)
        {
            ni.Icon = IconMap.get(KeyState.get());
        }

        public void Dispose()
        {
            ni.Visible = false;
            ni.Dispose();
        }

    }
}
