using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWeaponKeywords
{
    

    public class Settings
    {
        [SettingName("Search by EditorID containing 'silver'? ")]
        [Tooltip("Search using the EditorID, containing silver")]
        public bool SearchByEditorID = true;


        [SettingName("Quicksilver is Silver ")]
        [Tooltip("Treat Quicksilver as Silver")]
        public bool QuicksilverIsSilver = true;


        [SettingName("Debug setting")]
        [Tooltip("Enables additional info to be printed out, leave unticked")]
        public bool Debug = false;

    }
}