# 🔒 Configuração de Segurança - Weather Alert API

## ⚠️ IMPORTANTE: Problema de Segurança Resolvido

Este projeto foi corrigido para **não expor mais credenciais sensíveis** no código fonte ou controle de versão.

## 📋 O que foi corrigido

✅ **Credenciais removidas do código fonte**  
✅ **Arquivo .gitignore configurado**  
✅ **Sistema de configuração local implementado**  
✅ **Arquivos de build limpos**  
✅ **Testes atualizados para configuração segura**  

## 🛠️ Como configurar o ambiente

### 1. Criar arquivo de configurações locais

Crie o arquivo `WeatherAlertAPI/appsettings.Local.json` com suas credenciais:

```json
{
  "Database": {
    "ConnectionString": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)))"
  },
  "WeatherApi": {
    "ApiKey": "SUA_WEATHER_API_KEY",
    "BaseUrl": "https://api.weatherapi.com/v1"
  }
}
```

### 2. Para testes, criar também

Crie o arquivo `WeatherAlertAPI.Tests/appsettings.Local.json` com as mesmas configurações.

### 3. Verificar .gitignore

O arquivo `.gitignore` já está configurado para **não** fazer commit dos arquivos `*.Local.json`.

## 🚨 Boas práticas implementadas

### ✅ Configurações sensíveis
- **Credenciais** movidas para arquivos locais
- **API Keys** não expostas no código
- **Strings de conexão** protegidas

### ✅ Controle de versão
- Arquivo `.gitignore` configurado
- Arquivos `*.Local.json` excluídos do Git
- Diretórios `bin/` e `obj/` limpos

### ✅ Ambiente de desenvolvimento
- Configuração automática via `appsettings.Local.json`
- Fallback para configurações vazias se arquivo não existir
- Testes configurados para usar configurações locais

## 🔄 Próximos passos recomendados

### Para produção:
1. **Usar Azure Key Vault** ou similar para secrets
2. **Configurar variáveis de ambiente** no servidor
3. **Implementar rotação de senhas**
4. **Audit logs** para acesso ao banco

### Para desenvolvimento:
1. **Não compartilhar** arquivos `*.Local.json`
2. **Usar senhas diferentes** para cada desenvolvedor
3. **Rotacionar API keys** periodicamente

## ❌ O que NÃO fazer

- ❌ **Nunca** faça commit de credenciais
- ❌ **Nunca** coloque senhas em código fonte
- ❌ **Nunca** compartilhe arquivos `*.Local.json`
- ❌ **Nunca** use credenciais de produção em desenvolvimento

## 📞 Em caso de problemas

Se você encontrar credenciais expostas:

1. **🚨 MUDE AS SENHAS IMEDIATAMENTE**
2. Revogue API keys comprometidas
3. Limpe o histórico do Git se necessário
4. Notifique a equipe de segurança

---

**Status:** ✅ **Projeto seguro e configurado corretamente**  
**Última verificação:** $(Get-Date -Format "yyyy-MM-dd HH:mm")
