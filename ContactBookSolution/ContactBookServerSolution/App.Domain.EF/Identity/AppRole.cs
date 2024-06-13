using Base.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.EF.Identity
{
    public class AppRole: BaseRole
    {
        [MinLength(1)]
        [MaxLength(128)]
        public string DisplayName { get; set; } = default!;
    }
}

