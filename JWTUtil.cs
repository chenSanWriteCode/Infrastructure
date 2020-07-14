using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Exceptions;

namespace Infrastructure
{
    public class JWTUtil
    {
        public static string GenerateToken(string userId, string roleId)
        {
            JwtBuilder builder = new JwtBuilder();
            var token = builder.WithAlgorithm(new HMACSHA256Algorithm()).WithSecret(ConstInfo.JWT_Secret).ExpirationTime(DateTime.Now.AddHours(ConstInfo.JWT_EffectiveInterval)).AddClaim(ClaimName.Audience, userId).AddClaim("RoleId", roleId).WithVerifySignature(true).Encode();
            return token;
        }
        public static Result<object> Validata(string token)
        {
            JwtBuilder builder = new JwtBuilder();
            try
            {
                var info = builder.WithAlgorithm(new HMACSHA256Algorithm()).WithSecret(ConstInfo.JWT_Secret).WithVerifySignature(true).Decode<object>(token);
                return ResultUtil.CreateResult(info);
            }
            catch (TokenExpiredException err)
            {
                return ResultUtil.CreateResult<object>(err.Message + "token过期");
            }
            catch (Exception err)
            {
                return ResultUtil.CreateResult<object>(err.Message + "未授权");
            }
        }
    }
}
