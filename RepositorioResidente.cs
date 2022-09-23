using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorio
{
    public class RepositorioResidente : IRepositorioResidente
    {
        private AppContext appContext1 = new AppContext();

        public Residentes AddResidente(Residentes ResidentesAgregar)
        {
            var AgregarResidente = appContext1.ResidentesDB.Add(ResidentesAgregar);
            appContext1.SaveChanges();
            return AgregarResidente.Entity;
        }

        public void DeleteResidente(int IDresidente)
        {
            var ResidenteEncontrado = appContext1.ResidentesDB.FirstOrDefault(e => e.Id == IDresidente);
            if(ResidenteEncontrado == null){
                return;
            }
            appContext1.ResidentesDB.Remove(ResidenteEncontrado);
            appContext1.SaveChanges();
        }

        
        public IEnumerable<Residentes> GetAllResidente()
         {
             return appContext1.ResidentesDB;
         }

         public Residentes GetResidenteId(int ResidenteID)
         {
             return appContext1.ResidentesDB.SingleOrDefault(a => a.Id == ResidenteID);
         }

        public Residentes UpdateResidente(Residentes ResidentesEditar)
        {
            var Datico = appContext1.ResidentesDB.SingleOrDefault(u => u.Id == ResidentesEditar.Id);
            if(Datico != null){
                Datico.Nombre = ResidentesEditar.Nombre;
                Datico.Apellido = ResidentesEditar.Apellido;
                Datico.NumeroTelefono = ResidentesEditar.NumeroTelefono;
                Datico.Apartamento = ResidentesEditar.Apartamento;

            }
            return Datico;
        }
    }
}