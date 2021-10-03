﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SportsBetConfiguration : IEntityTypeConfiguration<SportsBet>
    {
        public void Configure(EntityTypeBuilder<SportsBet> entitybuilder)
        {
            entitybuilder.HasKey(s => s.BetId);
        }
    }
}
