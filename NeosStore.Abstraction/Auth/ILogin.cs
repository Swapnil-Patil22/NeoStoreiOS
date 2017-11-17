using System;
using NeoStore.Entity;

namespace NeosStore.Abstraction.Auth
{
    public interface ILogin
    {
        User Login();
    }
}
