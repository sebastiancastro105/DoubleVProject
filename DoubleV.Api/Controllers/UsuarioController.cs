namespace DoubleV.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext Context;

        public UsuarioController(AppDbContext context)
        {
            Context = context;
        }
        [HttpPost("obtenerusuario")]
        public async Task<string> ObtenerUsuario(Usuario usuario)
        {
            var user = await Context.Usuarios.FirstOrDefaultAsync(x => x.User == usuario.User && x.Pass == usuario.Pass);
            if (user == null)
                return "Usuario no existe";
            else
                return $"El usuario {user.User} existe";
        }

        [HttpPost]
        public async Task GuardarUsuario(Usuario usuario)
        {
            await Context.Usuarios.AddAsync(usuario);
            await Context.SaveChangesAsync();
        }
    }
}
