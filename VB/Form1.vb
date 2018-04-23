Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native
Imports System.Reflection
Imports System.Collections

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

		End Sub
		Private resources As List(Of Integer) = New List(Of Integer)()
		Private Sub schedulerControl1_AppointmentDrag(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs) Handles schedulerControl1.AppointmentDrag

			If resources.Count <> 0 OrElse e.SourceAppointment.ResourceIds.Count > 1 Then
				If resources.Count = 0 Then
					For i As Integer = 0 To e.SourceAppointment.ResourceIds.Count - 1
						resources.Add(Convert.ToInt32(e.SourceAppointment.ResourceIds(i)))
					Next i
					resources.Remove(Convert.ToInt32(e.HitResource.Id))
				End If
				Dim j As Integer = 0
				Do While j < resources.Count
					e.EditedAppointment.ResourceIds.Add(resources(j))
					j += 1
				Loop
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim res1 As New Resource(1, "John")
			Dim res2 As New Resource(2, "Jane")
			Dim res3 As New Resource(3, "Bob")
			Me.schedulerStorage1.Resources.AddRange(New Resource() { res1, res2, res3 })
		End Sub

		Private Sub schedulerControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles schedulerControl1.DragDrop
			resources.Clear()
		End Sub


	End Class
End Namespace