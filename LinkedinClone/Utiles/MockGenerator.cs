using Bogus;
using LinkedinClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.Utiles
{
    public static class MockGenerator
    {
        public static IEnumerable<Post> GeneratePosts(int number)
        {
            var rdm = new Random();
            var fake = new Faker<Post>()
                .RuleFor(m => m.UserName, f => f.Person.FullName)
                .RuleFor(m => m.UserProfil, f => f.Person.Avatar)
                .RuleFor(m => m.UserFunction, f => f.Person.Company.Name)
                .RuleFor(m => m.Details, f => f.Lorem.Paragraph())
                .RuleFor(m => m.PostPicture, f => f.Image.PicsumUrl())
                .RuleFor(m => m.PostLove, f => rdm.Next(0,20))
                .RuleFor(m => m.PostLike, f => rdm.Next(0, 20))
                .RuleFor(m => m.PostSupport, f => rdm.Next(0, 20))
                .RuleFor(m => m.PostClap, f => rdm.Next(0,20))
                .RuleFor(m => m.PostSmile, f => rdm.Next(0,20))
                .RuleFor(m => m.PostIdea, f => rdm.Next(0,20))
                .RuleFor(m => m.DateCreation, f => f.Date.Past(Random.Shared.Next(1, 5), DateTime.Now))
                ;

            var data = fake.Generate(number);
            return data;
        }
    }
}
