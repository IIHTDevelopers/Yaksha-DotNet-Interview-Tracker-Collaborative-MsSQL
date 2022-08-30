using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.DataLayer;
using InterviewTracker.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services.Repository
{
    public class UserInterviewTrackerRepository : IUserInterviewTrackerRepository
    {
        /// <summary>
        /// Creating Referance variable of InterviewTrackerDbContext
        /// Injecting in UserInterviewTrackerRepository constructor
        /// </summary>
        private readonly InterviewTrackerDbContext _interviewTrackerDbContext;

        public UserInterviewTrackerRepository(InterviewTrackerDbContext interviewTrackerDbContext)
        {
            _interviewTrackerDbContext = interviewTrackerDbContext;
        }
        /// <summary>
        /// Delete User from InMemory Db by passing UserId
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUserById(int UserId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All User from InMemorydb
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a user from InMemoryDb
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public ApplicationUser GetUserById(int userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register New User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Register(ApplicationUser user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Update or Edit Registred User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UpdateUser(ApplicationUser user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get List of user, this method is used for binding user list on dropdownList
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ApplicationUser> User()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
