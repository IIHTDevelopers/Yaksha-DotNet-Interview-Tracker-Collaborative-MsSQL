using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InterviewTracker.Controllers
{
    public class InterviewController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository and IUserInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IInterviewTrackerRepository _interview;
        private readonly IUserInterviewTrackerRepository _userTR;
        public InterviewController(IInterviewTrackerRepository interviewTrackerRepository, IUserInterviewTrackerRepository userInterviewTrackerRepository)
        {
            _interview = interviewTrackerRepository;
            _userTR = userInterviewTrackerRepository;
        }
       
        /// <summary>
        /// Add new interview
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("interview/addnewinterview")]
        public async Task<IActionResult> AddNewInterview(AddInterviewViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Count all interviews
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("interview/countallinterviews")]
        public async Task<IActionResult> CountAllInterview()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
