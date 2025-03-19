using System;

namespace SAP_WebAPI.Constants;

public static class RegexConstants
{
    public const string PASSWORD_REGEX = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$";
    public const string USERNAME_REGEX = "^[a-zA-Z0-9_.-]{3,50}$";
    public const string NAME_REGEX = "^[A-Z][a-z]{2,30}$";
    public const string PRODUCT_NAME_REGEX = "^[a-zA-Z0-9\\s]{2,50}$";
    public const string PRODUCT_BRAND_REGEX = "^[a-zA-Z0-9\\s]{2,30}$";
}
