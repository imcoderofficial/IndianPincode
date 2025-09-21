using System.ComponentModel.DataAnnotations.Schema;

namespace IndianPincode.Models
{
    [Table("IndiaPincodeData ")]
    public class IndiaPincodeData
    {
        public string? circlename { get; set; }
        public string? regionname { get; set; }
        public string? divisionname { get; set; }
        public string? officename { get; set; }
        public int? pincode { get; set; }
        public string? officetype { get; set; }
        public string? delivery { get; set; }
        public string? district { get; set; }
        public string? statename { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }
}
