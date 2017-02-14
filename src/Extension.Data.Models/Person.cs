﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Models.Abstractions;

namespace Extension.Data.Models
{
  public class Person : IEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}