﻿using FluentValidation;
using WasteRecords.Core.Dtos.User;

namespace WasteRecords.Service.ValidationRules.FluentValidation
{
    public class SignInValidator : AbstractValidator<UserSignInDto>
    {
        public SignInValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("User email cannot be blank");
            RuleFor(x => x.Password).NotEmpty().WithMessage("User password cannot be blank");
        }
    }
}
