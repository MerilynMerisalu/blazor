using Base.Contracts.Domain;
using Base.Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace Base.Service
{

    public abstract class BaseService<TEntity, TKey> : MVCBaseService, IBaseEntityService<TEntity, TKey>
        where TEntity : class
        where TKey : IEquatable<TKey>
    {
        protected BaseService(HttpClient client) : base(client)
        {
        }

        public async Task<IEnumerable<TEntity?>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<IEnumerable<TEntity?>?>(GetEndpointUrl());
        }
    }
}



