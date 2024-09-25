using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    [Serializable]
    public class Member
    {
        public Guid MemberID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }

        public override string ToString()
        {
            StringBuilder strMember = new StringBuilder();
            strMember.Append($"Member ID : {MemberID}\n" +
                $"Member Full Name : {FirstName} {LastName}\n" +
                $"Member Age : {Age}");
            //Console.WriteLine(strMember.ToString());
            return strMember.ToString();
        }
    }
}
