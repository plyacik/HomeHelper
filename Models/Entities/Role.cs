using Microsoft.AspNetCore.Identity;
using Models.Interfaces;
using System;

namespace Models.Entities
{
    public partial class Role : IdentityRole<int>, IEntity<int>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
