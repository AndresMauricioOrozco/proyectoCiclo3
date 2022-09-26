using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Taller.App.Front.Pages
{
    public class registrarMecanicoModel : PageModel
    {
        public void OnGet()
        {
            ObtenerMecanico();
        }

        public void OnPostAdd(Mecanico mecanico){
            repositorio.AgregarMecanico(mecanico);
            this.ObtenerMecanicos();
        }
    }
}
