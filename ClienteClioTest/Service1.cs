using System.Diagnostics;
using System.ServiceProcess;
using System.IO;
using System;
using ClienteGUI;


namespace ClienteClioTest
{
    public partial class ClienteClioTest : ServiceBase
    {
        public ClienteClioTest()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            FileStream fs = new FileStream(@"c:\ClioTest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SR = new StreamWriter(fs);
            SR.WriteLine("El servico se ha iniciado");
            SR.Flush();
            SR.Close();
            EventLog.WriteEntry("Iniciando Servicio");
        }
       /* public void MostrarMensaje(String mensaje)
        {
           

        }*/
       
        public void ApagarPC() {
           System.Diagnostics.Process.Start("Shutdown", "-s -t 10"); 
           // Program2.Main();
            
        }
        protected override void OnStop()
        {
            FileStream fs = new FileStream(@"c:\ClioTest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SR = new StreamWriter(fs);
            SR.WriteLine("El servico ha parado");
            SR.Flush();
            SR.Close();
            EventLog.WriteEntry("Parando el servicio");
        }

    }
}
