namespace Domain.Entities
{
    public class Team
    {
        public Team()
        {
            teamMembers = new HashSet<TeamMembers>();
        }
        public string teamId { get; set; }
        public string teamName { get; set; }
        
        public string description { get; set; }
        
        public string? coverImage { get; set; }
        
        public string createdBy { get; set; }
        
        public string? wrokingOn { get; set; }
        
        public DateTime createdAt { get; set; }
        
        public string? mainFunction {get; set;} 

         public virtual ICollection<TeamMembers> teamMembers {get; private set;}
        
    }
}