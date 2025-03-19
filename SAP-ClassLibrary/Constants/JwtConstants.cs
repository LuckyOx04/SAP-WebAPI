using System;

namespace SAP_WebAPI.Constants;

public static class JwtConstants
{
    public const int EXPIRATION = 3600000;
    //TODO Add secret
    public const string SECRET = "";
    public const string ROLES_CLAIM = "roles";
    public const string AUTHORIZATION_HEADERS = "Authorization";
    public const string BEARER = "Bearer";
}
