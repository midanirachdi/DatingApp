
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models.Dtos;

namespace DatingApp.API.Models.Validators
{
    public class UserForRegisterDtoValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterDtoValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("The Username field is required");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("The Password field is required")
                .Length(4,8)
                .WithMessage("You must specify a password between 4 and 8 characters");

        }
    }
}
