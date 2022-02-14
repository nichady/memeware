using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin
{
    internal partial class Progress : CustomForm
    {
        int count = 0;

        public Progress(int count)
        {
            this.count = count;

            InitializeComponent();
            count++;
            Text = Guid.NewGuid().ToString();
            CreateNew();
        }
        async void CreateNew()
        {
            await Task.Delay(250);
            if (count < 3) new Progress(count+1).ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Maximum != progressBar1.Value)
            {
                progressBar1.Value++;
                label1.Text = Guid.NewGuid().ToString();
                Console.WriteLine(Guid.NewGuid().ToString());
            }
            else
            {
                label1.Text = "DECRYPTION SUCCESSFUL";
                if (count == 3)
                {
                    Thread thread = new Thread(() => new Martin().ShowDialog());
                //    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                timer1.Stop();
            }
        }
    }
}
