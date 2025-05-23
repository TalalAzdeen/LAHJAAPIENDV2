using AutoGenerator;
using AutoGenerator.Helper.Translation;
using LAHJAAPI.Models;
using System;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// EventRequest  property for VM Update.
    /// </summary>
    public class EventRequestUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public EventRequestCreateVM? Body { get; set; }
    }
}