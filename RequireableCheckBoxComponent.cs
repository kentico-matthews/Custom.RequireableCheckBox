using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CMS.Helpers;
using Kentico.Forms.Web.Mvc;
using CustomFormComponent.RequireableCheckBoxComponent;

[assembly:RegisterFormComponent(RequireableCheckBoxComponent.IDENTIFIER, typeof(RequireableCheckBoxComponent), "{$requireablecheckboxcomponent.name$}", Description = "{$requireablecheckboxcomponent.description$}", IconClass = "icon-cb-check-preview", ViewName = "~/RequireableCheckBoxComponent/_RequireableCheckBox.cshtml")]

namespace CustomFormComponent.RequireableCheckBoxComponent
{
    /// <summary>
    /// Represents a checkbox form component that can be marked as required.
    /// </summary>
    public class RequireableCheckBoxComponent : FormComponent<RequireableCheckBoxProperties,bool>
    {
        /// <summary>
        /// Represents the <see cref="RequireableCheckBoxComponent"/> identifier.
        /// </summary>
        public const string IDENTIFIER = "RequireableCheckboxComponent";


        /// <summary>
        /// Represents the input value in the resulting HTML.
        /// </summary>
        [BindableProperty]
        public bool Value { get; set; }


        /// <summary>
        /// Gets name of the <see cref="Value"/> property.
        /// </summary>
        public override string LabelForPropertyName => nameof(Value);


        /// <summary>
        /// Gets the <see cref="Value"/>.
        /// </summary>
        public override bool GetValue()
        {
            return Value;
        }


        /// <summary>
        /// Sets the <see cref="Value"/>.
        /// </summary>
        public override void SetValue(bool value)
        {
            Value = value;
        }

        /// <summary>
        /// Performs validation of the requireable check box component.
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
