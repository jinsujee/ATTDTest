using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using umayplusapi.Models;
using umayplusapi.Services;

namespace umayplusapi.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private IMemberService memberService;
        public MemberController(IMemberService memberService) {
            this.memberService = memberService;
        }
        // POST api/<controller>
        [HttpPost]
        public ResponseMessage Post([FromBody]Member member)
        {
            Member returnMember = memberService.getMemberInfo(member.UmayplusCardID, member.PersonalCardID, member.BirthDate, member.MobilePhone);
            
            return new ResponseMessage()
            {
                status = "200",
                message = member.UmayplusCardID,
                data = returnMember
            };
        }
    }
}
