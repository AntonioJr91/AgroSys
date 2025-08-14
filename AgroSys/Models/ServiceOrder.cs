using AgroSys.Enums;

namespace AgroSys.Models
{
    internal class ServiceOrder
    {
        public ServiceOrder
            (
                string name,
                ServiceType serviceType,
                Person responsible,
                Material materialUsed,
                double materialAmount,
                Sector serviceSector,
                DateTime? endDate,
                string anotacao
            )
        {
            Name = name;
            ServiceType = serviceType;
            Responsible = responsible;
            MaterialUsed = materialUsed;
            MaterialAmount = materialAmount;
            ServiceSector = serviceSector;
            Status = Status.Progress;
            StartDate = DateTime.Now;
            EndDate = endDate;
            Comment = anotacao;
        }

        public string Name { get; set; }
        public ServiceType ServiceType { get; set; }
        public Person Responsible { get; set; }
        public Material MaterialUsed { get; set; }
        public double MaterialAmount { get; set; }
        public Sector ServiceSector { get; set; }
        public Status Status { get; set; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
        private void ChangeStatus(Status newStatus) => Status = newStatus;
    }

}
