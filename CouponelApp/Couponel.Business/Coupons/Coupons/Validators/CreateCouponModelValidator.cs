﻿using Couponel.Business.Coupons.Coupons.Models.CouponsModels;
using FluentValidation;

namespace Couponel.Business.Coupons.Coupons.Validators
{
    public class CreateCouponModelValidator : AbstractValidator<CreateCouponModel>
    {
        public CreateCouponModelValidator()
        {
            RuleFor(coupon => coupon.Name)
                .NotNull()
                .NotEmpty();
            RuleFor(coupon => coupon.Description)
                .NotEmpty();
        }
    }
}
