using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class MedicoAdminModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<Medico> Med{get; set;}

        public MedicoAdminModel()
        {

        }

        public void OnGet()
        {
          this.Med =_repositorioMedico.GetAllMedico();
        }
    }
}
