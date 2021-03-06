﻿using Hobby.DTO;
using Hobby.Entities;

namespace Hobby.Services.Interfaces
{
    public interface IUserService
    {
        UserDTO GetUserDTO(decimal id);

        void AddUser(User user);

        void Update(User user);

        UserDTO UpdateUser(UserDTO userDTO);
    }
}
