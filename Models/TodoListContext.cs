using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Latihan1_graphql.Models;
#nullable disable

namespace Latihan1_graphql.Models
{
  public partial class TodoListContext : DbContext
  {
    public TodoListContext()
    {
    }

    public TodoListContext(DbContextOptions<TodoListContext> options)
        : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }

  }
}
