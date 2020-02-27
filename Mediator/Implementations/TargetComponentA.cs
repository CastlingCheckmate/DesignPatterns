using System;

using MediatorPattern.Interfaces;

namespace MediatorPattern.Implementations
{

    public sealed class TargetComponentA : ITargetComponent
    {

        private IMediator _mediator;

        public TargetComponentA(IMediator mediator)
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
            Console.WriteLine("Instance of TargetComponentA received request from mediator...");
        }

    }

}