using System;
using System.Collections.Generic;
using System.Linq;

using ProxyPattern.Interfaces;

namespace ProxyPattern.Implementations
{

    public sealed class ProxyService : IService
    {

        private ConcreteService _target;
        private IEnumerable<string> _logs;

        public ProxyService(ConcreteService target)
        {
            Target = target;
            Logs = Enumerable.Empty<string>();
        }

        private ConcreteService Target
        {
            get => _target ??
                throw new ArgumentNullException(nameof(Target));

            set => _target = value;
        }

        public IEnumerable<string> Logs
        {
            get => _logs ??
                throw new ArgumentNullException(nameof(Logs));

            private set => _logs = value;
        }

        public void SomeOperation()
        {
            Logs = Logs.Concat(new[] { "Before Target.SomeOperation() method call..." });
            Target.SomeOperation();
            Logs = Logs.Concat(new[] { "After Target.SomeOperation() method call..." });
        }

        public void SomeOtherOperation()
        {
            Logs = Logs.Concat(new[] { "Before Target.SomeOtherOperation() method call..." });
            Target.SomeOtherOperation();
            Logs = Logs.Concat(new[] { "After Target.SomeOtherOperation() method call..." });
        }

    }

}