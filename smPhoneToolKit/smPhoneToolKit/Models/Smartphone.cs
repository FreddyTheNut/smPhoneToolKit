using smPhoneToolKit.Models.Enums;

namespace smPhoneToolKit.Models
{
    public class Smartphone
    {
        private string bezeichnung;
        private Status status;
        private SmartphoneDetails smartphoneDetails;

        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public Status Status { get => status; set => status = value; }
        public SmartphoneDetails SmartphoneDetails { get => smartphoneDetails; set => smartphoneDetails = value; }
    }
}
