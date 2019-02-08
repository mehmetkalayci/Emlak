using FluentValidation;


public class ContractValidator : AbstractValidator<Emlak.Model.Contract>
{
    public ContractValidator()
    {
        RuleFor(c => c.Neighborhood).NotNull().WithMessage("Mahalle bilgisini girin");
        RuleFor(c => c.Street).NotNull().WithMessage("Sokak bilgisini girin");
        RuleFor(c => c.Apartment).NotNull().WithMessage("Daire bilgisini girin");
        RuleFor(c => c.City).NotNull().WithMessage("İl bilgisini girin");
        RuleFor(c => c.Town).NotNull().WithMessage("İlçe bilgisini girin");
        RuleFor(c => c.RealtyType).NotNull().WithMessage("Gayrimenkul tipi bilgisini girin");
        RuleFor(c => c.RealtyDefinition).NotNull().WithMessage("Gayrimenkul tanım bilgisini girin");
        RuleFor(c => c.CurrentSituationOfRealEstate).NotNull().WithMessage("Gayrimenkul tipi bilgisini girin");
        RuleFor(c => c.AimOfRent).NotNull().WithMessage("Ne için kullanılacağını bilgisini girin");
        RuleFor(c => c.StartingDate).NotNull().WithMessage("Kira başlangıç tarihi bilgisini girin");
        RuleFor(c => c.EndingDate).NotNull().WithMessage("Kira bitiş tarihi bilgisini girin");
        RuleFor(c => c.Tenancy).NotNull().WithMessage("Kira müddeti bilgisini girin");
        RuleFor(c => c.RentMoneyInMonth).NotNull().WithMessage("Aylık kira bilgisini girin");
        RuleFor(c => c.RentMoneyTotal).NotNull().WithMessage("Toplam kira bilgisini girin");
        RuleFor(c => c.PaymentType).NotNull().WithMessage("Ne şekilde ödeneceği bilgisini girin");
        RuleFor(c => c.PaymentDay).NotNull().WithMessage("Ödeme günü bilgisini girin");

        RuleFor(c => c.LandlordFullName).NotNull().WithMessage("Ev sahibi ad soyad bilgisini girin");
        RuleFor(c => c.LandlordPhone).NotNull().WithMessage("Ev sahibi telefon bilgisini girin");





    }
}

public class ContractPartiesValidator : AbstractValidator<Emlak.Model.ContractParties>
{
    public ContractPartiesValidator()
    {
        RuleFor(cp => cp.PersonId).NotNull().WithMessage("Taraf seçin");
    }
}