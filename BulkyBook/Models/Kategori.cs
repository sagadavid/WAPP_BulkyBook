namespace BulkyBook.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int displayorder { get; set; }
        public DateTime CreationTime { get; set; }= DateTime.Now;

    }
}
    