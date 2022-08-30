using InterviewTracker.DataLayer;
using InterviewTracker.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTracker.BusinessLayer.Services.Repository
{
    public class InterviewTrackerRepository : IInterviewTrackerRepository
    {
        /// <summary>
        /// Creating Referance variable of InterviewTrackerDbContext
        /// Injecting in InterviewTrackerRepository constructor
        /// </summary>
        private readonly InterviewTrackerDbContext _interviewDb;
        
        public InterviewTrackerRepository(InterviewTrackerDbContext interviewTrackerDbContext)
        {
            _interviewDb = interviewTrackerDbContext;
        }


        /// <summary>
        /// Add New Interview in InMemoryDb
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> AddInterview(Interview interview)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a interview from InMemoryDb
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInterviewById(int interviewId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all Interview from InMemoryDb
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> GetAllInterview()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a Interview by InterviewId
        /// </summary>
        /// <param name="interviewId"></param>
        /// <returns></returns>
        public Interview GetInterviewrById(int interviewId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get interview by Interview Name and Interviewer Name, this method used for search
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Interview>> InterviewByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get Total count of Registred Interview in InMemoryDb
        /// </summary>
        /// <returns></returns>
        public int TotalCount()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Edit or Update Saved Interview
        /// </summary>
        /// <param name="interview"></param>
        /// <returns></returns>
        public async Task<Interview> UpdateInterview(Interview interview)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
