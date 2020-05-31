using System.Collections.Generic;

namespace Day08_DictionariesAndMaps
{
    public class PhoneBook
    {
        private readonly IDictionary<string, string> _numbersByName;

        public PhoneBook()
        {
            _numbersByName = new Dictionary<string, string>();
        }

        public string this[string name]
        {
            get => _numbersByName.ContainsKey(name)
                ? _numbersByName[name]
                : null;
            set => _numbersByName[name] = value;
        }
    }
}
