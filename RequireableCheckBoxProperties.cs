using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace CustomFormComponent.RequireableCheckBoxComponent
{

    public class RequireableCheckBoxProperties : FormComponentProperties<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxProperties"/> class.
        /// </summary>
        /// <remarks>
        /// The constructor initializes the base class to data type <see cref="FieldDataType.Boolean"/>.
        /// </remarks>
        public RequireableCheckBoxProperties() : base(FieldDataType.Boolean)
        {
        }


        /// <summary>
        /// Gets or sets the default value of the form component and underlying field.
        /// </summary>
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
