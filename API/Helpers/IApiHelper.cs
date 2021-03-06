using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Models;

namespace API.Helpers
{
    public interface IApiHelper
    {

        #region UserMethods
        Task<bool> AddUser(User user, string password);
        Task<User> Login(string email, string password);
        Task<string> ReturnUserRole(string id);
        Task<string[]> ReturnUserName(string id);
        Task<User> UpdateUserInfo(string id, string firstName, string surname);
        Task<bool> SendResetPasswordMail(string email);
        Task<bool> SetNewPassword(string resetPasswordCode, string email, string newPassowrd);
        Task<bool> ValidateResetPasswordCode(string resetPasswordCode, string email);
        #endregion

        #region CalendarMethods
        Task<CalendarNote> AddCalendarNote(CalendarNote calendarNote, string userId);
        Task<List<CalendarNote>> ReturnCurrentMonthNotes(string familyId, string userId);
        Task<List<CalendarNote>> ReturnNotesForMonth(string familyId, string userId, string month);

        Task<Visit> AddVisit(Visit visit, string userId);
        Task<List<Visit>> ReturnCurrentMonthVisits(string familyId, string userId);
        Task<List<Visit>> ReturnVisitsForMonth(string familyId, string userId, string month);
        #endregion

        #region FamilyMethods
        Task<Family> CreateFamily(string id, string familyName);
        Task<Family> JoinToFamily(string invitationCode, string id);
        Task<ReturnFamilyDTO> ReturnFamilyInfo(string familyId, string userId);
        Task<bool> SendMailWithCode(string userMail, string familyId, string performerId);
        Task<bool> DoesUserBelongToFamily(string familyId, string userId);
        Task<bool> DeleteFamily(string userId, string familyId);
        #endregion

        #region PrivateNotesMethods
        Task<PrivateNote> AddPrivateNote(string message, string userId);
        Task<List<PrivateNote>> ReturnUserPrivateNotes(string userId);
        Task<PrivateNote> UpdateNote(string message, string noteId, string userId);
        Task<bool> DeletePrivateNote(string noteId, string userId); 
        #endregion
    
    }
}