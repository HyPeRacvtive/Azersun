using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class MessageValidator : AbstractValidator<Messages>
    {
        public MessageValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen Adınızı Yazınız");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen Soy Adınızı Yazınız");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Lütfen Telefon Numaranızı Yazınız");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen Mail Adresinizi Yazınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen Konuyu Yazınız");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen Mesajınızı Yazınız");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Lütfen Adınızı Doğru Biçimde Giriniz (En Az 2 Karakter)");
            RuleFor(x => x.LastName).MaximumLength(20).WithMessage("Lütfen Adınızı Doğru Biçimde Giriniz(En Fazla 20 Karakter)");
            RuleFor(x => x.Phone).MinimumLength(10).WithMessage("Lütfen Telefon Numaranızı Doğru Biçimde Giriniz (En Az 10 Karakter)");
            RuleFor(x => x.Phone).MaximumLength(11).WithMessage("Lütfen Telefon Numaranızı Doğru Biçimde Giriniz(En Fazla 11 Karakter)");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen Konuyu Doğru Biçimde Giriniz (En Az 5 Karakter)");
            RuleFor(x => x.Subject).MaximumLength(10).WithMessage("Lütfen Konuyu Doğru Biçimde Giriniz(En Fazla 20 Karakter)");
            RuleFor(x => x.Message).MinimumLength(20).WithMessage("Lütfen Mesajınızı Doğru Biçimde Giriniz (En Az 20 Karakter)");

        }
    }
}
