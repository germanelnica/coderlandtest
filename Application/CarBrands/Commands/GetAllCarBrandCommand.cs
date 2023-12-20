﻿using Application.DtoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CarBrands.Commands
{
    public record GetAllCarBrandCommand : IRequest<IEnumerable<CarBrandDto>>;
}