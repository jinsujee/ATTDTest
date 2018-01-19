using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umayplusapi.Models;
using umayplusapi.Contexts;

namespace umayplusapi.Services
{
    public class MemberService : IMemberService
    {
        private IMemberContext memberContext;
        public MemberService(IMemberContext membercontext)
        {
            this.memberContext = membercontext;
        }

        public Member getMemberInfo(string UmayplusCardID, string PersonalCardID, string BirthDate, string MobilePhone)
        {
            Member member = memberContext.FindMember(UmayplusCardID, PersonalCardID);

            return member;
        }
    } 
}
