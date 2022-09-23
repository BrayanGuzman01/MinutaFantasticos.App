using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public interface IRepositorioResidente
    {
        IEnumerable<Residentes> GetAllResidente();
        Residentes GetResidenteId(int ResidenteID);
        Residentes UpdateResidente(Residentes ResidentesEditar);
        Residentes AddResidente(Residentes ResidentesAgregar);
        void DeleteResidente(int IDresidente);   
    }
}