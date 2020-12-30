using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace WebApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext([NotNullAttribute] DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<TodoItemDTO> TodoItems { get; set; }
    }
}
