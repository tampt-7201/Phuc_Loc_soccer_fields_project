namespace app.Models
{
    public class Gridiron
    {
        public int Id { get; set; }
        public string FieldName { get; set; }

        public int Capacity { get; set; }
        public int TypeGridironId { get; set; }
        public TypeGridiron TypeGridiron { get; set; }
        public ICollection<ImageGridiron> ImageGridirons { get; set; }
        public ICollection<UserBookingGridiron> UserBookingGridirons { get; set; }
    }
}
