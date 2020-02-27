using MediatorPattern.Interfaces;

namespace MediatorPattern.Implementations
{

    public sealed class ConcreteMediator : IMediator
    {

        private TargetComponentA _a1;
        private TargetComponentA _a2;
        private TargetComponentB _b;
        private TargetComponentC _c;

        public TargetComponentA A1
        {
            get =>
                _a1;

            private set =>
                _a1 = value;
        }

        public TargetComponentA A2
        {
            get =>
                _a2;

            private set =>
                _a2 = value;
        }

        public TargetComponentB B
        {
            get =>
                _b;

            private set =>
                _b = value;
        }

        public TargetComponentC C
        {
            get =>
                _c;

            private set =>
                _c = value;
        }

        public ConcreteMediator()
        {
            A1 = new TargetComponentA(this);
            A2 = new TargetComponentA(this);
            B = new TargetComponentB(this);
            C = new TargetComponentC(this);
        }

        public void Notify(ITargetComponent sender, params object[] parameters)
        {
            if (sender == _a1)
            {
                HandleRequestOfA1(parameters);
            }
            if (sender == _a2)
            {
                HandleRequestOfA2(parameters);
            }
            if (sender == _b)
            {
                HandleRequestOfB(parameters);
            }
            if (sender == _c)
            {
                HandleRequestOfC(parameters);
            }
        }

        private void HandleRequestOfA1(params object[] parameters)
        {
            _a2.Receive(parameters);
            _b.Receive(parameters);
        }

        private void HandleRequestOfA2(params object[] parameters)
        {
            _c.Receive(parameters);
        }

        private void HandleRequestOfB(params object[] parameters)
        {
            _a1.Receive(parameters);
            _a2.Receive(parameters);
            _c.Receive(parameters);
        }

        private void HandleRequestOfC(params object[] parameters)
        {
            _b.Receive(parameters);
        }

    }

}