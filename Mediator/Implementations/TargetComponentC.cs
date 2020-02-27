using System;

using MediatorPattern.Interfaces;

namespace MediatorPattern.Implementations
{

    public sealed class TargetComponentC : ITargetComponent
    {

        private IMediator _mediator;

        public TargetComponentC(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Mediator =>
            _mediator;

        public void TargetComponentAOperation(params object[] parameters)
        {
            _mediator.Notify(this, parameters);
        }

        public void Receive(params object[] parameters)
        {
            Console.WriteLine("Instance of TargetComponentC received request from mediator...");
        }

    }

}