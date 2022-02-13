using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            //RuleFor(x => x.ProductImage).NotEmpty().WithMessage("Lütfen Ürün Resmi Ekleyiniz");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Lütfen Stok Bilgisi Ekleyiniz");

        }
    }
}
