﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

(function (platformus) {
  platformus.endpointParameterEditors = platformus.endpointParameterEditors || [];
  platformus.endpointParameterEditors.dropDownList = {};
  platformus.endpointParameterEditors.dropDownList.create = function (container, endpointParameter) {
    createField(endpointParameter).appendTo(container);
  };

  function createField(endpointParameter) {
    var identity = platformus.endpointParameterEditors.base.getIdentity(endpointParameter);
    var field = $("<div>").addClass("form__field").addClass("field");

    platformus.controls.label.create({ identity: identity, text: endpointParameter.name }).appendTo(field);
    platformus.controls.dropDownList.create(
      {
        identity: identity,
        options: endpointParameter.options,
        value: platformus.endpointParameterEditors.base.getValue(endpointParameter)
      }
    ).attr("data-endpoint-parameter-code", endpointParameter.code).appendTo(field)
      .change(platformus.endpointParameterEditors.base.changed)
      .appendTo(field);

    return field;
  }
})(window.platformus = window.platformus || {});