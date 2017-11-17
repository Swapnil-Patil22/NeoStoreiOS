using System;
using NeoStore.Entity;

namespace NeosStore.Abstraction.Auth
{
    public interface IRegisterUser
    {
        User Register();
    }
}
