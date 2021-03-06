﻿using System;
using System.Runtime.Serialization;
using Hexapus.Invoice.Domain.Aggregates;
using MediatR;

namespace Hexapus.Invoice.Application.Commands
{ 
    public class UpdateProductCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public long SalePrice { get; set; }
        public Currency Currency { get; set; }
        public MeasurementUnit Unit { get; set; }
    }
}
