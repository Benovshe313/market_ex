﻿

namespace trouble2.Helpers
{
    internal class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
