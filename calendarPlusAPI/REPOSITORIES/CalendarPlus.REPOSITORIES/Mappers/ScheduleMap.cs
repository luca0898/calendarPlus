﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CalendarPlus.PRODUCT.Entities;

namespace CalendarPlus.Db.SQL.Mappers
{
    public class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                .HasKey(prop => prop.Id);

            builder
                .Property(prop => prop.Deleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .Property(prop => prop.Date)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder
                .Property(prop => prop.ProcedurePerformed)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}