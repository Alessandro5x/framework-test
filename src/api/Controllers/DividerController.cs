namespace api.Controllers
{
    using System.Collections.Generic;
    using domain.Entidades;
    using domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class DividerController : ControllerBase
    {
        private readonly IDividerService _dividerService;

        public DividerController(IDividerService dividerService)
        {
            _dividerService = dividerService;
        }

        [HttpGet("{number}/{prime}", nameof = "Get")]
        public ActionResult<IList<long>> Get(int number, bool prime)
        {
            Divider divider = new Divider
            {
                Number = number,
                Prime = prime,
            };

            var result = _dividerService.CalculateDivider(divider);

            if (result.Ok)
            {
                return Ok(result.Dividers);
            }
            else
            {
                return BadRequest(result.Error);
            }
        
        }

    }
}