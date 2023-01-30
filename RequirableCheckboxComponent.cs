using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CMS.Helpers;
using Kentico.Forms.Web.Mvc;
using CustomFormComponent.RequireableCheckBoxComponent;

[assembly:RegisterFormComponent(RequireableCheckBoxComponent.IDENTIFIER, typeof(RequireableCheckBoxComponent), "{$requireablecheckboxcomponent.name$}", Description = "{$requireablecheckboxcomponent.description$}", IconClass = "icon-cb-check-preview", ViewName = "~/RequireableCheckBoxComponent/_RequireableCheckBox.cshtml")]

namespace CustomFormComponent.RequireableCheckBoxComponent
{
    public class RequireableCheckBoxComponent : FormComponent<RequireableCheckBoxProperties,bool>
    {
        public const string IDENTIFIER = "RequireableCheckboxComponent";


        // Specifies the property is used for data binding by the form builder
        [BindableProperty]
        // The value of the checkbox
        public bool Value { get; set; }


        // Gets the value of the form field instance passed from a view where the instance is rendered
        public override bool GetValue()
        {
            return Value;
        }


        // Sets the default value of the form field instance
        public override void SetValue(bool value)
        {
            Value = value;
        }

        /// <summary>
        /// Performs validation of the reCAPTCHA component.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>A collection that holds failed-validation information.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            //if the checkbox is not checked but is required
            if(!Value && Properties.Required)
            {
                errors.Add(new ValidationResult(ResHelper.GetString("{$requireablecheckboxcomponent.notchecked$}")));
            }

            return errors;
        }

    }
}
