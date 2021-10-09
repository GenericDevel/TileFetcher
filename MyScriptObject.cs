using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileFetcher
{
    [ComVisible(true)]
    public class MyScriptObject
    {
        private FormMain _form;

        public MyScriptObject(FormMain form)
        {
            _form = form;
        }

        public void Test(string message)
        {
            MessageBox.Show(message, "client code");
        }
    }
}
