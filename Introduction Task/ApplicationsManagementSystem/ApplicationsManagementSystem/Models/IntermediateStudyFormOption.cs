//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationsManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IntermediateStudyFormOption
    {
        public int IntermediateStudyFormOptionID { get; set; }
        public int StudyFormOptionID { get; set; }
        public int StudyFormTypeID { get; set; }
    
        public virtual StudyFormOption StudyFormOption { get; set; }
        public virtual StudyFormType StudyFormType { get; set; }
    }
}