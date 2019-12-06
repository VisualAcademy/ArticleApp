using Dul.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArticleApp.Models
{
    /// <summary>
    /// Repository Class: ADO.NET 또는 Dapper 또는 Entity Framework Core 
    /// </summary>
    public class ArticleRepository : IArticleRepository
    {
        public Task<Article> AddArticleAsync(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteArticleAsync(int i)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> EditArticleAsync(Article article)
        {
            throw new System.NotImplementedException();
        }

        public Task<PagingResult<Article>> GetAllAsync(int pageIndex, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public Task<Article> GetArticleByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Article>> GetArticlesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
