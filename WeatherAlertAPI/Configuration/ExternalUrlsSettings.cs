namespace WeatherAlertAPI.Configuration
{
    /// <summary>
    /// Configurações para URLs externas usadas pela aplicação
    /// </summary>
    public class ExternalUrlsSettings
    {
        /// <summary>
        /// URL base do site oficial
        /// </summary>
        public string WeatherAlertSite { get; set; } = string.Empty;
        
        /// <summary>
        /// URL de suporte
        /// </summary>
        public string SupportUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// URL dos termos de serviço
        /// </summary>
        public string TermsUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// URL da licença MIT
        /// </summary>
        public string MitLicenseUrl { get; set; } = string.Empty;
        
        /// <summary>
        /// Email de suporte
        /// </summary>
        public string SupportEmail { get; set; } = string.Empty;
    }
}
