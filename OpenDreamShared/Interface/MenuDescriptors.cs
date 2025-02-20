﻿using System.Collections.Generic;
using Robust.Shared.Serialization.Manager.Attributes;

namespace OpenDreamShared.Interface {
    public class MenuDescriptor {
        public string Name;
        public List<MenuElementDescriptor> Elements;

        public MenuDescriptor(string name, List<MenuElementDescriptor> elements) {
            Name = name;
            Elements = elements;
        }
    }

    public class MenuElementDescriptor : ElementDescriptor {
        [DataField("command")]
        public string Command;
        [DataField("category")]
        public string Category;
        [DataField("can-check")]
        public bool CanCheck;
    }
}
