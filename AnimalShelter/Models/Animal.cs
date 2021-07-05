namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public bool SpayedOrNeutered { get; set; }
        public float Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
    }
}
