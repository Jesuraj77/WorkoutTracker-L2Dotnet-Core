using System;
using System.Collections.Generic;
using System.Text;
using WorkOutTracker.Models;

namespace WorkOutTracker.Services
{
  public class WorkOutTrackerService
    {

        public bool AddWorkOutCollection(WorkOutCollection workOut)
        {
            return true;
        }

        public WorkOutCollection EditWorkOutCollection(long workOutId)
        {
            WorkOutCollection workOut=new WorkOutCollection();

            return workOut;
        }

        public List<WorkOutCollection> ViewWorkOutCollections(int userId)
        {
            List<WorkOutCollection> workOutList = new List<WorkOutCollection>();
            return workOutList;     
        }

        public bool DeleteWorkOutCollection(long workOutId)
        {
            return true;
        }



        public bool AddWorkOutCategory(WorkOutCategory workOut)
        {
            return true;
        }

        public WorkOutCategory EditWorkOutCategory(long categoryId)
        {
            WorkOutCategory category = new WorkOutCategory();
            return category;
        }

        public List<WorkOutCategory> ViewWorkOutCategory(int userId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWorkOutCategory(long categoryId)
        {
            return true;
        }


        public void EndWorkOut(DateTime EndTime, DateTime EndDate, int userId)
        {
           
        }

        public void StartWorkOut(DateTime StartTime, DateTime StartDate, int userId)
        {

        }
        public void CreateReportOnWorkOut(WorkOutActive active, int userID)
        {

        }

    }
}
