﻿// Copyright © 2018 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Barebone.Backend.ViewModels.Shared;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.ECommerce.Backend.ViewModels.Attributes
{
  public class IndexViewModel : ViewModelBase
  {
    public int FeatureId { get; set; }
    public GridViewModel Grid { get; set; }
  }
}