using CTTSite.Models;

namespace CTTSite.Services.Interface
{
    //Made by Mads
    public interface IConsultationService
    {
        Task CreateConsultationAsync(Consultation consultation);
        Task DeleteConsultationAsync(Consultation consultation);
        Task UpdateConsultationAsync(Consultation consultationN);
        Task SubmitConsultationByEmailAsync(Consultation consultation, string email);
        Task<Consultation> GetConsultationByIDAsync(int ID);
        Task<List<Consultation>> GetAllConsultationsAsync();
        Task<List<Consultation>> GetAvailableConsultationsAsync();
        Task DeleteExpiredUnbookedConsultationsAsync();
        bool IsDateWithinPresentDate(Consultation consultation);
        Task<bool> IsTimeSlotAvailableInDataBaseAsync(Consultation consultation);
        bool IsTimeSlotCorrectEntered(Consultation consultation);
        bool IsTimeSlotBeforeDateNow(Consultation consultation);
        List<IGrouping<DateTime, Consultation>> GroupConsultationsByDate(List<Consultation> consultations);
        List<Consultation> SortConsultationsByDateTime(List<Consultation> consultations);
    }
}
