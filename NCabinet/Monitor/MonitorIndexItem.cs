using System.Collections.Generic;
using System.Linq;

namespace NCabinet.Monitor
{
    internal class MonitorIndexItem
    {
        private List<string> _keys;
        private Dictionary<char, MonitorIndexItem> _dictionary;

        public MonitorIndexItem() { }
        public MonitorIndexItem(string word, string key)
        {
            Add(word, key);
        }

        public void Add(string word, string key)
        {
            if (word == null)
                return;

            if (word.Length == 0)
            {
                if (_keys == null)
                    _keys = new List<string>();

                _keys.Add(key);
                return;
            }

            if (_dictionary == null)
                _dictionary = new Dictionary<char, MonitorIndexItem>();

            if (!_dictionary.ContainsKey(word[0]))
                _dictionary[word[0]] = new MonitorIndexItem();

            _dictionary[word[0]].Add(word.Substring(1), key);
        }

        public List<string> Search(string word)
        {
            var result = new List<string>();
            if (word == null)
                return result;

            if (word.Length == 0)
                return AllKeys;

            if (_dictionary == null || !_dictionary.ContainsKey(word[0]))
                return result;

            return _dictionary[word[0]].Search(word.Substring(1));
        }

        public void Remove(string word, string key)
        {
            if (word == null)
                return;

            if (word.Length > 0)
            {
                if (_dictionary != null && _dictionary.ContainsKey(word[0]))
                    _dictionary[word[0]].Remove(word.Substring(1), key);

                return;
            }

            if (_keys != null && _keys.Contains(key))
                _keys.Remove(key);
        }

        public List<string> AllKeys
        {
            get 
            { 
                var keys = new List<string>();
                if (_keys != null)
                    keys.AddRange(keys);
                if (_dictionary != null)
                    foreach (var item in _dictionary)
                        keys.AddRange(item.Value.AllKeys);
                return keys.Distinct().ToList();
            }
        }
    }
}
