using ApplicationCore.Commons.Repository;
using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User, int> userRepository;
        private readonly IBaseRepository<Tech, int> techRepository;
        private readonly IBaseRepository<Language, int> languageRepository;

        public UserService(
            IBaseRepository<User, int> userRepository,
            IBaseRepository<Tech, int> techRepository,
            IBaseRepository<Language, int> languageRepository)
        {
            this.userRepository = userRepository;
            this.techRepository = techRepository;
            this.languageRepository = languageRepository;
        }

        public async Task<User> EditProfileInfo(User user)
        {
            var userToEdit = await userRepository.FindFirst(x => x.Id == user.Id);
            if (userToEdit == null)
            {
                throw new Exception();
            }
            userToEdit.FirstName = user.FirstName;
            userToEdit.LastName = user.LastName;
            userToEdit.Email = user.Email;
            return userToEdit;
        }
    }
}
