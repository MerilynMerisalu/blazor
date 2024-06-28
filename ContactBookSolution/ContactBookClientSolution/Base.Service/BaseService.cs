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

        public async Task<TEntity> CreateEntityAsync(TEntity entity)
        {
            var res = await _client.PostAsJsonAsync<TEntity>(GetEndpointUrl(), entity);
            return await res.Content.ReadFromJsonAsync<TEntity>();
        }

        public async Task DeleteEntityByIdAsync(Guid id)
        {
           var sc = await _client.DeleteAsync(GetEndpointUrl() + id);
           if (sc.IsSuccessStatusCode == false)
            {
                var message = await sc.Content.ReadAsStringAsync();
                throw new Exception(message);
            }
            

        }

        public async Task<IEnumerable<TEntity?>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<IEnumerable<TEntity?>?>(GetEndpointUrl());
        }

        public async Task<TEntity?> GetEntityByIdAsync(Guid id)
        {
            return await _client.GetFromJsonAsync<TEntity?>(GetEndpointUrl() + id);
        }

        public async Task UpdateEntity(Guid id,TEntity entity )
        {
            await _client.PutAsJsonAsync<TEntity>(GetEndpointUrl() + id, entity);
            
        }

        
    }
}



