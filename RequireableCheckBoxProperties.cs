using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace CustomFormComponent.RequireableCheckBoxComponent
{

    public class RequireableCheckBoxProperties : FormComponentProperties<bool>
    {
        public RequireableCheckBoxProperties() : base(FieldDataType.Boolean)
        {
        }


        [DefaultValueEditingComponent(CheckBoxComponent.IDENTIFIER)]
        public override bool DefaultValue
        {
            get;
            set;
        }


        /// <summary>
        /// Represents the input value in the resulting HTML.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "{$kentico.formbuilder.component.checkbox.properties.text$}")]
        public string Text
        {
            get;
            set;
        }


        
    }
}
