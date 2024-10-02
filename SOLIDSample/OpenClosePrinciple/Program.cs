// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//using OpenClosePrinciple;

//Employee employee = new Employee()
//{
//    EmployeeID = 1,
//    FirstName = "John",
//    LastName = "Doe",
//    Email = "john.doe@contoso.com"
//};

////MSSQLDB
//IDatabase mssqlDb = new MSSQLDatabase();
//EmployeeManager managerSQL = new EmployeeManager(mssqlDb);
//managerSQL.AddEmployee(employee);

////ORACLE DB
//IDatabase oracle = new OracleDatabase();
//EmployeeManager managerOracle = new EmployeeManager(oracle);
//managerOracle.AddEmployee(employee);

////ELK Db
//IDatabase elk = new ELKDatabase();
//EmployeeManager managerElk = new EmployeeManager(elk);
//managerElk.AddEmployee(employee);


//Araba Uygulaması
using OpenClosePrinciple.OCP;

Araba araba = new Araba("Kırmızı");
BildirimServisi.ArabanınDurumu(araba);

ElektirkliDepoServisi elektrik = new ElektirkliDepoServisi();
elektrik.SarjEt(araba);
MotorServis motor = new MotorServis(elektrik);
motor.MotorCalistir(araba);
BildirimServisi.ArabanınDurumu(araba);

motor.MotoruDurdur(araba);
BildirimServisi.ArabanınDurumu(araba);


