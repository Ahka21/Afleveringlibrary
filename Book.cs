using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace afleveringlibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Price { get; set; }



        public void validationTitle()
        {
            if (Title == null)
                throw new ArgumentException("Name is null");
            if (Title.Length < 3)
                throw new ArgumentException("Name must be at least 3 character: " + Title);
        }
        public void validationPrice()
        {
            if (Price < 0 || Price > 1200)
            throw new ArgumentException("The price should be greater than 0 and less than 1200." + Price);
        }
        public void validate()
        {
            validationTitle();
            validationPrice();
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Title)}={Title}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}
