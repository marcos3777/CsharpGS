using Microsoft.Extensions.Options;
using WeatherAlertAPI.Configuration;

namespace WeatherAlertAPI.Services
{
    /// <summary>
    /// Serviço para gerenciamento de URLs configuráveis
    /// </summary>
    public class UrlService : IUrlService
    {
        private readonly ExternalUrlsSettings _urlSettings;

        public UrlService(IOptions<ExternalUrlsSettings> urlSettings)
        {
            _urlSettings = urlSettings.Value;
        }

        /// <summary>
        /// Obtém a URL de suporte
        /// </summary>
        public string GetSupportUrl() => _urlSettings.SupportUrl;

        /// <summary>
        /// Obtém o email de suporte
        /// </summary>
        public string GetSupportEmail() => _urlSettings.SupportEmail;

        /// <summary>
        /// Obtém a URL dos termos de serviço
        /// </summary>
        public string GetTermsUrl() => _urlSettings.TermsUrl;

        /// <summary>
        /// Obtém a URL da licença MIT
        /// </summary>
        public string GetMitLicenseUrl() => _urlSettings.MitLicenseUrl;

        /// <summary>
        /// Obtém a URL base do site
        /// </summary>
        public string GetWeatherAlertSite() => _urlSettings.WeatherAlertSite;
    }
}
