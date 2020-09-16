using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronPython.Hosting;

namespace DouCode
{
    public partial class PyhtonModuleForm : Form
    {
        private String scriptResult = "";
        public PyhtonModuleForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameActionForm gameForm = new GameActionForm();
            gameForm.ShowDialog();
            this.Close();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            scriptResult = "";
            String pyCode = textBoxPythonModule.Text;
            MemoryStream ms = new MemoryStream();

            EventRaisingStreamWriter outputWr = new EventRaisingStreamWriter(ms);
            outputWr.StringWritten += new EventHandler<MyEvtArgs<string>>(sWr_StringWritten);

            var engine = Python.CreateEngine();
            engine.Runtime.IO.SetOutput(ms, outputWr);
            try
            {
                engine.CreateScriptSourceFromString(pyCode).Execute();
            }
            catch (Exception ex)
            {
                scriptResult = ex.Message;
            }

            textBoxPythonModule.Text = scriptResult;

            
        }
        void sWr_StringWritten(object sender, MyEvtArgs<string> e)
        {
            scriptResult += e.Value;
        }

    }
    public class MyEvtArgs<T> : EventArgs
    {
        public T Value
        {
            get;
            private set;
        }
        public MyEvtArgs(T value)
        {
            this.Value = value;
        }
    }


    public class EventRaisingStreamWriter : StreamWriter
    {

        public event EventHandler<MyEvtArgs<string>> StringWritten;

        public EventRaisingStreamWriter(Stream s) : base(s)
        { }

        private void LaunchEvent(string txtWritten)
        {
            if (StringWritten != null)
            {
                StringWritten(this, new MyEvtArgs<string>(txtWritten));
            }
        }

        public override void Write(string value)
        {
            base.Write(value);
            LaunchEvent(value);
        }
        public override void Write(bool value)
        {
            base.Write(value);
            LaunchEvent(value.ToString());
        }

    }
}
