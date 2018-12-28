﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Platformus.ExtensionManager
{
  public class Extension
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string Authors { get; set; }
    public string Version { get; set; }
    public IEnumerable<string> Files { get; set; }
  }
}