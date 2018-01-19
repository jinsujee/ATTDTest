using System;
using System.Collections.Generic;
using System.Text;
using umayplusapi.Contexts;
using umayplusapi.Models;

namespace api.Unittest
{
    public class StubMemberContext : IMemberContext
    {
        public Member FindMember(string umaplusCardID, string personalCardID)
        {
            return new Member()
            {
                UmayplusCardID = "6273885053341539",
                PersonalCardID = "3100505143401",
                BirthDate = "01/01/2530",
                MobilePhone = "092224955",
                FirstName = "Jinsujee",
                LastName = "Meejaroen"
            };
        }
    }
}
