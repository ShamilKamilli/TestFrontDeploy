using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Data
{
    [Table("TestUsers")]
    public class User : IdentityUser<int>, IAuditableEntity
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DocumentSeria { get; set; }
        public string DocumentNumber { get; set; }
        public string Citizenship { get; set; }
        public string RegistrationAddress { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsLockedOut => this.LockoutEnabled && this.LockoutEnd >= DateTimeOffset.UtcNow;
        public UserType UserType { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsActiveDirectoryUser { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual ICollection<IdentityUserRole<int>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<int>> Claims { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokenUser { get; set; }
    }
}
