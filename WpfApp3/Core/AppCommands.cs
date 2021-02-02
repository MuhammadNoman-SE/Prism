using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IAppCommands {
        public CompositeCommand SaveAllCommand { get;  }
    }
    public class AppCommands : IAppCommands
    {
        public CompositeCommand SaveAllCommand { get; } = new CompositeCommand();
    }
}
