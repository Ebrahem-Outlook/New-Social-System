﻿using FluentValidation;

namespace Social.Application.Users.Commands.UpdatePassword;

internal sealed class UpdatePasswordCommandValidator : AbstractValidator<UpdatePasswordCommand>
{
    public UpdatePasswordCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty...");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithMessage("Password can't be null or empty...");
    }
}