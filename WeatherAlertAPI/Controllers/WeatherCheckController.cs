using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherAlertAPI.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace WeatherAlertAPI.Controllers
{
    /// <summary>
    /// Sistema de Verificação de Temperaturas
    /// </summary>
    /// <remarks>
    /// API dedicada ao monitoramento e verificação automática de temperaturas.
    /// 
    /// Funcionalidades:
    /// * Verificação automática de temperaturas em tempo real
    /// * Criação automática de alertas baseados em preferências
    /// * Monitoramento contínuo das condições meteorológicas
    /// </remarks>
    [ApiController]
    [Route("api/weather")]
    [Produces("application/json")]
    [ApiExplorerSettings(GroupName = "v1")]
    [SwaggerTag("Verificação de Temperaturas")]
    public class WeatherCheckController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherCheckController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        /// <summary>
        /// Verifica as temperaturas atuais e cria alertas se necessário
        /// </summary>
        /// <remarks>
        /// Este endpoint realiza as seguintes ações:
        /// 
        /// 1. Consulta a temperatura atual de todas as cidades monitoradas
        /// 2. Compara com as preferências de notificação existentes
        /// 3. Cria alertas automaticamente quando necessário
        /// 
        /// Exemplo de requisição:
        /// ```http
        /// POST /api/weather/check
        /// ```
        /// 
        /// Possíveis resultados:
        /// - Alertas de temperatura alta
        /// - Alertas de temperatura baixa
        /// - Nenhum alerta (temperaturas normais)
        /// </remarks>
        /// <response code="200">Verificação realizada com sucesso</response>
        /// <response code="500">Erro ao acessar o serviço de previsão do tempo</response>
        [HttpPost("check")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CheckTemperatures()
        {
            await _weatherService.CheckAndCreateAlertsAsync();
            return Ok(new { message = "Verificação de temperaturas concluída com sucesso" });
        }
    }
}
