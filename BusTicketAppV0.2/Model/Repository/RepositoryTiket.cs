using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Context;

namespace BusTicketAppV0._2.Model.Repository
{
    public class RepositoryTiket
    {
        private SQLiteConnection _conn;
        public RepositoryTiket(DbContext context)
        {
            _conn = context.Conn;
        }
        
    }
}
