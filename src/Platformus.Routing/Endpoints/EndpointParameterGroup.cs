// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Platformus.Routing.Endpoints
{
  public class EndpointParameterGroup
  {
    public string Name { get; set; }
    public IEnumerable<EndpointParameter> Parameters { get; set; }

    public EndpointParameterGroup(string name, params EndpointParameter[] parameters)
    {
      this.Name = name;
      this.Parameters = parameters;
    }
  }
}