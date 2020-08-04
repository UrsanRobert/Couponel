﻿using Couponel.Entities.Coupons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Couponel.Persistence.Configurations
{
    public class RedeemedCouponEntityConfiguration : IEntityTypeConfiguration<RedeemedCoupon>
    {
        public void Configure(EntityTypeBuilder<RedeemedCoupon> redeemedCouponConfiguration)
        {
            redeemedCouponConfiguration
                    .HasOne<Coupon>(redeemedCoupon => redeemedCoupon.Coupon)
                    .WithOne()
                    .IsRequired(true)
                    .HasForeignKey<RedeemedCoupon>(redeemedCoupon => redeemedCoupon.CouponId)
                    .OnDelete(DeleteBehavior.NoAction);

            redeemedCouponConfiguration
                .Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedNever();
        }
    }
}