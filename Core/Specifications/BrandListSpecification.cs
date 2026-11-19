using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications
{
    public class BrandListSpecification : BaseSpecification<Product, string>
    {
        public BrandListSpecification() : base(p => true)
        {
            AddSelect(p => p.Brand);
            ApplyDistinct();
        }      
    }
}
