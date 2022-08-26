using System.Collections.Generic;
using System.Globalization;

namespace Ris2022.Data.Models
{
    public class CultureSwitcherModel
    {
        public CultureInfo CurrentUICulture { get; set; }=null!;
        public List<CultureInfo> SupportedCultures { get; set; }=null!;
    }
}