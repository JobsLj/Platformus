﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Extensions.Localization;
using Platformus.Barebone;
using Platformus.Barebone.Backend.Metadata;

namespace Platformus.Forms.Backend.Metadata
{
  public class Metadata : MetadataBase
  {
    public override IEnumerable<Script> GetScripts(IRequestHandler requestHandler)
    {
      return new Script[]
      {
        new Script("/wwwroot.areas.backend.js.platformus.forms.min.js", 3000)
      };
    }

    public override IEnumerable<MenuGroup> GetMenuGroups(IRequestHandler requestHandler)
    {
      IStringLocalizer<Metadata> localizer = requestHandler.GetService<IStringLocalizer<Metadata>>();

      return new MenuGroup[]
      {
        new MenuGroup(
          localizer["Content"],
          1000,
          new MenuItem[]
          {
            new MenuItem("/backend/forms", localizer["Forms"], 3000, new string[] { Permissions.BrowseForms })
          }
        )
      };
    }
  }
}