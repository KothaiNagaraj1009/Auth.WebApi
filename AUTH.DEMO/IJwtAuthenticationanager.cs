using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUTH.DEMO
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
