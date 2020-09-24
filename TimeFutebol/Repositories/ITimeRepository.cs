using TimeFutebol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Repositories
{
    public interface ITimeRepository
    {
        public IList<Time> ListarTodosTimes();

        public Time BuscarTimePorId(int id);

        public void InserirTime(Time timao);
    }
    
}
