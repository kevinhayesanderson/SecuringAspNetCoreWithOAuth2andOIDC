// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using Duende.IdentityServer.Test;
using IdentityModel;
using System.Security.Claims;

namespace Simple.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            var address = new
            {
                street_address = "One Hacker Way",
                locality = "Heidelberg",
                postal_code = "69118",
                country = "Germany"
            };

            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "David",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "David Flagg"),
                        new Claim(JwtClaimTypes.GivenName, "David"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                        //new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                        //new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        //new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        //new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "Emma",
                    Password = "password",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Emma Flagg"),
                        new Claim(JwtClaimTypes.GivenName, "Emma"),
                        new Claim(JwtClaimTypes.FamilyName, "Flagg"),
                        //new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                        //new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        //new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                        //new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                    }
                }
            };
        }
    }
}