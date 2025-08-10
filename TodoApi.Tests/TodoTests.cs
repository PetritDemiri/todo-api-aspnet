using Xunit;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using System.Threading.Tasks;
using System.Linq;

namespace TodoApi.Tests;

public class TodoTests
{
    [Fact]
    public async Task CanAddTodoToInMemoryDb()
    {
        var options = new DbContextOptionsBuilder<TodoContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        using (var context = new TodoContext(options))
        {
            context.Todos.Add(new Todo { Title = "Test", IsComplete = false });
            await context.SaveChangesAsync();
        }

        using (var context = new TodoContext(options))
        {
            var list = await context.Todos.ToListAsync();
            Assert.Single(list);
            Assert.Equal("Test", list.First().Title);
        }
    }
}
