﻿using BlazorApp1.Module;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    
    
}