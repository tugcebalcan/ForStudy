using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using ForStudy.Entities.Products;
using ForStudy.Entities.Stores;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ForStudy.Data.ApplicationDb
{
   public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {    
            //
            optionsBuilder.UseSqlServer(@"Data Source =.; Integrated Security = True; Initial Catalog=FS;");
            optionsBuilder.UseLazyLoadingProxies().ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CategoryLang>().HasOne<Category>(x => x.Category).WithMany(x => x.CategoryLangs).HasForeignKey(fk => fk.CategoryId);
            builder.Entity<TagLang>().HasOne<Tag>(x => x.Tag).WithMany(x => x.TagLangs).HasForeignKey(fk => fk.TagId);

            builder.Entity<BlogCategory>().HasKey(x => new { x.BlogId, x.CategoryLangId });
            builder.Entity<BlogTag>().HasKey(x => new { x.BlogId, x.TagLangId });

            builder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryLangId });
            builder.Entity<ProductTag>().HasKey(x => new { x.ProductId, x.TagLangId });
            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogLang> BlogLangs { get; set; }
        public DbSet<BlogPhoto> BlogPhotos { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryLang> CategoryLangs { get; set; }
        public DbSet<Lang> Langs { get; set; }
        public DbSet<Seo> Seos { get; set; }
        public DbSet<SeoLang> SeoLangs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagLang> TagLangs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetailLang> ProductDetailLangs { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }


        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreProduct> StoreProducts { get; set; }

    }
}
