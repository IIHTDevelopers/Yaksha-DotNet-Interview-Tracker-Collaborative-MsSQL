using System;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InterviewTracker.Controllers
{
    public class DashboardController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interviewTR;
        private readonly IUserInterviewTrackerRepository _userTR;
        public DashboardController(IInterviewTrackerRepository interviewTrackerRepository, 
            IUserInterviewTrackerRepository userInterviewTrackerRepository )
        {
            _interviewTR = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
        /// <summary>
        /// Get all Interview From database 
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <returns></returns>
       
        public async Task<IActionResult> AllInterviewAsync()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Edit an interview
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
       
        public async Task<IActionResult> EditInterview(EditInterviewViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Delete Interview
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
       
        public async Task<IActionResult> DeleteInterview(int interviewId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get  Interview by interviewer name 
        /// </summary>
        /// <returns></returns>
      
        public async Task<IActionResult> InterviewByInterviewerName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
