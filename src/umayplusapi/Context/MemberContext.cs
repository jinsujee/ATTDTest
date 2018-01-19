using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umayplusapi.Models;

namespace umayplusapi.Contexts
{
    public class MemberContext : DbContext, IMemberContext
    {
        public MemberContext(DbContextOptions<MemberContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Member> Members { get; set; }

        public Member FindMember(string umayplusCardID, string personalCardId)
        {
            return this.Members.Where(m => m.UmayplusCardID == umayplusCardID && m.PersonalCardID == personalCardId).First();

        }
    }
}