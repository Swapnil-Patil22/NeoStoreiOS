using System;
using Newtonsoft.Json;

namespace NeoStore.Entity
{
    public class User
    {
        public User()
        {
        }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "role_id")]
        public string RoleId { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "confirm_password")]
        public string ConfirmPassword { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "phone_no")]
        public string PhoneNo { get; set; }

        [JsonProperty(PropertyName = "dob")]
        public string DOB { get; set; }

        [JsonProperty(PropertyName = "profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty(PropertyName = "is_active")]
        public string IsActive { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public string Modified { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

    }
}
