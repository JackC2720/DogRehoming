using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace dogrehoming.Core.Models.Data
{
    [TableName("customDogs"), PrimaryKey("id")]
    public class CustomDog
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]

        public string Name { get; set; }
        [Column("breed")]

        public string Breed { get; set; }
        [Column("arrivalDate")]

        public DateTime ArrivalDate { get; set; }
        [Column("rehomeDate")]

        public DateTime RehomedDate { get; set; }
        [Column("dob")]

        public DateTime Dob {  get; set; }
        [Column("canLiveWithOtherAnimals")]

        public bool CanLiveWithOtherAnimals { get; set; }
        [Column("canLiveWithChildren")]

        public bool CanLiveWithChildren { get; set; }
        [Column("sex")]

        public string Sex { get; set; } 
    }

}
