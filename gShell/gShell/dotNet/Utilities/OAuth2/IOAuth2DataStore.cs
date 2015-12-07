﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gShell.dotNet.Utilities.OAuth2
{
    /// <summary>Save and load the OAuth Info to and from a datastore.</summary>
    public interface IOAuth2DataStore
    {
        public OAuth2Info LoadInfo();
        public void SaveInfo(OAuth2Info infoToSave);
    }
}