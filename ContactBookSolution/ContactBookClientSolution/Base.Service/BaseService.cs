using Base.Contracts.Domain;
using Base.Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace Base.Service
{
    public class BaseService<TEntity>
    where TEntity : class, IDomainEntityId<Guid>

    {
        private HttpClient _client; 
        public BaseService(TEntity entity, HttpClient client)
        {
            _client = client;
        }
    }
    public class BaseService<TEntity, TKey> :
    IBaseService<TEntity, TKey>
    where TEntity : class, IDomainEntityId<TKey>
    where TKey : IEquatable<TKey>

    {
        private HttpClient _client;

        public BaseService(HttpClient client)
        {
            _client = client;
        }

        public IEnumerable<TEntity?>? GetAll()
        {
            return (IEnumerable<TEntity?>?)_client.GetFromJsonAsync<TEntity?>($"{_client.BaseAddress}"); 
        }

        public async Task<IEnumerable<TEntity?>>? GetAllAsync()
        {
            return (IEnumerable<TEntity?>)await _client.GetFromJsonAsync<TEntity?>($"{_client.BaseAddress}");
        }
    }
    }
