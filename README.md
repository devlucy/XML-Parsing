# XML-Parsing

It allows user to parse xml data to object form

USAGE:
XmlParser parser = new XmlParser();
parser.RecursiveData(parser.ConvertXmlDataToNode(File.ReadAllText(@"D:\domsss.xml")));
var dataTable1 = parser.dataTable;
