using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using KeahTekSerAppAPI.CQRS.Response.Query.User;
using Microsoft.Extensions.Configuration;

namespace KeahTekSerAppAPI.Security
{
    public class CreateToken
    {
        public static string CreateTokenRegister(UserCreateTokenQueryResponse userToken)
        {
            if (userToken != null)
            {
                //var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("SuperStrongAndSecretKey"));
                //var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                //var claims = new[]
                //{
                //    new Claim(ClaimTypes.NameIdentifier, userToken.PERSONEL_ID_NUMBER.ToString()),
                //    new Claim(ClaimTypes.Name, userToken.PERSONEL_ADI.ToString()),
                //    new Claim(ClaimTypes.Surname, userToken.PERSONEL_SOYADI.ToString()),
                //    new Claim(ClaimTypes.Role, userToken.PERSONEL_ROLU.ToString())
                //};

                //var token = new JwtSecurityToken("https://localhost:44345/",
                //"https://localhost:44345/",
                //claims,
                //expires: DateTime.Now.AddDays(30),
                //signingCredentials: credentials);

                //return new JwtSecurityTokenHandler().WriteToken(token); 

                //-----------------------------------------------
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("SuperStrongAndSecretKey");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, userToken.PERSONEL_ID_NUMBER.ToString()),
                        new Claim(ClaimTypes.Name, userToken.PERSONEL_ADI.ToString()),
                        new Claim(ClaimTypes.Surname, userToken.PERSONEL_SOYADI.ToString()),
                        new Claim(ClaimTypes.Role, userToken.PERSONEL_ROLU.ToString())
                    }),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                    Expires = DateTime.Now.AddDays(90)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            else
            {
                return null;
            }
        }
    }
}
