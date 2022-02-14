using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin
{
    internal partial class Warning : CustomForm
    {
        static int count = 0;

        public Warning()
        {
            InitializeComponent();
            MakeNew();
            count++;
        }
        async void MakeNew()
        {
            await Task.Delay(100);
            if (count < 10) new Warning().ShowDialog();
            else new Progress(0).ShowDialog();
        }
    }
}
