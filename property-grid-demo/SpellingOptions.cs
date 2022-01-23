using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_grid_demo
{
    [TypeConverterAttribute(typeof(SpellingOptionsConverter)), DescriptionAttribute("Expand to see the spelling options for the application.")]
    public class SpellingOptions
    {
        private bool _spellCheckWhileTyping = true;
        private bool _spellCheckCAPS = false;
        private bool _suggestCorrections = true;

        [DefaultValueAttribute(true)]
        public bool SpellCheckWhileTyping
        {
            get => _spellCheckWhileTyping;
            set => _spellCheckWhileTyping = value;
        }

        [DefaultValueAttribute(false)]
        public bool SpellCheckCAPS
        {
            get => _spellCheckCAPS;
            set => _spellCheckCAPS = value;
        }

        [DefaultValueAttribute(true)]
        public bool SuggestCorrections
        {
            get => _suggestCorrections;
            set => _suggestCorrections = value;
        }
    }
}