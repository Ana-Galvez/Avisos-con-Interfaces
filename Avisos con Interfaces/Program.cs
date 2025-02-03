using System;

namespace Avisos_con_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisoTrafico aviso1 = new AvisoTrafico("Vialidad nacional","Notificación por exceso de velocidad:$300000","13 de enero de 2025");
            aviso1.MensajeAviso();

        }
    }
}
