

using Latihan1_graphql.Models;

namespace Latihan1_graphql
{
  public class AddTodoPayload
  {
    public AddTodoPayload(Todo todo)
    {
      Todo = todo;
    }

    public Todo Todo { get; }
  }
}