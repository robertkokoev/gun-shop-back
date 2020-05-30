using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;

namespace GunShopBackend.Models
{
    public class Caliber
    {
        [Key]
        public string Title { get; set; }

        public Caliber(string title)
        {
            Title = title;
        }
    }
}
