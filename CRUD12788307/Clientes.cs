using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CRUD12788307
{
    [SQLite.Table("cliente")]
    public class Clientes
    {
        [PrimaryKey]
        [AutoIncrement]
        [SQLite.Column("id")]

        public int Id { get; set; }
        [SQLite.Column("nombrecliente")]
        public string? NombreCliente { get; set; }
        [SQLite.Column("movil")]
        public string? Movil { get; set; }
        [SQLite.Column("email")]

        public string? Email { get; set; }


    }
}
