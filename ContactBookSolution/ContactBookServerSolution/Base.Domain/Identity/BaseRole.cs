﻿using Base.Contracts.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Identity
{
    

    public class BaseRole : BaseRole<Guid>, IDomainEntityId
    {
        public BaseRole()
        {
        }

        public BaseRole(string roleName) : base(roleName)
        {
        }
    }

    public class BaseRole<TKey> : IdentityRole<TKey>, IDomainEntityId<TKey>
        where TKey : IEquatable<TKey>
    {
        public BaseRole()
        {
        }

        public BaseRole(string roleName) : base(roleName)
        {
        }

        /// <summary>
        /// Flag to indicate that this Role has been deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
