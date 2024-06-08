using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP4.Simulaciones
{
    public class SimulacionNormal
    {
        public int simulaciones {  get; set; }
        public int desde {  get; set; }
        public int empleadosPermisos {  get; set; }
        public int empleadosPlanos { get; set; }
        public int empleadosObras { get; set; }
        public int empleadosNormativas { get; set; }
        public int mediaPermisos { get; set; }
        public int mediaPlanos { get; set;}
        public int mediaObras { get; set; }
        public int mediaNormativas { get; set; }

        public SimulacionNormal(int simulaciones, int desde, int empleadosPermisos, int empleadosPlanos, int empleadosObras, int empleadosNormativas, int mediaPermisos, int mediaPlanos, int mediaObras, int mediaNormativas)
        {
            this.simulaciones = simulaciones;
            this.desde = desde;
            this.empleadosPermisos = empleadosPermisos;
            this.empleadosPlanos = empleadosPlanos;
            this.empleadosObras = empleadosObras;
            this.empleadosNormativas = empleadosNormativas;
            //dividimos por 60 para obtener la media, ya que nos llega por parametros el lambda
            this.mediaPermisos = 60/mediaPermisos;
            this.mediaPlanos = 60/mediaPlanos;
            this.mediaObras = 60 / mediaObras;
            this.mediaNormativas = 60/mediaNormativas;

            simular();
        }
        private void simular()
        {
            for (int i = 0; i < simulaciones; i++)
            {
                if (desde <= i && i <= desde + 300)
                {
                    //simulamos y visualizamos

                }
                else
                {
                    //solo simulamos
                }

            }
        }
    }
}
