﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicazione_GreenHouseDB
{
    public partial class FormGestoreStruttura : Form
    {
<<<<<<< HEAD
        DataClassesDataContext db;
        public FormGestoreStruttura()
        {
            InitializeComponent();
            db = new DataClassesDataContext();
=======
        public FormGestoreStruttura()
        {
            InitializeComponent();
            DataClassesDataContext db = new DataClassesDataContext();
>>>>>>> dcd69f01d9360ef7a2c92bb1249f4121f4eaabe0
        }

        private void PermessiManovale_Click(object sender, EventArgs e)
        {
           // DataClassesDataContext db = new DataClassesDataContext();
            //TODO
            //dataGridView1.DataSource = foo;
        }

        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var foo = from a in db. select a;
=======
            //DataClassesDataContext db = new DataClassesDataContext();
            //TODO
            //dataGridView1.DataSource = foo;
>>>>>>> dcd69f01d9360ef7a2c92bb1249f4121f4eaabe0
        }
    }
}
