using System;

namespace Avisos_con_Interfaces
{
    class AvisoTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisoTrafico()
        {
            remitente = "Dirección General de Tráfico";
            mensaje = "Infracción cometida. Pague antes de los 10 días y tendrá un descuento del 20%";
            fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string getFecha()
        {
            return fecha;
        }

        public void MensajeAviso()
        {
            Console.WriteLine($"Mensaje {mensaje} ha sido enviado por {remitente} el día {fecha}");
            //Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}",mensaje,remitente,fecha);
        }
    }
}
