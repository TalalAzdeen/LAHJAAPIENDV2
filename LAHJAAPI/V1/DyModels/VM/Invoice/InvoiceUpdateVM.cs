using AutoGenerator;
using AutoGenerator.Helper.Translation;
using LAHJAAPI.Models;
using System;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// Invoice  property for VM Update.
    /// </summary>
    public class InvoiceUpdateVM : ITVM
    {
        ///
        public string? Id { get; set; }
        ///
        public InvoiceCreateVM? Body { get; set; }
    }
}