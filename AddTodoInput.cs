using System;

namespace Latihan1_graphql
{
  public record AddTodoInput(
      string Task,
      bool Completed
  );
}