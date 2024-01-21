using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Portfolio.NewFolder;


namespace Portfolio.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ValidAzure")]
    public class PortfolioController : ControllerBase
    {
        private static List<PortfolioList> heroes = new List<PortfolioList>
        {
            new PortfolioList
            {
                ProjektName ="BankApp", Link = "https://github.com/CarlVictorGrimschold/GrimscholdsBank", Stack= "C#",
                Datum="2023-05-25", Beskrivning="Appen är utvecklad i C# och är under vidareutveckling"},
            new PortfolioList
            {
                ProjektName ="Webbshopen", Link = "https://github.com/CarlVictorGrimschold/Webbshoppen-Victor", Stack= "HTML,Javascript,CSS",
                Datum="2023-03-01", Beskrivning="En webbshop utvecklad med React där HTML, Javascript används, och Metoden SaSS för reglera CSS"},
            new PortfolioList
            {
                ProjektName ="", Link = "https://github.com/CarlVictorGrimschold/2023PorfolioVictor", Stack= "HTML,Javascript,CSS,C#",
                Datum="2023-06-18", Beskrivning="En hemsida som hanterar ett portfolio innehållandes ett kontaktformulör api"},
            new PortfolioList
            {
                ProjektName ="HotellApp", Link = "https://github.com/CarlVictorGrimschold/VictorHotell2023", Stack= "C#",
                Datum="2023-01-04", Beskrivning="En consolapp som hantera bokningar skriven med C#"},
        };

        [HttpGet]
        public async Task<ActionResult<List<PortfolioList>>> GetAll()
        {
            return Ok(heroes);
        }
    }
}
