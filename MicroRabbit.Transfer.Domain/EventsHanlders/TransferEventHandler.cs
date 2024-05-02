using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventsHanlders
{
    public class TransferEventHandler : IEventHandler<TransferCreateEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }


        public Task Handle(TransferCreateEvent @event)
        {
            var transaction = new TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAccount = @event.Amount
            };

            _transferRepository.AddTransferLog(transaction);

            return Task.CompletedTask;
        }
    }
}
