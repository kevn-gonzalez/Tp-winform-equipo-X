using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Negocio
{
    public class MarcaDatos : GenericoDatos
    {
        private const string tablaNombre = "Marcas";
        public MarcaDatos() : base(tablaNombre)
        {

        }

        public override string ToString()
        {
            return tablaNombre;
        }

    }
}