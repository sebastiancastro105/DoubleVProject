namespace DoubleV.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController:ControllerBase
    {
        private readonly AppDbContext Context;

        public PersonaController(AppDbContext context)
        {
            Context = context;
        }
        [HttpPost]
        public async Task GuardarPersona(Persona persona)
        {
            await Context.Personas.AddAsync(persona);
            await Context.SaveChangesAsync();
        }
    }
}
