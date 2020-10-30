using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;

namespace CMArchivoSharePointAct
{
    class Program
    {
        static void Main(string[] args)
        {
            EjecutarProceso();

        }

        static void EjecutarProceso()
        {

            ClientContext clientContext = new ClientContext("");

            //Microsoft.SharePoint.Client.ClientObjectList<Object> lista = new ClientObjectList<Object>();
        }
    }
}
