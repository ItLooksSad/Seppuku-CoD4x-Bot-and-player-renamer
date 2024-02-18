using System.ComponentModel;
using System.Text;
using Memory;

namespace Gripz_CoD4x_Degen_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region hooking + bg working
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        Mem m = new Mem();

        bool ProcOpen = false;
        string processName = "iw3mp";

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = m.OpenProcess(processName);
            if (!ProcOpen)
            {
                Thread.Sleep(1500);

                return;
            }
            Thread.Sleep(1500);

            backgroundWorker1.ReportProgress(0);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }


        private async void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                gameStatusLabel.ForeColor = Color.SeaGreen;
                gameStatusLabel.Text = "Game Found!";
                m.OpenProcess(processName);
                keepHookingCoD.Start();

            }
        }

        private void keepHookingCoD_Tick(object sender, EventArgs e)
        {
            m.OpenProcess(processName);
        }

        #endregion

        private void getNamesButton_Click(object sender, EventArgs e)
        {
            //nameTextbox1 = m.ReadString("cod4x_021.dll+443D22E", 15);
            //string test = m.ReadString("cod4x_021.dll+443D22E", stringEncoding: Encoding.Unicode);
            nameTextbox1.Text = m.ReadString("cod4x_021.dll+443D22E", "", 15, true);
            nameTextbox2.Text = m.ReadString("cod4x_021.dll+443D25C", "", 15, true);
            nameTextbox3.Text = m.ReadString("cod4x_021.dll+443D28A", "", 15, true);
            nameTextbox4.Text = m.ReadString("cod4x_021.dll+443D2B8", "", 15, true);
            nameTextbox5.Text = m.ReadString("cod4x_021.dll+443D2E6", "", 15, true);
            nameTextbox6.Text = m.ReadString("cod4x_021.dll+443D314", "", 15, true);
            nameTextbox7.Text = m.ReadString("cod4x_021.dll+443D342", "", 15, true);
            nameTextbox8.Text = m.ReadString("cod4x_021.dll+443D370", "", 15, true);
            nameTextbox9.Text = m.ReadString("cod4x_021.dll+443D39E", "", 15, true);
            nameTextbox10.Text = m.ReadString("cod4x_021.dll+443D3CC", "", 15, true);

            nameTextbox11.Text = m.ReadString("cod4x_021.dll+443D3FA", "", 15, true);
            nameTextbox12.Text = m.ReadString("cod4x_021.dll+443D428", "", 15, true);
            nameTextbox13.Text = m.ReadString("cod4x_021.dll+443D456", "", 15, true);
            nameTextbox14.Text = m.ReadString("cod4x_021.dll+443D484", "", 15, true);
            nameTextbox15.Text = m.ReadString("cod4x_021.dll+443D4B2", "", 15, true);
            nameTextbox16.Text = m.ReadString("cod4x_021.dll+443D4E0", "", 15, true);
            nameTextbox17.Text = m.ReadString("cod4x_021.dll+443D50E", "", 15, true);
            nameTextbox18.Text = m.ReadString("cod4x_021.dll+443D53C", "", 15, true);
            nameTextbox19.Text = m.ReadString("cod4x_021.dll+443D56A", "", 15, true);
            nameTextbox20.Text = m.ReadString("cod4x_021.dll+443D598", "", 15, true);

            nameTextbox21.Text = m.ReadString("cod4x_021.dll+443D5C6", "", 15, true);
            nameTextbox22.Text = m.ReadString("cod4x_021.dll+443D5F4", "", 15, true);
            nameTextbox23.Text = m.ReadString("cod4x_021.dll+443D622", "", 15, true);
            nameTextbox24.Text = m.ReadString("cod4x_021.dll+443D67E", "", 15, true);
            nameTextbox25.Text = m.ReadString("cod4x_021.dll+443D6AC", "", 15, true);
            nameTextbox26.Text = m.ReadString("cod4x_021.dll+443D6DA", "", 15, true);
            nameTextbox27.Text = m.ReadString("cod4x_021.dll+443D708", "", 15, true);
            nameTextbox28.Text = m.ReadString("cod4x_021.dll+443D736", "", 15, true);
            nameTextbox29.Text = m.ReadString("cod4x_021.dll+443D764", "", 15, true);
            nameTextbox30.Text = m.ReadString("cod4x_021.dll+443D792", "", 15, true); // done 

            nameTextbox31.Text = m.ReadString("cod4x_021.dll+443D7C0", "", 15, true);
            nameTextbox32.Text = m.ReadString("cod4x_021.dll+443D7EE", "", 15, true);
            nameTextbox33.Text = m.ReadString("cod4x_021.dll+443D81C", "", 15, true);
            nameTextbox34.Text = m.ReadString("cod4x_021.dll+443D84A", "", 15, true);
            nameTextbox35.Text = m.ReadString("cod4x_021.dll+443D878", "", 15, true);
            nameTextbox36.Text = m.ReadString("cod4x_021.dll+443D8A6", "", 15, true);
            nameTextbox37.Text = m.ReadString("cod4x_021.dll+443D8D4", "", 15, true);
            nameTextbox38.Text = m.ReadString("cod4x_021.dll+443D902", "", 15, true);
            nameTextbox39.Text = m.ReadString("cod4x_021.dll+443D930", "", 15, true);
            nameTextbox40.Text = m.ReadString("cod4x_021.dll+443D95E", "", 15, true);

            nameTextbox41.Text = m.ReadString("cod4x_021.dll+443D98C", "", 15, true);
            nameTextbox42.Text = m.ReadString("cod4x_021.dll+443D9BA", "", 15, true);
            nameTextbox43.Text = m.ReadString("cod4x_021.dll+443D9E8", "", 15, true);
            nameTextbox44.Text = m.ReadString("cod4x_021.dll+443DA16", "", 15, true);
            nameTextbox45.Text = m.ReadString("cod4x_021.dll+443DA44", "", 15, true);
            nameTextbox46.Text = m.ReadString("cod4x_021.dll+443DA72", "", 15, true);
            nameTextbox47.Text = m.ReadString("cod4x_021.dll+443DAA0", "", 15, true);
            nameTextbox48.Text = m.ReadString("cod4x_021.dll+443DACE", "", 15, true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                spoofNameTimer.Start();
            }
            else
            {
                spoofNameTimer.Stop();
            }
        }

        private void spoofNameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                m.WriteMemory("cod4x_021.dll+443D22E", "string", nameTextbox1.Text);
                m.WriteMemory("cod4x_021.dll+443D25C", "string", nameTextbox2.Text);
                m.WriteMemory("cod4x_021.dll+443D28A", "string", nameTextbox3.Text);
                m.WriteMemory("cod4x_021.dll+443D2B8", "string", nameTextbox4.Text);
                m.WriteMemory("cod4x_021.dll+443D2E6", "string", nameTextbox5.Text);
                m.WriteMemory("cod4x_021.dll+443D314", "string", nameTextbox6.Text);
                m.WriteMemory("cod4x_021.dll+443D342", "string", nameTextbox7.Text);
                m.WriteMemory("cod4x_021.dll+443D370", "string", nameTextbox8.Text);
                m.WriteMemory("cod4x_021.dll+443D39E", "string", nameTextbox9.Text);
                m.WriteMemory("cod4x_021.dll+443D3CC", "string", nameTextbox10.Text);

                m.WriteMemory("cod4x_021.dll+443D3FA", "string", nameTextbox11.Text);
                m.WriteMemory("cod4x_021.dll+443D428", "string", nameTextbox12.Text);
                m.WriteMemory("cod4x_021.dll+443D456", "string", nameTextbox13.Text);
                m.WriteMemory("cod4x_021.dll+443D484", "string", nameTextbox14.Text);
                m.WriteMemory("cod4x_021.dll+443D4B2", "string", nameTextbox15.Text);
                m.WriteMemory("cod4x_021.dll+443D4E0", "string", nameTextbox16.Text);
                m.WriteMemory("cod4x_021.dll+443D50E", "string", nameTextbox17.Text);
                m.WriteMemory("cod4x_021.dll+443D53C", "string", nameTextbox18.Text);
                m.WriteMemory("cod4x_021.dll+443D56A", "string", nameTextbox19.Text);
                m.WriteMemory("cod4x_021.dll+443D598", "string", nameTextbox20.Text);

                m.WriteMemory("cod4x_021.dll+443D5C6", "string", nameTextbox21.Text);
                m.WriteMemory("cod4x_021.dll+443D5F4", "string", nameTextbox22.Text);
                m.WriteMemory("cod4x_021.dll+443D622", "string", nameTextbox23.Text);
                m.WriteMemory("cod4x_021.dll+443D67E", "string", nameTextbox24.Text);
                m.WriteMemory("cod4x_021.dll+443D6AC", "string", nameTextbox25.Text);
                m.WriteMemory("cod4x_021.dll+443D6DA", "string", nameTextbox26.Text);
                m.WriteMemory("cod4x_021.dll+443D708", "string", nameTextbox27.Text);
                m.WriteMemory("cod4x_021.dll+443D736", "string", nameTextbox28.Text);
                m.WriteMemory("cod4x_021.dll+443D764", "string", nameTextbox29.Text);
                m.WriteMemory("cod4x_021.dll+443D792", "string", nameTextbox30.Text);

                m.WriteMemory("cod4x_021.dll+443D7C0", "string", nameTextbox31.Text);
                m.WriteMemory("cod4x_021.dll+443D7EE", "string", nameTextbox32.Text);
                m.WriteMemory("cod4x_021.dll+443D81C", "string", nameTextbox33.Text);
                m.WriteMemory("cod4x_021.dll+443D84A", "string", nameTextbox34.Text);
                m.WriteMemory("cod4x_021.dll+443D878", "string", nameTextbox35.Text);
                m.WriteMemory("cod4x_021.dll+443D8A6", "string", nameTextbox36.Text);
                m.WriteMemory("cod4x_021.dll+443D8D4", "string", nameTextbox37.Text);
                m.WriteMemory("cod4x_021.dll+443D902", "string", nameTextbox38.Text);
                m.WriteMemory("cod4x_021.dll+443D930", "string", nameTextbox39.Text);
                m.WriteMemory("cod4x_021.dll+443D95E", "string", nameTextbox40.Text);

                m.WriteMemory("cod4x_021.dll+443D98C", "string", nameTextbox41.Text);
                m.WriteMemory("cod4x_021.dll+443D9BA", "string", nameTextbox42.Text);
                m.WriteMemory("cod4x_021.dll+443D9E8", "string", nameTextbox43.Text);
                m.WriteMemory("cod4x_021.dll+443DA16", "string", nameTextbox44.Text);
                m.WriteMemory("cod4x_021.dll+443DA44", "string", nameTextbox45.Text);
                m.WriteMemory("cod4x_021.dll+443DA72", "string", nameTextbox46.Text);
                m.WriteMemory("cod4x_021.dll+443DAA0", "string", nameTextbox47.Text);
                m.WriteMemory("cod4x_021.dll+443DACE", "string", nameTextbox48.Text);


            }
            catch { }
        }
    }
}
