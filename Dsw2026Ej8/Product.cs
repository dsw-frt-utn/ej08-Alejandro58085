using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string description_;
        public Product(string description_)
        {
            this.description_ = description_;
        }
        public void SetDescription(string newDescription)
        {
            description_ = newDescription;
        }

    }
}
