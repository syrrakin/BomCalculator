using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace BomLib.Model
{
    public abstract class BaseEntity : ObservableValidator
    {
        public Guid Id { get; set; }
    }
}
