using Azure.Messaging.ServiceBus;
using EmailProvider.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace EmailProvider.Functions;

public class EmaiISender(ILogger<EmaiISender> logger, IEmailService emailService)
{
    private readonly ILogger<EmaiISender> _logger = logger;
    private readonly IEmailService _emailService = emailService;




    [Function(nameof(EmaiISender))]
    public async Task Run([ServiceBusTrigger("email_request", Connection = "ServiceBusConnection")] ServiceBusReceivedMessage message, ServiceBusMessageActions messageActions)
    {
        try
        {
            var emailRequest = _emailService.UnpackEmailRequest(message);
            if (emailRequest != null && !string.IsNullOrEmpty(emailRequest.To))
            {
                if (_emailService.SendEmail(emailRequest))
                {
                    await messageActions.CompleteMessageAsync(message);
                }
            }

        }
        catch (Exception ex)
        {
            _logger.LogError($"ERROR: EmailSender.Run :: {ex.Message}");
        }
    }
}
