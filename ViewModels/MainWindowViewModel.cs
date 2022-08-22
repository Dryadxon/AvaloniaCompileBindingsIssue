using System.Collections.Generic;
using AvaloniaDemo.Models;

namespace AvaloniaDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public IDictionary<string, object?> Dict {get;} = new Dictionary<string, object?>()
        {
            ["Foo"] = null,
            ["Bar"] = null,
        };

        public ICollection<string> DictKeysWorkAround => this.Dict.Keys;

        public IFoo<string, object?> Foo {get; } = new Foo<string, object?>()
        {
            ["Hello"] = null,
            ["World"] = null,
        };
    }
}
