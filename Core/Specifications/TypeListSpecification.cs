using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications
{
    public class TypeListSpecification : BaseSpecification<Product, string>
    {
        public TypeListSpecification() : base(p => true)
        {
            AddSelect(p => p.Type);
            ApplyDistinct();
        }    
    }
}
