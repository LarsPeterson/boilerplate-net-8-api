using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;

namespace Application.Queries.GetProviderById;

public record GetProviderByIdQuery(Guid Id) : IRequest<Provider>;