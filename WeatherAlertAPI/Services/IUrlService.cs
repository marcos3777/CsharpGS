namespace WeatherAlertAPI.Services
{
    /// <summary>
    /// Interface para serviço de URLs configuráveis
    /// </summary>
    public interface IUrlService
    {
        /// <summary>
        /// Obtém a URL de suporte
        /// </summary>
        string GetSupportUrl();
        
        /// <summary>
        /// Obtém o email de suporte
        /// </summary>
        string GetSupportEmail();
        
        /// <summary>
        /// Obtém a URL dos termos de serviço
        /// </summary>
        string GetTermsUrl();
        
        /// <summary>
        /// Obtém a URL da licença MIT
        /// </summary>
        string GetMitLicenseUrl();
        
        /// <summary>
        /// Obtém a URL base do site
        /// </summary>
        string GetWeatherAlertSite();
    }
}
