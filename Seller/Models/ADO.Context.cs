﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Seller.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities8 : DbContext
{
    public Entities8()
        : base("name=Entities8")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Users> Users1 { get; set; }

    public virtual DbSet<Bil> Bils { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

}

}

