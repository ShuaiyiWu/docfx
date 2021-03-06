// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. See LICENSE file in the project root for full license information.

var mrefCommon = require('./ManagedReference.common.js');

exports.transform = function (model) {
  model = mrefCommon.transform(model);
  if (model.type.toLowerCase() === "enum") {
    model.isClass = false;
    model.isEnum = true;
  }

  model._disableToc = model._disableToc || !model._tocPath || (model._navPath === model._tocPath);
  return {item: model};
}