namespace WeatherAlertAPI.Constants
{
    /// <summary>
    /// Constantes para rotas da API
    /// </summary>
    public static class ApiRoutes
    {
        /// <summary>
        /// Rota base para preferências
        /// </summary>
        public const string PREFERENCIAS = "/api/Preferencias";
        
        /// <summary>
        /// Rota base para alertas
        /// </summary>
        public const string ALERTAS = "/api/Alerta";
        
        /// <summary>
        /// Rota para verificação de temperaturas
        /// </summary>
        public const string WEATHER_CHECK = "/api/weather/check";
    }

    /// <summary>
    /// Constantes para parâmetros de stored procedures
    /// </summary>
    public static class StoredProcedureParams
    {
        /// <summary>
        /// Parâmetro ID de preferência
        /// </summary>
        public const string P_ID_PREFERENCIA = "p_id_preferencia";
        
        /// <summary>
        /// Parâmetro ID de alerta
        /// </summary>
        public const string P_ID_ALERTA = "p_id_alerta";
    }

    /// <summary>
    /// Constantes para nomes de colunas do banco de dados
    /// </summary>
    public static class DatabaseColumns
    {
        /// <summary>
        /// Nome da coluna cidade no banco
        /// </summary>
        public const string CIDADE = "CIDADE";
        
        /// <summary>
        /// Nome da coluna estado no banco
        /// </summary>
        public const string ESTADO = "ESTADO";
        
        /// <summary>
        /// Nome da coluna ativo no banco
        /// </summary>
        public const string ATIVO = "ATIVO";
        
        /// <summary>
        /// Nome da coluna data criação no banco
        /// </summary>
        public const string DATA_CRIACAO = "DATA_CRIACAO";
    }

    /// <summary>
    /// Constantes para URLs externas
    /// </summary>
    public static class ExternalUrls
    {
        /// <summary>
        /// URL base do site oficial
        /// </summary>
        public const string WEATHERALERT_SITE = "https://weatheralert.com";
        
        /// <summary>
        /// URL de suporte
        /// </summary>
        public const string SUPPORT_URL = "https://weatheralert.com/support";
        
        /// <summary>
        /// URL dos termos de serviço
        /// </summary>
        public const string TERMS_URL = "https://weatheralert.com/terms";
        
        /// <summary>
        /// URL da licença MIT
        /// </summary>
        public const string MIT_LICENSE_URL = "https://opensource.org/licenses/MIT";
        
        /// <summary>
        /// Email de suporte
        /// </summary>
        public const string SUPPORT_EMAIL = "suporte@weatheralert.com";
    }
}
