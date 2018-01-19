using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umayplusapi.Models;

namespace umayplusapi.Contexts
{
    public interface IMemberContext
    {
        Member FindMember(string umaplusCardID, string personalCardID);
    }
}
