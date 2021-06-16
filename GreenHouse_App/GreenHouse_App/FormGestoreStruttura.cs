﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse_App
{
    public partial class FormGestoreStruttura : Form
    {
        public ProvaGreenHouseDataContext db;
        public FormGestoreStruttura()
        {
            InitializeComponent();
            db = new ProvaGreenHouseDataContext();
        }


        private void RevisioniInScadenza_Click(object sender, EventArgs e)
        {

            var foo = from a in db.MACCHINARI
                      where (a.DataRevisione - DateTime.Now).Days < 10
                      select a;

            dataGridView1.DataSource = foo;
        }


    }
}