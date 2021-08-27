<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635465/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E476)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs)
<!-- default file list end -->
# How to keep the resources of the dragged appointment when dragging multiresource appointments


<p>When multiple resources are assigned to an appointment, dragging the appointment from one resource to another removes all resources from the appointment, except the one where the appointment was dropped.<br />
This is the designed behavior for this operation. This example illustrates how to override it to keep the resources of the dragged appointment, by using the AppointmentDrag event.</p>

<br/>


