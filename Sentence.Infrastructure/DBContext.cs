using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sentence.Domain;
using Sentence.Domain.Entities;

namespace Sentence.Infrastructure
{
	public class DBContext : DbContext
    {
		public DBContext(DbContextOptions<DBContext> options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Sentence>()
                .HasMany(s => s.WordsList);

            
            modelBuilder
            .Entity<Word>()
            .Property(e => e.WordTypeId)
            .HasConversion<int>();

            modelBuilder
            .Entity<WordType>()
            .Property(e => e.WordTypeId)
            .HasConversion<int>();

            modelBuilder
            .Entity<WordType>().HasData(
                Enum.GetValues(typeof(WordTypeId))
                    .Cast<WordTypeId>()
                    .Select(e => new WordType()
                    {
                        WordTypeId = e,
                        Name = e.ToString()
                    })
            );

        }

        public DbSet<WordType> WordTypes { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Domain.Entities.Sentence> Sentences { get; set; }
    }
}

