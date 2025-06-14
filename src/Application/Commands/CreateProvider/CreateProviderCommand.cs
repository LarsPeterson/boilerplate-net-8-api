﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;

namespace Application.Commands.CreateProvider;

public record CreateProviderCommand(string name, string fye, string fyb) : IRequest<Guid>;