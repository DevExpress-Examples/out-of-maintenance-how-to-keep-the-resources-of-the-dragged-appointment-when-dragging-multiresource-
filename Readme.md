<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs)
<!-- default file list end -->
# How to keep the resources of the dragged appointment when dragging multiresource appointments


<p>When multiple resources are assigned to an appointment, dragging the appointment from one resource to another removes all resources from the appointment, except the one where the appointment was dropped.<br />
This is the designed behavior for this operation. This example illustrates how to override it to keep the resources of the dragged appointment, by using the AppointmentDrag event.</p>

<br/>


