using Microsoft.Extensions.Localization;
using Ris2022.Resources;
using System.Reflection;

namespace Ris2022.Services
{
    public class CommonLocalizationService
    {
        private readonly IStringLocalizer localizer;
        public CommonLocalizationService(IStringLocalizerFactory factory)
        {
            var assemblyName = new AssemblyName(typeof(CommonResources).GetTypeInfo().Assembly.FullName);
            localizer = factory.Create(nameof(CommonResources), assemblyName.Name);
        }
 
        public string Get(string key)
        {
            string s=localizer[key];
            return s;
        }
    }
}