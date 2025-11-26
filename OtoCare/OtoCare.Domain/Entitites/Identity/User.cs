using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoCare.Domain.Entities 
{
    public class User
    {
        public int Id { get; set; }

        // "string.Empty" atayarak "null" uyarısı almayı engelliyoruz.
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; } // ? koyman güzel, e-posta zorunlu olmayabilir

        // Rol İlişkisi
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!; // Role nesnesi veritabanından dolacak

        // Personel İlişkisi (Opsiyonel olabilir, çünkü her kullanıcı personel olmayabilir)
        public int? EmployeeId { get; set; }
        public Employee? EmployeeProfile { get; set; }
    }
}