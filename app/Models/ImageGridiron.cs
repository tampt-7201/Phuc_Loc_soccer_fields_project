namespace app.Models
{
    public class ImageGridiron
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int GridironId { get; set; }
        public Gridiron Gridiron { get; set; }
    }
}
