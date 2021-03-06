﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace CalendarPlus.SystemObjects.Attributes
{
    public class BearerAuthorizeAttribute : AuthorizeAttribute
    {
        public BearerAuthorizeAttribute(string policy)
        {
            Policy = policy;
            AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme;
        }
    }
}
