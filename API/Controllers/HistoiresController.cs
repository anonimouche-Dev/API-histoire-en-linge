using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public record Histoire(int Id, string Titre, string Contenu);

    [ApiController]
    [Route("[controller]")]
    public class HistoiresController : ControllerBase
    {
        private static readonly IReadOnlyList<Histoire> Histoires = new List<Histoire>{
            new(Id: 1,
                Titre: "Le Gâteau",
                Contenu: "histoire 1\r\nalerte alerte \r\nau voleuron ma volé un gateau\r\nun(e) hero  apparu\r\nle nom(e) de ce hero était {nomHero}\r\nils ratrapérent le banditle boulanger dit merci  nomHero ils \r\nretrouvers les gateau le mangérent \r\nMIAM Miam dit  nomHero"
                ),
            new(Id: 2,
                Titre: "Le chien abandonné",
                Contenu: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ante quam, auctor eget efficitur vel, tristique ac ligula. Suspendisse feugiat porta rutrum. Vestibulum tempor vestibulum ullamcorper. Curabitur viverra orci vel sapien imperdiet, non condimentum lorem euismod. Phasellus ullamcorper massa ut finibus vehicula. Proin rhoncus ac nulla et mattis. Sed imperdiet dignissim odio, non sodales purus iaculis nec. Curabitur id lacus in leo maximus condimentum ullamcorper eu sem. Vivamus a luctus tellus. Etiam fermentum, mi sed egestas ornare, augue felis mattis neque, nec porta leo massa id justo. Phasellus ac justo eu purus vehicula mattis ac non ligula. "
                ),
            new(Id: 3,
                Titre: "le phenix",
                Contenu: "Suspendisse est velit, convallis ut tempus vitae, congue sed dui. Donec erat dolor, sollicitudin ut enim quis, molestie finibus sem. Vivamus id velit imperdiet, scelerisque turpis at, tincidunt turpis. Suspendisse ut mauris dapibus, aliquam neque vitae, porta lectus. Etiam eget tempor odio. Fusce sit amet aliquet metus. Vivamus a tellus feugiat, blandit sem vitae, semper quam. Integer pellentesque blandit leo id malesuada. Donec urna leo, facilisis vitae elit vitae, molestie sagittis nulla. Aliquam elementum lobortis lobortis. Sed in euismod sem."
                ),
        };

        private readonly ILogger<HistoiresController> _logger;

        public HistoiresController(ILogger<HistoiresController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "HistoiresController")]
        public IEnumerable<Histoire> Get()
        {
            return Histoires;            
        }
    }
}