﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Platformus.Barebone.Backend;

namespace Platformus.Domain
{
  public class MicrocontrollerParameter
  {
    public string Code { get; set; }
    public string Name { get; set; }
    public string JavaScriptEditorClassName { get; set; }
    public bool IsRequired { get; set; }
    public IEnumerable<Option> Options { get; set; }

    public MicrocontrollerParameter(string code, string name, string javaScriptEditorClassName, bool isRequired = false)
    {
      this.Code = code;
      this.Name = name;
      this.JavaScriptEditorClassName = javaScriptEditorClassName;
      this.IsRequired = isRequired;
    }

    public MicrocontrollerParameter(string code, string name, IEnumerable<Option> options, string javaScriptEditorClassName, bool isRequired = false)
      : this(code, name, javaScriptEditorClassName, isRequired)
    {
      this.Options = options;
    }
  }
}