using Aeronave.Application.UseCases.DomainEventHandler.Aeronave;
using MassTransit;
using Moq;
using System.Threading.Tasks;
using Aeronave.Domain.Event;
using SharedKernel.Core;
using Xunit;

namespace Aeronave.Test.Application.UseCases.DomainEventHandler.Aeronave;

public class PublishIntegrationEventWhenAeronaveCreadoHandlerTests
{
    private readonly Mock<IPublishEndpoint> _publishEndpoint;

    public PublishIntegrationEventWhenAeronaveCreadoHandlerTests()
    {
        _publishEndpoint = new Mock<IPublishEndpoint>();
    }

    [Fact]
    public async Task IsHandler_OkAsync()
    {
        var handler = new PublishIntegrationEventWhenAeronaveCreadoHandler(_publishEndpoint.Object);
    }
}