using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml;

namespace FootBall
{
  public class XmlParser
    {
        public DataTable dataTable = new DataTable();
        private string[] attributeNames = { "type", "name", "label", "enabled", "visible", "x", "y", "width", "height" };
        private bool flag;
    
        public XmlParser(){
            PopulateDatatableColumnForSpy(dataTable);
            }
    
        /// <summary>
        /// XMLContent takes input as a xml data and converts it into xmlnodes
        /// PopulateDatatableColumnForSpy creates columns in datatable
        /// </summary>
        /// <param name="XMLContent"></param>
        /// <returns>XmlNode</returns>
        public XmlNode ConvertXmlDataToNode(string XMLContent) {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLContent);
            XmlNode allXmlNodes = doc.DocumentElement;
            return allXmlNodes;
        }
        public void PopulateDatatableColumnForSpy(DataTable dataTable)
        {
               foreach (var attrubute in attributeNames)
              {
                 dataTable.Columns.Add(attrubute);
              }
            }
        }
        /// <summary>
        /// RecursiveData is recursive function which Ienumerates on each and every nodes of XML data which is passed initally
        /// </summary>
        /// <param name="node"></param>
        public void RecursiveData(XmlNode node)
        {
            if (flag)
            {
                DataRow dr = dataTable.NewRow();
                IsAttributePresent(node, dr);
                flag = false;
            }
            foreach (XmlNode n in node.ChildNodes)
            {
                DataRow dr1 = dataTable.NewRow();
                IsAttributePresent(n, dr1);
                if (n.HasChildNodes)
                {
                    RecursiveData(n);
                }
            }
        }
        /// <summary>
        /// attributeNames is static properties array for getting specific properties data from xml nodes(xml document)
        /// </summary>
        /// <param name="n"></param>
        /// n is xml node from which data to be taken
        /// <param name="dr"></param>
        /// dr is row in datatable 
        public void IsAttributePresent(XmlNode n, DataRow dr)
        {
            foreach (var item in attributeNames)
            {
                try
                {
                dr[item] = n.Attributes[item].Value;
                }
                catch (Exception ex)
                {
                Console.WriteLine(ex.message);
                }
            }
            dataTable.Rows.Add(dr);
        }
    }
}
