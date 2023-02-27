﻿namespace PokimonReviewApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokemonCategories> PokemonCategories { get; set; }
    }
}
