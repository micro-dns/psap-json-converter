﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace json_csv_convert
{
    public partial class About : Form
    {
        String app_name = "JSON-CSV Converter";
        String app_about = "Developed by Desktop Network Services\n\nStudents: Barryn Chun";

        public About()
        {
            InitializeComponent();

            AppName.Text = app_name;
            AppAbout.Text = app_about;
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
