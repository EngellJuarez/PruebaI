using PepitoSchoolApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchooolApp.Application.Interfaces
{
    public interface IEstudianteService : IService<Estudiante>
    {
        Estudiante FindById(int id);
    }
}
