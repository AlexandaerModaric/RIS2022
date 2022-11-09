using Ris2022.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Ris2022.Data.Models
{
    public class News
    {
        #region Attributes
        [Key]
        public int Id { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "NewsTitle")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Title { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),ErrorMessageResourceName = "ErrorFieldRequired")]
        [Display(ResourceType = typeof(Resource), Name = "NewsBody")]
        public string Body { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "NewsLink")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string URL { get; set; }
        /// <summary>
        /// The department ID where order had been added.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ErrorFieldRequired")]
        [ForeignKey(nameof(Department))]
        public int? Departmentid { get; set; }

        [Display(ResourceType = typeof(Resource), Name = "Department")]
        public virtual Department? Department { get; set; }
        #endregion

    }
}
