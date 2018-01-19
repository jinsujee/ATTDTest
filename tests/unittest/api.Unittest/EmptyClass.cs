using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using umayplusapi.Services;
using umayplusapi.Models;

namespace api.Unittest
{
    public class MemberServiceTest
    {
        [Fact]
        public void GetMemberInfo_Success_ReturnMemberInfo_() {
            var umayplus_cardID = "6273885053341539";
            var personal_cardID = "3100505143401";
            var birth_date = "01/01/2530";
            var mobile_phone = "092224955";

            var expectMember = new Member()
            {
                UmayplusCardID = "6273885053341539",
                PersonalCardID = "3100505143401",
                BirthDate = "01/01/2530",
                MobilePhone = "092224955",
                FirstName = "Jinsujee",
                LastName = "Meejaroen",

            };
            StubMemberContext memberContext = new StubMemberContext();
            MemberService MemberService = new MemberService(memberContext);
            Member actualMember = MemberService.getMemberInfo(umayplus_cardID, personal_cardID, birth_date, mobile_phone);

            Assert.Equal(expectMember.UmayplusCardID, actualMember.UmayplusCardID);
            Assert.Equal(expectMember.PersonalCardID, actualMember.PersonalCardID);
            Assert.Equal(expectMember.BirthDate, actualMember.BirthDate);
            Assert.Equal(expectMember.MobilePhone, actualMember.MobilePhone);
            Assert.Equal(expectMember.FirstName, actualMember.FirstName);
            Assert.Equal(expectMember.LastName, actualMember.LastName);
        }
    }
}
