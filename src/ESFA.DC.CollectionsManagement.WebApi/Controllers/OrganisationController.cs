﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESFA.DC.CollectionsManagement.Models;
using ESFA.DC.CollectionsManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace ESFA.DC.CollectionsManagement.WebApi.Controllers
{
    [Route("api/org")]
    public class OrganisationController : Controller
    {
        private readonly IOrganisationService _organisationService;

        public OrganisationController(IOrganisationService organisationService)
        {
            _organisationService = organisationService;
        }

        // GET api/values/5
        [HttpGet("{ukprn}")]
        public IEnumerable<Collection> Get(long ukprn)
        {
           return _organisationService.GetAvailableCollections(ukprn);
        }
    }
}
