using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Native;
using System.Reflection;
using System.Collections;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }
        List<int> resources = new List<int>();
        private void schedulerControl1_AppointmentDrag(object sender, DevExpress.XtraScheduler.AppointmentDragEventArgs e) {

            if(resources.Count != 0 || e.SourceAppointment.ResourceIds.Count > 1) {
                if(resources.Count == 0) {
                    for(int i = 0; i < e.SourceAppointment.ResourceIds.Count; i++)
                        resources.Add(Convert.ToInt32(e.SourceAppointment.ResourceIds[i]));
                    resources.Remove(Convert.ToInt32(e.HitResource.Id));
                }
                for(int i = 0; i < resources.Count; i++)
                    e.EditedAppointment.ResourceIds.Add(resources[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Resource res1 = this.schedulerStorage1.CreateResource(1, "John");
            Resource res2 = this.schedulerStorage1.CreateResource(2, "Jane");
            Resource res3 = this.schedulerStorage1.CreateResource(3, "Bob");
            this.schedulerStorage1.Resources.AddRange(new Resource[] { res1, res2, res3 });
        }

        private void schedulerControl1_DragDrop(object sender, DragEventArgs e) {
            resources.Clear();
        }


    }
}