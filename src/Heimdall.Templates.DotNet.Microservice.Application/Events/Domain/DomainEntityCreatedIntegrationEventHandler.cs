using AutoMapper;
using BeHeroes.CodeOps.Abstractions.Events;
using Confluent.Kafka;
using System.Threading;
using System.Threading.Tasks;

namespace Heimdall.Templates.DotNet.Microservice.Application.Events.Domain
{
    public class DomainEntityCreatedIntegrationEventHandler : IEventHandler<DomainEntityCreatedIntegrationEvent>
    {
        private readonly IMapper _mapper;

        private readonly IProducer<Ignore, IIntegrationEvent> _producer;

        public DomainEntityCreatedIntegrationEventHandler(IMapper mapper, IProducer<Ignore, IIntegrationEvent> producer)
        {
            _mapper = mapper;
            _producer = producer;
        }

        public Task Handle(DomainEntityCreatedIntegrationEvent notification, CancellationToken ct = default)
        {
            //TODO: Emit OTCL trace
            throw new System.NotImplementedException();
        }
    }
}