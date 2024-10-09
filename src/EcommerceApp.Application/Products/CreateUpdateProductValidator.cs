

using FluentValidation;

namespace EcommerceApp.Products
{
    public class CreateUpdateProductValidator : AbstractValidator<CreateUpdateProductDto>
    {
        public CreateUpdateProductValidator()
        {
            RuleFor(x => x.NameAr)
                .NotEmpty()
                .MaximumLength(EcommerceAppConsts.GeneralTextMaxlength)
                .WithErrorCode(EcommerceAppDomainErrorCodes.INVALID_PRODUCT_DATA_NAME_AR)
                .WithMessage("Product Name in Arabic is invalid");
            RuleFor(x => x.NameEn)
                .NotEmpty()
                .MaximumLength(EcommerceAppConsts.GeneralTextMaxlength)
                .WithErrorCode(EcommerceAppDomainErrorCodes.INVALID_PRODUCT_DATA_NAME_EN)
                .WithMessage("Product Name in English is invalid");
            RuleFor(x => x.DescriptionAr)
                .NotEmpty()
                .MaximumLength(EcommerceAppConsts.DescriptionTextMaxLength)
                .WithErrorCode(EcommerceAppDomainErrorCodes.INVALID_PRODUCT_DATA_DESC_AR)
                .WithMessage("Product Description in Arabic is invalid");
            RuleFor(x => x.DescriptionEn)
                .NotEmpty()
                .MaximumLength(EcommerceAppConsts.DescriptionTextMaxLength)
                .WithErrorCode(EcommerceAppDomainErrorCodes.INVALID_PRODUCT_DATA_DESC_EN)
                .WithMessage("Product Description in English is invalid");
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithErrorCode(EcommerceAppDomainErrorCodes.INVALID_PRODUCT_CATEGORY)
                .WithMessage("Product Category is invalid");
        }
    }
}
