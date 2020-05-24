using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace GunShopBackend.Models
{
    public class Caliber
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Caliber(string title)
        {
            Id = 1;
            Title = title;
        }
    }
}
