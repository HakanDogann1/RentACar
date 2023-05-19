using Microsoft.AspNetCore.Identity;

namespace RentACar.PresentetionLayer.Models
{
    public class CustomeIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola da en az 1 adet büyük harf olmalıdır ."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola da en az 1 adet küçük harf olmalıdır."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 karakter içermelidir."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Parola en az 6 karakterden oluşmalıdır."
            };
        }
    }
}
