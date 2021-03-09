using FluentValidation;
using PedidosApp.Models;
using System;

namespace PedidosApp.Validator
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator()
        {
            RuleFor(c => c.Titulo).Must(n => ValidateStringEmpty(n)).WithMessage("o nome não pode ser vazio");
            RuleFor(c => c.Link).Must(n => ValidateStringEmpty(n)).WithMessage("o link não pode ser vazio");
            RuleFor(c => c.Preco).NotEmpty().WithMessage("Informe o preço").Must(PrecoMaiorQueZero).WithMessage("o valor deve ser maior que zero");
            RuleFor(c => c.Descricao).Must(n => ValidateStringEmpty(n)).WithMessage("o nome não pode ser vazio");
            RuleFor(c => c.Titulo).Must(n => ValidateStringEmpty(n)).WithMessage("a desrição não pode estar em branco");
        }

        private static bool PrecoMaiorQueZero(decimal preco)
        {
            return preco > 0;
        }

        bool ValidateStringEmpty(string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
                return true;
            return false;
        }
    }
}
