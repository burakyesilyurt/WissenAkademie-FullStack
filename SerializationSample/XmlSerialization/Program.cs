// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XmlSerialization;

List<Person> employeeList = new List<Person>()
{
    new Person()
    {
        PersonID = 1,
        FistName = "John",
        LastName = "Doe",
        Email = "john.doe@contoso.com",
        Phone = "646546464"
    },
    new Person()
    {
        PersonID = 2,
        FistName = "Jeyn",
        LastName = "Doe",
        Email = "jeyn.doe@contoso.com",
        Phone = "594942651"
    },
    new Person()
    {
        PersonID = 3,
        FistName = "Tom",
        LastName = "Doe",
        Email = "tom.doe@contoso.com",
        Phone = "555666884"
    }
};

string xmlData =  SerializeXml(employeeList);
//Console.WriteLine(xmlData);
Deserialize(xmlData);

void Deserialize(string xmlData)
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    StringReader strRead = new StringReader(xmlData);

    XmlReader xmlReader = new XmlTextReader(strRead);

    List<Person> empList = (List<Person>)serializer.Deserialize(xmlReader);
    WriteEmployee(empList);
}

void WriteEmployee(List<Person>? empList)
{
    StringBuilder strPerson = new StringBuilder();
    foreach (Person item in empList)
    {
        strPerson.Append($"Person ID : {item.PersonID}\n") ;
        strPerson.Append($"Person Name : {item.FistName}\n");
        strPerson.Append($"Person Last Name : {item.LastName}\n");
        strPerson.Append($"Email : {item.Email}\n");
        strPerson.Append($"Phone: {item.Phone}\n") ;

        strPerson.Append(new string('*', 100));
        strPerson.Append("\n");
    }
    Console.WriteLine(strPerson.ToString());
}

string SerializeXml(List<Person> employeeList)
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    TextWriter xmlWrite = new StringWriter();
    serializer.Serialize(xmlWrite, employeeList);
    return xmlWrite.ToString();
}