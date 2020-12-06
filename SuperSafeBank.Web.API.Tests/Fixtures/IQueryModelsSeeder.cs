﻿using System.Threading.Tasks;

namespace SuperSafeBank.Web.API.Tests.Fixtures
{
    public interface IQueryModelsSeeder
    {
        Task CreateCustomerDetails(Core.Queries.Models.CustomerDetails model);
        Task CreateCustomerArchiveItem(Core.Queries.Models.CustomerArchiveItem model);
    }
}