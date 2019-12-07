// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.InMemory
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Models.Tests
{
    [TestClass]
    public class ArticleRepositoryTest
    {
        [TestMethod]
        public async Task ArticleRepositoryAllMethodTest()
        {
            // DbContextOptions<T> Object Creation
            var options = new DbContextOptionsBuilder<ArticleAppDbContext>()
                .UseInMemoryDatabase(databaseName: "ArticleApp").Options;
                //.UseSqlServer("server=(localdb)\\mssqllocaldb;database=ArticleApp;integrated security=true;").Options;

            // AddAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                // Repository Object Creation
                var repository = new ArticleRepository(context);
                var model = new Article { Title = "[1] 게시판 시작", Created = DateTime.Now };
                await repository.AddArticleAsync(model);
                await context.SaveChangesAsync();
            }
            using (var context = new ArticleAppDbContext(options))
            {
                Assert.AreEqual(1, await context.Articles.CountAsync());
                var model = await context.Articles.Where(m => m.Id == 1).SingleOrDefaultAsync();
                Assert.AreEqual("[1] 게시판 시작", model?.Title); 
            }

            // GetAllAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                //// 트랜잭션 관련 코드는 InMemoryDatabase 공급자에서는 지원 X
                ////using (var transaction = context.Database.BeginTransaction()) { transaction.Commit(); }
                var repository = new ArticleRepository(context);
                var model = new Article { Title = "[2] 게시판 가동", Created = DateTime.Now };
                context.Articles.Add(model);
                await context.SaveChangesAsync(); //[1]
                context.Articles.Add(new Article { Title = "[3] 게시판 중지", Created = DateTime.Now });
                await context.SaveChangesAsync(); //[2]
            }
            using (var context = new ArticleAppDbContext(options))
            {
                var repository = new ArticleRepository(context);
                var models = await repository.GetArticlesAsync(); 
                Assert.AreEqual(3, models.Count);
            }

            // GetByIdAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                // Empty
            }
            using (var context = new ArticleAppDbContext(options))
            {
                var repository = new ArticleRepository(context);
                var model = await repository.GetArticleByIdAsync(2);
                Assert.IsTrue(model.Title.Contains("가동"));
                Assert.AreEqual("[2] 게시판 가동", model.Title);
            }

            // GetEditAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                // Empty
            }
            using (var context = new ArticleAppDbContext(options))
            {
                var repository = new ArticleRepository(context);
                var model = await repository.GetArticleByIdAsync(2);
                model.Title = "[2] 게시판 바쁨";
                await repository.EditArticleAsync(model);
                await context.SaveChangesAsync();

                Assert.AreEqual("[2] 게시판 바쁨",
                    (await context.Articles.Where(m => m.Id == 2).SingleOrDefaultAsync()).Title);
            }

            // GetDeleteAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                // Empty
            }
            using (var context = new ArticleAppDbContext(options))
            {
                var repository = new ArticleRepository(context);
                await repository.DeleteArticleAsync(2);
                await context.SaveChangesAsync();

                Assert.AreEqual(2, await context.Articles.CountAsync());
                Assert.IsNull(await repository.GetArticleByIdAsync(2));
            }

            // PagingAsync() Method Test
            using (var context = new ArticleAppDbContext(options))
            {
                // Empty
            }
            using (var context = new ArticleAppDbContext(options))
            {
                int pageIndex = 0;
                int pageSize = 1;

                var repository = new ArticleRepository(context);
                var models = await repository.GetAllAsync(pageIndex, pageSize);

                Assert.AreEqual("[3] 게시판 중지", models.Records.FirstOrDefault().Title);
                Assert.AreEqual(2, models.TotalRecords); 
            }
        }
    }
}