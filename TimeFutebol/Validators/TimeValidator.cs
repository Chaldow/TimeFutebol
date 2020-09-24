using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeFutebol.Models;

namespace TimeFutebol.Validators
{
    public class TimeValidator : AbstractValidator<Time> { 
        public TimeValidator() 
    {
            RuleFor(p => p.nome)
                .NotEmpty().WithMessage("Nome Obrigatório")
                .NotNull().WithMessage("Nome Obrigatório")
                .MinimumLength(3).WithMessage("Nome no minimo de 3 caracteres")
                .MaximumLength(50).WithMessage("Nome no maximo com 50 caracteres");
    }

}

}
