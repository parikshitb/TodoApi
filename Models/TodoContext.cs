using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
	public class TodoContext : DbContext
	{
		//Override the OnConfiguring(DbContextOptionsBuilder) method
		//OR
		//DbContextOptionsBuilder<TContext> (or DbContextOptionsBuilder)
		//OR
		//externally create an instance of DbContextOptions<TContext> (or DbContextOptions)
        //and pass it to a base constructor of DbContext
		public TodoContext(DbContextOptions<TodoContext> contextOptions) : base(contextOptions)
		{
		}

		//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
		public DbSet<TodoItem> TodoItems { get; set; } = null!;

		
    }
}

