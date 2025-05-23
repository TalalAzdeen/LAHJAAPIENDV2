using AutoGenerator;
using AutoGenerator.Helper.Translation;
using LAHJAAPI.Models;
using System;

namespace V1.DyModels.VMs
{
    /// <summary>
    /// PlanFeature  property for VM Output.
    /// </summary>
    public class PlanFeatureOutputVM : ITVM
    {
        ///
        public Int32 Id { get; set; }
        //
        public string? Name { get; set; }
        //
        public string? Description { get; set; }
        ///
        public String? PlanId { get; set; }
        public PlanOutputVM? Plan { get; set; }
    }
}