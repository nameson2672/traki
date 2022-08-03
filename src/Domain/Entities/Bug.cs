using Domain.Enums;

namespace Domain.Entities
{
    public class Bug
    {
        public string bugId { get; set; }
        
        public string title { get; set; }
        public BugStatus status { get; set; }
        public string statusChangedBy { get; set; }
        public string assignedTo { get; set; }
        public RiskLevel risk { get; set; }
        public string description { get; set; }
        public string createdBy { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime lastModified { get; set; }
        
        
        
        
    }
}