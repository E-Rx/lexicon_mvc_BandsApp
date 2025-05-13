
namespace BandsApp.Web.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string VideoUrl { get; set; } = null!;
        public string[] Albums { get; set; } = null!;
    }
}
