using Application.CarBrands.Commands;
using Application.DtoModels;
using Application.Interfaces;
using MediatR;

namespace Application.CarBrands.Handlers
{
    internal class GetAllCarBrandHandler : IRequestHandler<GetAllCarBrandCommand, IEnumerable<CarBrandDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCarBrandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CarBrandDto>> Handle(GetAllCarBrandCommand request, CancellationToken cancellationToken)
        {
            /// validating the request.
            _ = request ?? throw new ArgumentNullException(nameof(request));
            // get all records
            var carBrands = await _unitOfWork.CarBrand.GetAllAsync();
            // we can add automapper for this kind of mappings.
            return carBrands.Select(c => new CarBrandDto { Id = c.Id, Name = c.Name, Description = c.Description });
        }
    }
}
