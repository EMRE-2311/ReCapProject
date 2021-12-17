using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "The car added";
        public static string CarNameInvalid = "The cars name must be larger than 2 words";
        public static string CarPriceInvalid = "The price must be a positive number";
        public static string CarDetailsShown = "The car details are shown";
        public static string CarDeleted = "The car deleted";
        public static string CarUpdated= "The car updated";
        public static string CarNotReturned = "The car hasn't returned yet";
        public static string CarsListed = "The cars listed";
        public static string CarListed = "The car listed";

        public static string RentalAdded = "The rental added";
        public static string RentalUpdated = "The rental updated";
        public static string RentalDeleted = "The rental deleted";


        public static string BrandDeleted = "The Brand deleted";
        public static string BrandAdded = "The Brand added";
        public static string BrandUpdated = "The Brand updated";
        public static string BrandListed = "The Brand listed";
        public static string BrandsListed = "The Brands listed";


        public static string ColorAdded = "The Color added";
        public static string ColorUpdated = "The Color updated";
        public static string ColorDeleted = "The Color deleted";
        public static string ColorListed = "The Color listed";
        public static string ColorsListed = "The Colors listed";
        public static string NumOfColorNotEnough = "There is not enough color in the database";
        public static string ColorNameInvalid = "Color name must be larger than two";


        public static string UserNameInvalid = "User name must be larger than 5";
        public static string UserAdded = "The user added";
        public static string UserNotEnough = "There is not enough user in the database";
        public static string UserUpdated = "The user updated";
        public static string UserDeleted = "The user deleted";
        public static string UsersListed = "The Users Listed";
        public static string UserListed = "The User Listed";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Incorrect password";
        public static string SuccessfullLogin = "Login is successfull";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User successfully registered";
        public static string AccessTokenCreated = "Access token successfully created";
        public static string AuthorizationDenied = "Authorization is denied";
    }
}
