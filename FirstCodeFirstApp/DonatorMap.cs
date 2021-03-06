﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{
    public class DonatorMap : EntityTypeConfiguration<Donator>
    {
        public DonatorMap()
        {
            //ToTable("DonatorFromConfig");//为了区分之前的结果
            //Property(m => m.Name)
            //    .IsRequired()//将Name设置为必须的
            //    .HasColumnName("DonatorName");//为了区别之前的结果，将Name映射到数据表的DonatorName
            ToTable("Donators");//为了区分之前的结果
            Property(m => m.Name)
                .IsRequired()   //将Name设置为必须的
                .HasColumnName("DonatorName");


            HasMany(d => d.PayWays)
            .WithRequired()
            .HasForeignKey(p => p.DonatorId);

        }
    }
}
