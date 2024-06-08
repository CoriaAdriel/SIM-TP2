using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM_TP4.Model
{
    public enum TipoCliente
    {
        SolicitudPermiso,
        RevisiónPlano,
        InspeccionObra,
        ConsultaNormativa,
    }

    public enum EstadoCliente
    {
        Esperando,
        EnAtencion
    }

    public class Cliente
    {
        int Id;
        TipoCliente Tipo;
        EstadoCliente Estado;
        float HorarioLlegada;

        static int IdCounter = 0;

        public Cliente(TipoCliente tipo, float horario)
        {
            Id = ++IdCounter;
            Tipo = tipo;
            Estado = EstadoCliente.Esperando;
            HorarioLlegada = horario;
        }

        public static void ResetIds()
        {
            IdCounter = 0;
        }

        public EstadoCliente GetEstado()
        {
            return Estado;
        }


        public TipoCliente GetTipo()
        {
            return Tipo;
        }


        public float GetHorarioLlegada()
        {
            return HorarioLlegada;
        }
    }

}
