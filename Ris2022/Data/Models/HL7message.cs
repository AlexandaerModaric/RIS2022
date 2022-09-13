namespace Ris2022.Data.Models
{
    public class HL7message
    {
        public int msgId { get; set; }
        public int? patientId { get; set; }
        public string patientGivenId { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public int? commOrderPONum { get; set; }
        public string startDateTime { get; set; }
        public int? obsOrderPFNum { get; set; }
        public string DestinationServer { get; set; }
        public int? DestinationPort { get; set; }
        public string accessionNumber { get; set; }
        public string studyId { get; set; }
        public string aeTitle { get; set; }
        public string sStationName { get; set; }
        public string modalityName { get; set; }
        public int procedureId { get; set; }
        public string procedureName { get; set; }
    }
}
