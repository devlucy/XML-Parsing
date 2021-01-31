# XML-Parsing

XML Parser converts xml data to object.
static array used in class is for attributes of xml file. 


```
XmlParser parser = new XmlParser();
parser.RecursiveData(parser.ConvertXmlDataToNode(File.ReadAllText(@"D:\domsss.xml")));
var dataTable1 = parser.dataTable;
```
Sample file content
```
<?xml version="1.0" encoding="UTF-8"?>
<XCUIElementTypeApplication type="XCUIElementTypeApplication" name="123" label="123" enabled="true" visible="true" x="0" y="0" width="375" height="667">
 <XCUIElementTypeWindow type="XCUIElementTypeWindow" enabled="true" visible="true" x="0" y="0" width="375" height="667">
  <XCUIElementTypeOther type="XCUIElementTypeOther" enabled="true" visible="true" x="0" y="0" width="375" height="667">
  </XCUIElementTypeOther>
 </XCUIElementTypeWindow>
</XCUIElementTypeApplication>
```
