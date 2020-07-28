using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TBC_API.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum City
    {
        Tbilisi,
        Batumi,
        Rustavi,
        Telavi
    }
    public enum PhoneType
    {
        Mobile,
        Home,
        Office
    }

    public class PPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string IDNunmber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public City City { get; set; }
        public PhoneType PhoneType { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
