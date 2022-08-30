using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTracker.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IUserInterviewTrackerRepository _interviewTrackerRepository;
        public UserController(IUserInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTrackerRepository = interviewTrackerRepository;
        }

        /// <summary>
        /// Register new user 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("user/getallusers")]
        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register new user 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("user/registeruser")]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Edit user after load User on edit mode
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("user/edituser")]
        public async Task<IActionResult> EditUser(UserEditViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Delete User by userID
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("user/deleteuser/{UserId}")]
        public async Task<IActionResult> DeleteUser(int UserId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
