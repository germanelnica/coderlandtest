using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.CarBrands.Commands;

namespace mydockerapi.Controllers
{
    public class CarBrandController : Controller
    {
        private readonly IMediator _mediator;
        public CarBrandController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> Get()
            => Ok(await _mediator.Send(new GetAllCarBrandCommand()));

    }
}
