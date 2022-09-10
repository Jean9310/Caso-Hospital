using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;


namespace Hospitalizacion.App.Frontend.Pages
{
    public class AuxiliarAdmin : PageModel
    {
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        
        public IEnumerable<Auxiliar> Aux{get; set;}

        public AuxiliarAdmin()
        {

        }

        public void OnGet()
        {
          this.Aux =_repositorioAuxiliar.GetAllAuxiliar();
        }
    }
}
