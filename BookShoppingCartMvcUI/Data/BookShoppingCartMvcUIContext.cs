using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShoppingCartMvcUI.Models;

namespace BookShoppingCartMvcUI.Data
{
    public class BookShoppingCartMvcUIContext : DbContext
    {
        public BookShoppingCartMvcUIContext (DbContextOptions<BookShoppingCartMvcUIContext> options)
            : base(options)
        {
        }

        public DbSet<BookShoppingCartMvcUI.Models.Book> Book { get; set; } = default!;
    }
}
