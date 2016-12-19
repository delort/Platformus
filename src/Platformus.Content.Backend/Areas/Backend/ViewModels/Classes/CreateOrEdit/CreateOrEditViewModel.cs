﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Platformus.Barebone.Backend;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.Content.Backend.ViewModels.Classes
{
  public class CreateOrEditViewModel : ViewModelBase
  {
    public int? Id { get; set; }

    [Display(Name = "Parent class (abstract only)")]
    public int? ClassId { get; set; }
    public IEnumerable<Option> ClassOptions { get; set; }

    [Display(Name = "Code")]
    [Required]
    [StringLength(32)]
    public string Code { get; set; }

    [Display(Name = "Name")]
    [Required]
    [StringLength(64)]
    public string Name { get; set; }

    [Display(Name = "Pluralized name")]
    [Required]
    [StringLength(64)]
    public string PluralizedName { get; set; }

    [Display(Name = "Is abstract")]
    public bool IsAbstract { get; set; }

    [Display(Name = "Is standalone")]
    public bool IsStandalone { get; set; }

    [Display(Name = "Default view name")]
    [StringLength(32)]
    public string DefaultViewName { get; set; }
  }
}