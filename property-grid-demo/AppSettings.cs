using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_grid_demo
{
    [DefaultPropertyAttribute("SaveOnClose")]
    public class AppSettings
    {
        private bool _saveOnClose = true;
        private string _greetingText = "Welcome to your application!";
        private int _maxRepeatRate = 10;
        private int _itemsInMRU = 4;
        private SpellingOptions _spellingOptions = new SpellingOptions { SpellCheckCAPS = true, SpellCheckWhileTyping = true, SuggestCorrections  = true};
        private string _defaultFileName;
        private bool _settingsChanged = false;
        private string _appVersion = "1.0";
        private Size _windowSize = new Size(100, 100);
        private Font _windowFont = new Font("Arial", 8, FontStyle.Regular);
        private Color _toolbarColor = SystemColors.Control;

        [CategoryAttribute("Document Settings"), DefaultValueAttribute(true)]
        public bool SaveOnClose
        {
            get => _saveOnClose;
            set => _saveOnClose = value;
        }

        [CategoryAttribute("Document Settings")]
        public Size WindowSize
        {
            get => _windowSize;
            set => _windowSize = value;
        }

        [CategoryAttribute("Document Settings")]
        public Font WindowFont
        {
            get => _windowFont;
            set => _windowFont = value;
        }

        [CategoryAttribute("Global Settings")]
        public Color ToolbarColor
        {
            get => _toolbarColor;
            set => _toolbarColor = value;
        }

        [CategoryAttribute("Global Settings"), ReadOnlyAttribute(true), DefaultValueAttribute("Welcome to your application!")]
        public string GreetingText
        {
            get => _greetingText;
            set => _greetingText = value;
        }

        [CategoryAttribute("Global Settings"), DefaultValueAttribute(4)]
        public int ItemsInMRUList
        {
            get => _itemsInMRU;
            set => _itemsInMRU = value;
        }

        [DescriptionAttribute("The rate in milliseconds that the text will repeat."), CategoryAttribute("Global Settings"), DefaultValueAttribute(10)]
        public int MaxRepeatRate
        {
            get => _maxRepeatRate;
            set => _maxRepeatRate = value;
        }

        [BrowsableAttribute(false), DefaultValueAttribute(false)]
        public bool SettingsChanged
        {
            get => _settingsChanged;
            set => _settingsChanged = value;
        }

        [CategoryAttribute("Version"), DefaultValueAttribute("1.0"), ReadOnlyAttribute(true)]
        public string AppVersion
        {
            get => _appVersion;
            set => _appVersion = value;
        }

        [TypeConverter(typeof(FileNameConverter)), CategoryAttribute("Document Settings")]
        public string DefaultFileName
        {
            get => _defaultFileName;
            set => _defaultFileName = value;
        }

        [TypeConverter(typeof(SpellingOptionsConverter)), CategoryAttribute("Spell Check Options")]
        public SpellingOptions SpellCheckOptions
        {
            get => _spellingOptions;
            set => _spellingOptions = value;
        }
    }
}