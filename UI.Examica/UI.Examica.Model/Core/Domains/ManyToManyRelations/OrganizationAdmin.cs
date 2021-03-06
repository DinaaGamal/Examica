﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Examica.Model.Core.Domains
{
    public class OrganizationAdmin
    {
        public int OrgnaizationId { get; set; }
        public string AppUserId { get; set; }
        public Organization Organization { get; set; }
        public AppUser AppUser { get; set; }
    }
}
