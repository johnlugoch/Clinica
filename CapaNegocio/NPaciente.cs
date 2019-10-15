using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidad;
using System.Data;

namespace CapaNegocio
{
    class NPaciente
    {
        
        private DPaciente _dpaciente = new CapaDatos.DPaciente();
        public readonly StringBuilder stringBuilder = new StringBuilder();

        public void registrarPaciente(EPaciente ModelPaciente)
        {
            if (validarProducto(ModelPaciente))
            {
                _dpaciente.insertar(ModelPaciente);
            }
        }

        private bool validarProducto(EPaciente ModelPaciente)
        {
            stringBuilder.Clear();

            if ((ModelPaciente.id)<0 ) stringBuilder.Append("El campo ID es obligatorio");
            if (string.IsNullOrEmpty(ModelPaciente.nombre)) stringBuilder.Append(Environment.NewLine + "El campo Nombre es obligatorio");
            if (string.IsNullOrEmpty(ModelPaciente.apellido)) stringBuilder.Append(Environment.NewLine + "El campo Apellido es obligatorio");

            //if (producto.Precio <= 0) stringBuilder.Append(Environment.NewLine + "El campo Precio es obligatorio");

            return stringBuilder.Length == 0;
        }

        public static DataTable Mostrar()
        {
            return new DPaciente().Mostrar();
        }
    }
}
