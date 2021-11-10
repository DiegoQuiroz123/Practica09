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
    public partial class XML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void cmdCreateXml_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\SuperProductList.xml", FileMode.Create);
            XmlTextWriter w = new XmlTextWriter(fs, null);
            w.WriteStartDocument();
            w.WriteStartElement("SuperProductList");
            w.WriteComment("This file generated by the XmlTextWriter class.");
            //1er producto
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "1");
            w.WriteAttributeString("Nombre", "", "Silla");
            w.WriteStartElement("Price");
            w.WriteString("50.12");
            w.WriteEndElement();
            w.WriteEndElement();

            //2do producto
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "2");
            w.WriteAttributeString("Nombre", "", "Television");
            w.WriteStartElement("Price");
            w.WriteString("1299.49");
            w.WriteEndElement();
            w.WriteEndElement();

            //3er producto
            w.WriteStartElement("Product");
            w.WriteAttributeString("ID", "", "3");
            w.WriteAttributeString("Nombre", "", "Audifonos");
            w.WriteStartElement("Price");
            w.WriteString("39.79");
            w.WriteEndElement();
            w.WriteEndElement();

            w.WriteEndDocument();
            
            w.Close();
            lblXml.Text = @"File d:\SuperProductList.xml written succesfully.";
        }

        protected void cmdReadXml_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\SuperProductList.xml", FileMode.Open);
            XmlTextReader r = new XmlTextReader(fs);

            StringWriter writer = new StringWriter();

            while (r.Read())
            {
                writer.Write("<b>Type:</b>");
                writer.Write(r.NodeType.ToString());
                writer.Write("<br>");
                if (r.Name != "")
                {
                    writer.Write("<b>Name:</b>");
                    writer.Write(r.Name);
                    writer.Write("<br>");
                }
                if (r.Value != "")
                {
                    writer.Write("<b>Value:</b>");
                    writer.Write(r.Value);
                    writer.Write("<br>");
                }
                if (r.AttributeCount > 0)
                {
                    writer.Write("<b>Attributes:</b>");
                    for (int i = 0; i < r.AttributeCount; i++)
                    {
                        writer.Write(" ");
                        writer.Write(r.GetAttribute(i));
                        writer.Write(" ");
                    }
                    writer.Write("<br>");
                }
                writer.Write("<br>");
            }
            r.Close();

            lblXml.Text = writer.ToString();
        }

        protected void cdmReadXmlAsObjects_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"d:\SuperProductList.xml", FileMode.Open);
            XmlTextReader r = new XmlTextReader(fs);

            List<Product> products = new List<Product>();

            while (r.Read())
            {
                if (r.NodeType == XmlNodeType.Element && r.Name == "Product")
                {
                    Product newProduct = new Product();
                    newProduct.ID = Int32.Parse(r.GetAttribute(0));
                    newProduct.Nombre = r.GetAttribute(1);

                    while (r.NodeType != XmlNodeType.EndElement)
                    {
                        r.Read();

                        if (r.Name == "Price")
                        {
                            while (r.NodeType != XmlNodeType.EndElement)
                            {
                                r.Read();
                                if (r.NodeType ==XmlNodeType.Text)
                                {
                                    newProduct.Precio = Decimal.Parse(r.Value);
                                }
                            }
                        }
                    }
                    products.Add(newProduct);
                }
            }
            r.Close();
            gridResults.DataSource = products;
            gridResults.DataBind();
        }
    }
}