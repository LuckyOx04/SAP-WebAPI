using System;

namespace SAP_WebAPI.Constants;

public static class MessageConstants
{
    public const string INTERNAL_SERVER_ERROR = "Internal server error!";

    // not found
    public const string USER_NOT_FOUND = "User not found!";
    public const string PROFILE_NOT_FOUND = "Profile not found!";
    public const string CATEGORY_NOT_FOUND = "Category not found!";
    public const string ROLE_NOT_FOUNT = "Role not found!";
    public const string CAMPAIGN_NOT_FOUND = "Campaign not found!";
    public const string PRODUCT_NOT_FOUND = "Product not found!";

    // exists
    public const string USER_EXISTS = "User already exists!";
    public const string CAMPAIGN_EXISTS = "Campaign already exists!";

    // fields
    public const string FIELD_CANNOT_BE_BLANK = "Field can not be blank!";

    // authentication
    public const string INVALID_USERNAME_PASSWORD = "Invalid username or password!";
    public const string INVALID_JWT = "JWT was expired or invalid!";

    // registration
    public const string INVALID_USERNAME = "Invalid format for username. Must be at least 3 symbols long.";
    public const string INVALID_FIRST_NAME = "Invalid format for first name. Name must start with " +
            "capital letter and contain only characters.";
    public const string INVALID_LAST_NAME = "Invalid format for last name. Name must start with " +
            "capital letter and contain only characters.";
    public const string INVALID_PASSWORD = "Invalid format for password. Password must be at least 8 " +
            "characters long, contain at least one digit, one uppercase letter and one lowercase letter!";
    public const string PASSWORD_MISMATCH = "Repeated password doesn't match original!";

    // product
    public const string INVALID_PRICE = "Invalid format for price. Price must be positive or zero!";
    public const string INVALID_MIN_PRICE = "Invalid format for price. Price must be greater than or equal " +
            "to the min price!";
    public const string INVALID_PRODUCT_NAME = "Invalid format for product name. Name must be between 2 and" +
            " 50 characters long and can contain only letters (both uppercase and lowercase), digits, and spaces!";
    public const string INVALID_PRODUCT_BRAND = "Invalid format for product brand. Product brand name must " +
            "be between 2 and 30 characters long and can contain only letters (both uppercase and lowercase), " +
            "digits, and spaces.";
    public const string INVALID_AVAILABILITY = "Invalid format for availability. Availability must be " +
            "positive or zero!";
    public const string INVALID_DISCOUNT = "Invalid format for discount. Discount must be between 0 and 100";
    public const string INVALID_DISCOUNT_MIN_PRICE = "Invalid format for discount. Price after discount falls" +
            " bellow minimum!";

    // campaign
    public const string INVALID_START_DATE = "Invalid format for start date. Start date must be present or" +
            " future!";
    public const string INVALID_END_DATE = "Invalid format for end date. End date must be greater than or" +
            " equal to the start date!";

    // sale
    public const string PRODUCT_UNAVAILABLE = "Sorry, the requested product is currently unavailable." +
            " Please check back later or explore our other offerings";
    public const string NOT_ENOUGH_MONEY = "Sorry, not enough funds to complete the purchase." +
            " Please charge more money in your account.";
    public const string NO_TURNOVER_FOR_THIS_PERIOD = "Sorry, there is no turnover for this period";

    // images
    public const string FILE_UPLOAD_FAILURE = "File upload failed.";

    // profile
    public const string INVALID_MONEY_NUMBER = "The number is below zero";
}
