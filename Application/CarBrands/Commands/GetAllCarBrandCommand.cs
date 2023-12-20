using Application.DtoModels;
using MediatR;

namespace Application.CarBrands.Commands
{
    public record GetAllCarBrandCommand : IRequest<bool>;
}
