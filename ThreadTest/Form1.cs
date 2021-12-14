using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        
        private List<Task> _listaThreads = new();
        List<StatusTheads> _listaStatusTheads = new();
        private int _idInicialTheads = 1;


        public Form1()
        {
            InitializeComponent();
        }


        private void InicializarProcessamento()
        {
            LimparThreads();

            IniciarProgresso();

            if (_listaThreads.Count <= 0 && _listaStatusTheads.Count <= 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    AddNewThread();
                }
            }

            Task.Run(() => { IniciarMonitoramento(Monitor, StopProgressInvoke); });

        }

        private void LimparThreads()
        {
            _listaThreads.Clear();
            _listaStatusTheads.Clear();
            
        }

        private void AddNewThread()
        {
            StatusTheads statusTheads = new StatusTheads("Thread" + _idInicialTheads, _idInicialTheads);            
            _idInicialTheads++;

            _listaStatusTheads.Add(statusTheads);
            _listaThreads.Add(Task.Run(() => { Processar(Log, statusTheads); }, statusTheads.token));
        }

        private void Processar(Action<string> log, StatusTheads statusTheads)
        {
            try
            {

                DateTime data = DateTime.Now;
                while (statusTheads.processando)
                {
                    DateTime now = DateTime.Now;

                    if (statusTheads.gerarErro)
                    {
                        string msg = statusTheads.identificador + $"(Id:{statusTheads.id}) -> parou de funcinar.";
                        log(msg);
                        throw new Exception(msg);
                    }

                    if (statusTheads.token.IsCancellationRequested)
                    {                        
                        string msg = statusTheads.identificador + $"(Id:{statusTheads.id}) -> foi cancelada.";
                        log(msg);
                        statusTheads.token.ThrowIfCancellationRequested();
                    }

                    if (data.Second != now.Second)
                    {
                        data = now;
                        log(statusTheads.identificador + $"(Id:{statusTheads.id}) -> " + now.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                //LogError()
                //Rollback()
            }

        }


        private void IniciarMonitoramento(Action<string> log, Action stopProgress)
        {
            _idInicialTheads++;
            DateTime data = DateTime.Now;
            while (!_listaThreads.TrueForAll(t => t.IsCompleted))
            {
                DateTime now = DateTime.Now;

                if (data.Second != now.Second)
                {
                    data = AddStatusTheadsMonitor(log, data, now);
                }
            }


            AddStatusTheadsMonitor(log, data, DateTime.Now);
            stopProgress();

        }

        private DateTime AddStatusTheadsMonitor(Action<string> log, DateTime data, DateTime now)
        {
            foreach (var thread in _listaThreads)
            {
                var strLog = $"[{now:hh:mm:ss}] Id: {thread.Id} - {thread.Status} - Completed: {thread.IsCompleted} - Canceled: {thread.IsCanceled}";
                log(strLog);
                data = now;
            }

            return data;
        }

        private void Log(string log)
        {                      
            this.Invoke(
                new Action(() => {txtConsole.AppendText(log + Environment.NewLine); 
                                 // txtConsole.Focus();
                                 })                    
            );
        }

        private void Monitor(string log)
        {
            this.Invoke(
                new Action(() => { txtMonitor.AppendText(log + Environment.NewLine);
                                   //txtMonitor.Focus();
                })
            );
        }

       

        private void IniciarProgresso()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            btnAddThead.Enabled = true;
        }

        private void PararProgresso()
        {
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.MarqueeAnimationSpeed = 0;
            btnAddThead.Enabled = false;
        }

        private void StopProgressInvoke()
        {
            this.Invoke(
                new Action(() => { PararProgresso(); })
            );
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
           _listaThreads.ForEach(thread => PararThead(thread.Id));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InicializarProcessamento();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            PararThead(1);
        }

        private void PararThead(int id)
        {
            if (_listaStatusTheads != null && _listaStatusTheads.Count > 0)
            {
                var task = _listaStatusTheads.Find(t => t.id.Equals(id));
                if (task != null)
                    task.processando = false;
            }
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            PararThead(2);
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            if(txtId.Value > 0)
            {
                PararThead((int)txtId.Value);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.ScrollToCaret();
            txtMonitor.ScrollToCaret();            
        }

        private void ErrorThead(int id)
        {
            if (_listaStatusTheads != null && _listaStatusTheads.Count > 0)
            {
                var task = _listaStatusTheads.Find(t => t.id.Equals(id));
                if (task != null)
                    task.gerarErro = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorThead(1);
        }


        private void CancelThread(int id)
        {
            if (_listaStatusTheads != null && _listaStatusTheads.Count > 0)
            {
                var task = _listaStatusTheads.Find(t => t.id.Equals(id));
                if (task != null)
                {
                    var thread = _listaThreads.Find(t => t.Id.Equals(task.id));
                    task.tokenSource.CancelAfter(3000);                    
                }
                    
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            CancelThread(2);
        }

        private void btnAddThead_Click(object sender, EventArgs e)
        {
            AddNewThread();
        }
    }

    public class StatusTheads
    {
        public string identificador;
        public int id;
        public bool processando;
        public bool gerarErro;
        public CancellationToken token;
        public CancellationTokenSource tokenSource;

        public StatusTheads(string identificador, int id)
        {
            this.identificador = identificador;
            this.id = id;
            this.processando = true;
            this.gerarErro = false;

            this.tokenSource = new CancellationTokenSource();
            this.token = tokenSource.Token;
           
        }
    }
}
