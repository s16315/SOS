using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class Instructor : User
    {
        public List<Language> Languages { get; set; }
    }
}