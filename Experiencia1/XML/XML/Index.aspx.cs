﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

namespace XML
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cmdCreateXml_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\AplicacionUniversidad.xml", FileMode.Create);
            XmlTextWriter w = new XmlTextWriter(fs, null);
            w.WriteStartDocument();
            w.WriteStartElement("AplicacionUniversidad");
            w.WriteComment("This file generated by the XmlTextWriter class.");
            w.WriteStartElement("Trabajador");
            w.WriteAttributeString("Codigo", "", "10");
            w.WriteAttributeString("Nombre", "", "Esteban");
            w.WriteAttributeString("Area", "", "Tesoreria");
            w.WriteStartElement("Sueldo");
            w.WriteString("5600");
            w.WriteEndElement();
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            lblXml.Text = @"File d:\AplicacionUniversidad.xml written succesfully.";
        }
    }
}