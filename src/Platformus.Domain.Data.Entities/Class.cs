﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using ExtCore.Data.Entities.Abstractions;

namespace Platformus.Domain.Data.Entities
{
  /// <summary>
  /// Represents a class. The classes are used to describe the Platformus data model.
  /// </summary>
  public class Class : IEntity
  {
    public int Id { get; set; }
    public int? ClassId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string PluralizedName { get; set; }
    public bool IsAbstract { get; set; }

    public virtual Class Parent { get; set; }
    public virtual ICollection<Tab> Tabs { get; set; }
    public virtual ICollection<Member> Members { get; set; }
    public virtual ICollection<Object> Objects { get; set; }
  }
}