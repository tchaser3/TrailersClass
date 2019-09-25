/* Title:           Trailers Class
 * Date:            8-30-18
 * Author:          Terry Holmes
 * 
 * Description:     This class is used for the trailers */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace TrailersDLL
{
    public class TrailersClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        TrailersDataSet aTrailersDataSet;
        TrailersDataSetTableAdapters.trailersTableAdapter aTrailersTableAdapter;

        InsertTrailerEntryTableAdapters.QueriesTableAdapter aInsertTrailerTableAdapter;

        UpdateTrailerEmployeeAndAvailabilityEntryTableAdapters.QueriesTableAdapter aUpdateTrailerEmployeeAndAvailabilityTableAdapter;

        UpdateTrailerLocationEntryTableAdapters.QueriesTableAdapter aUpdateTrailerLocationTableAdapter;

        UpdateTrailerActiveEntryTableAdapters.QueriesTableAdapter aUpdateActiveTableAdapter;

        FindActiveSortedTrailersDataSet aFindActiveSortedTrailersDataSet;
        FindActiveSortedTrailersDataSetTableAdapters.FindActiveSortedTrailersTableAdapter aFindActiveSortedTrailersTableAdapter;

        FindActiveTrailerByTrailerNumberDataSet aFindActiveTrailerByTrailerNumberDataSet;
        FindActiveTrailerByTrailerNumberDataSetTableAdapters.FindActiveTrailerByTrailerNumberTableAdapter aFindActiveTrailerByTrailerNumberTableAdapter;

        FindTrailerByTrailerNumberDataSet aFindTrailerByTrailerNumberDataSet;
        FindTrailerByTrailerNumberDataSetTableAdapters.FindTrailerByTrailerNumberTableAdapter aFindTrailerByTrailerNumberTableAdapter;

        FindTrailerByTrailerIDDataSet aFindTrailerByTrailerIDDataSet;
        FindTrailerByTrailerIDDataSetTableAdapters.FindTrailerByTrailerIDTableAdapter aFindTrailerByTrailerIDTableAdapter;

        FindActiveTrailerByLocationDataSet aFindActiveTrailerByLocationDataSet;
        FindActiveTrailerByLocationDataSetTableAdapters.FindActiveTrailerByLocationTableAdapter aFindActiveTrailerByLocationTableAdapter;

        FindAvailableTrailersDataSet aFindAvailableTrailersDataSet;
        FindAvailableTrailersDataSetTableAdapters.FindAvailableTrailersTableAdapter aFindAvailableTrailersTableAdapter;

        UpdateTrailerNotesEntryTableAdapters.QueriesTableAdapter aUpdateTrailerNotesTableAdapter;

        FindTrailerByEmployeeIDDataSet aFindTrailerByEmployeeIDDataSet;
        FindTrailerByEmployeeIDDataSetTableAdapters.FindTrailerByEmployeeIDTableAdapter aFindTrailerByEmployeeIDTableAdapter;

        public FindTrailerByEmployeeIDDataSet FindTrailerByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindTrailerByEmployeeIDDataSet = new FindTrailerByEmployeeIDDataSet();
                aFindTrailerByEmployeeIDTableAdapter = new FindTrailerByEmployeeIDDataSetTableAdapters.FindTrailerByEmployeeIDTableAdapter();
                aFindTrailerByEmployeeIDTableAdapter.Fill(aFindTrailerByEmployeeIDDataSet.FindTrailerByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Trailer By Employee ID " + Ex.Message);
            }

            return aFindTrailerByEmployeeIDDataSet;
        }
        public bool UpdateTrailerNotes(int intTrailerID, string strTrailerNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerNotesTableAdapter = new UpdateTrailerNotesEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerNotesTableAdapter.UpdateTrailerNotes(intTrailerID, strTrailerNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Update Trailer Notes " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindAvailableTrailersDataSet FindAvailableTrailers()
        {
            try
            {
                aFindAvailableTrailersDataSet = new FindAvailableTrailersDataSet();
                aFindAvailableTrailersTableAdapter = new FindAvailableTrailersDataSetTableAdapters.FindAvailableTrailersTableAdapter();
                aFindAvailableTrailersTableAdapter.Fill(aFindAvailableTrailersDataSet.FindAvailableTrailers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Available Trailers " + Ex.Message);
            }

            return aFindAvailableTrailersDataSet;
        }
        public FindActiveTrailerByLocationDataSet FindActTrailerByLocation(int intLocationID)
        {
            try
            {
                aFindActiveTrailerByLocationDataSet = new FindActiveTrailerByLocationDataSet();
                aFindActiveTrailerByLocationTableAdapter = new FindActiveTrailerByLocationDataSetTableAdapters.FindActiveTrailerByLocationTableAdapter();
                aFindActiveTrailerByLocationTableAdapter.Fill(aFindActiveTrailerByLocationDataSet.FindActiveTrailerByLocation, intLocationID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Active Trailer By Location " + Ex.Message);
            }

            return aFindActiveTrailerByLocationDataSet;
        }
        public FindTrailerByTrailerIDDataSet FindTrailerByTrailerID(int intTrailerID)
        {
            try
            {
                aFindTrailerByTrailerIDDataSet = new FindTrailerByTrailerIDDataSet();
                aFindTrailerByTrailerIDTableAdapter = new FindTrailerByTrailerIDDataSetTableAdapters.FindTrailerByTrailerIDTableAdapter();
                aFindTrailerByTrailerIDTableAdapter.Fill(aFindTrailerByTrailerIDDataSet.FindTrailerByTrailerID, intTrailerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Trailer By Traier ID " + Ex.Message);
            }

            return aFindTrailerByTrailerIDDataSet;
        }
        public FindTrailerByTrailerNumberDataSet FindTrailerByTrailerNumber(string strTrailerNumber)
        {
            try
            {
                aFindTrailerByTrailerNumberDataSet = new FindTrailerByTrailerNumberDataSet();
                aFindTrailerByTrailerNumberTableAdapter = new FindTrailerByTrailerNumberDataSetTableAdapters.FindTrailerByTrailerNumberTableAdapter();
                aFindTrailerByTrailerNumberTableAdapter.Fill(aFindTrailerByTrailerNumberDataSet.FindTrailerByTrailerNumber, strTrailerNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Trailer By Trailer Number " + Ex.Message);
            }

            return aFindTrailerByTrailerNumberDataSet;
        }

        public FindActiveTrailerByTrailerNumberDataSet FindActiveTrailerByTrailerNumber(string strTrailerNumber)
        {
            try
            {
                aFindActiveTrailerByTrailerNumberDataSet = new FindActiveTrailerByTrailerNumberDataSet();
                aFindActiveTrailerByTrailerNumberTableAdapter = new FindActiveTrailerByTrailerNumberDataSetTableAdapters.FindActiveTrailerByTrailerNumberTableAdapter();
                aFindActiveTrailerByTrailerNumberTableAdapter.Fill(aFindActiveTrailerByTrailerNumberDataSet.FindActiveTrailerByTrailerNumber, strTrailerNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Active Trailer By Trailer Number " + Ex.Message);
            }

            return aFindActiveTrailerByTrailerNumberDataSet;
        }
        public FindActiveSortedTrailersDataSet FindActiveSortedTrailers()
        {
            try
            {
                aFindActiveSortedTrailersDataSet = new FindActiveSortedTrailersDataSet();
                aFindActiveSortedTrailersTableAdapter = new FindActiveSortedTrailersDataSetTableAdapters.FindActiveSortedTrailersTableAdapter();
                aFindActiveSortedTrailersTableAdapter.Fill(aFindActiveSortedTrailersDataSet.FindActiveSortedTrailers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Find Active Sorted Trailers " + Ex.Message);
            }

            return aFindActiveSortedTrailersDataSet;
        }
        public bool UpdateTrailerActive(int intTrailerID, bool blnActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateActiveTableAdapter = new UpdateTrailerActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateActiveTableAdapter.UpdateTrailerActive(intTrailerID, blnActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Update Trailer Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTrailerLocation(int intTrailerID, int intLocationID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerLocationTableAdapter = new UpdateTrailerLocationEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerLocationTableAdapter.UpdateTrailerLocation(intTrailerID, intLocationID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Update Trailer Location " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateTrailerEmployeeAndAvailability(int intTrailerID, int intEmployeeID, bool blnTrailerAvailable)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerEmployeeAndAvailabilityTableAdapter = new UpdateTrailerEmployeeAndAvailabilityEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerEmployeeAndAvailabilityTableAdapter.UpdateTrailerEmployeeAndAvailability(intTrailerID, intEmployeeID, blnTrailerAvailable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Update Trailer Employee And Availability " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTrailer(string strTrailerNumber, int intCategoryID, string strVINNumber, string strTrailerDescription, string strLicensePlate, int intLocationID, int intEmployeeID, string strTrailerNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTrailerTableAdapter = new InsertTrailerEntryTableAdapters.QueriesTableAdapter();
                aInsertTrailerTableAdapter.InsertTrailer(strTrailerNumber, intCategoryID, strVINNumber, strTrailerDescription, strLicensePlate, intLocationID, intEmployeeID, strTrailerNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Insert Trailer " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TrailersDataSet GetTrailersIndo()
        {
            try
            {
                aTrailersDataSet = new TrailersDataSet();
                aTrailersTableAdapter = new TrailersDataSetTableAdapters.trailersTableAdapter();
                aTrailersTableAdapter.Fill(aTrailersDataSet.trailers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Get Trailers Info " + Ex.Message);
            }

            return aTrailersDataSet;
        }
        public void UpdateTrailersDB(TrailersDataSet aTrailersDataSet)
        {
            try
            {
                aTrailersTableAdapter = new TrailersDataSetTableAdapters.trailersTableAdapter();
                aTrailersTableAdapter.Update(aTrailersDataSet.trailers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailers Class // Get Trailers Info " + Ex.Message);
            }
        }
    }
}
