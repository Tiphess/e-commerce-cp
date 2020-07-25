using e_commerce_cp.Data;
using e_commerce_cp.Utils.AppSettings;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Utils
{
    //Unused  for now
    public class ContextProvider
    {
        private readonly IOptions<ConnectionStrings> _connectionStrings;

        public ContextProvider(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public ECommerceCPContext GetDbContext()
        {
            return null; // new ECommerceCPContext(_connectionStrings.Value.e_commerce_cp);
        }

    }
}
