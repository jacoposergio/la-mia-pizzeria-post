using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Devi inserire un nome")]
        
        public string Name { get; set; }
        [Column(TypeName = "Text")]
        [Required(ErrorMessage = "Devi inserire una descrizione")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Devi inserire un prezzo")]

        
        public double Price { get; set; }
        [Required(ErrorMessage = "Devi inserire un Url di un'immagine")]
        public string Image { get; set; }

        public Pizza()
        {

        }
        public Pizza(string name, string description, double price, string image)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Image = image;
        }

    }



   
}
