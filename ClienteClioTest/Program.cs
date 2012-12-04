using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace ClienteClioTest
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
         
            

            //ServiceBase [] ServicesToRun;
            ClienteClioTest servicioCliente=new ClienteClioTest();
            //ServicesToRun = new ServiceBase[]{servicioCliente};


            AsynchronousSocketListenerService.setClienteClioService(servicioCliente);
          //  Thread workerThread = new Thread();
            ThreadStart param = delegate { ServiceBase.Run(servicioCliente); };
            Thread workerThread = new Thread(param);
            workerThread.Start();

            while (!workerThread.IsAlive);
            
            
            int port = 11001;
             AsynchronousSocketListenerService.StartListening(port);
            
          //   AsynchronousSocketListener.servicioCliente
            
        }
    }
}
