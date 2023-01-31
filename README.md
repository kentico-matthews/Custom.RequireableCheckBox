# Requireable Checkbox Component
The out-of-box checkbox component in **Xperience 13 Form builder** does not allow you to mark checkbox fields as required. This does not account for use cases where the user should not be able to submit a form without agreeing to something. 

The form control in this repository allows you to add a checkbox that can be marked as required, in which case it will cause the form submission to fail validation when left un-checked.

## Steps to use
If you copy all three of the included files into a folder called **RequireableCheckBoxComponent** in the root directory of your live site, the component should be usable after a build. 

However, you likely have an existing setup with your own conventions for where to store custom form components and widgets, or don't want this folder cluttering up your root directory. In that case, you can follow these steps to get the form component working in your site.
1. Copy **RequireableCheckBoxProperties.cs** to the directory in your live site project where you are storing custom form component properties.
   1. Update the namespace in which this class is defined to match your other custom form component properties <br/><br/>

1. Copy **RequirableCheckBoxComponent.cs** to the drectory in your live site project where you are storing custom form components.
   1. Update the namespace in which this class is defined to match your other custom form components
   1. Update the **using** directive for **CustomFormComponent.RequireableCheckBoxComponent** to reflect this namespace.
   1. If your properties are stored in a separate namespace, add a using directive for it. <br/><br/>

1. Copy **_RequireableCheckBox.cshtml** to the directory in your live site project where you are storing custom form component views.
   1. Remove any **@using** directives from the view for libraries that are already included in **_ViewImports.cshtml**, or otherwise included by default.
   1. Update the **@using** directive for **CustomFormComponent.RequireableCheckBoxComponent** to reflect the namespace where your form component class is stored.
   1. Switch to **RequirableCheckBoxComponent.cs** and update the **RegisterFormComponent** assembly attribute, setting **ViewName** to the path where you saved the view
      * If you stored the view in **~/Views/Shared/FormComponents**, the **ViewName** parameter can be removed from the **RegisterFormComponent** attribute.