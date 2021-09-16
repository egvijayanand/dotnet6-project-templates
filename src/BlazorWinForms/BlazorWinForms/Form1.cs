﻿using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlazorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = Startup.Services
            };

            blazor.RootComponents.Add<App>("#app");
            Controls.Add(blazor);
        }

    }
}