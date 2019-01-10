using System.Data.Entity;

namespace UdemyTestProject.Fundamentals
{
    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}