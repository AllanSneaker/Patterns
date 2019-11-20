
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailCreator.CreateEmailFrom("emailFrom@test.com")
                .To("toMail@test.com")
                .CC("ccMail@test.com")
                .BCC("bccMail@test.com")
                .WithSubject("Some subject")
                .WithBody("Some body")
                .Send();
        }
    }
}
