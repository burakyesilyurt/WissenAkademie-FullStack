// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using BinarySerialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;

List<Member> memberList = new List<Member>();

Member member = new Member()
{
    MemberID = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe",
    Age = 23
};

Member member1 = new Member()
{
    MemberID = Guid.NewGuid(),
    FirstName = "Jeyn",
    LastName = "Doe",
    Age = 45
};

Member member2 = new Member()
{
    MemberID = Guid.NewGuid(),
    FirstName = "Tom",
    LastName = "Doe",
    Age = 28
};
memberList.AddRange(new Member[] { member, member1, member2 });

//Serialize(member);
SerializeList(memberList);

//Deserialize();
DeserializeList();

void DeserializeList()
{
    using (FileStream fs = new FileStream("member.txt", FileMode.Open, FileAccess.Read))
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        List<Member> memberList = (List<Member>)binaryFormatter.Deserialize(fs);
        foreach (Member member in memberList)
        {
            Console.WriteLine(member.ToString());
        }
        
        //WriteMember(member);
    }
}

void Deserialize()
{
    using (FileStream fs = new FileStream("member.txt", FileMode.Open, FileAccess.Read)) 
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        Member member = (Member)binaryFormatter.Deserialize(fs);
        Console.WriteLine(member.ToString());
        //WriteMember(member);
    }
}

void WriteMember(Member member)
{
    StringBuilder strMember = new StringBuilder();
    strMember.Append($"Member ID : {member.MemberID}\n" +
        $"Member Full Name : {member.FirstName} {member.LastName}\n" +
        $"Member Age : {member.Age}");
    Console.WriteLine(strMember.ToString());
}

void SerializeList(List<Member> memberList)
{
    FileStream fs = new FileStream("member.txt", FileMode.Create, FileAccess.Write);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.Serialize(fs, memberList);
    fs.Close();
}

void Serialize(Member member)
{
    FileStream fs = new FileStream("member.txt",FileMode.Create,FileAccess.Write);
    BinaryFormatter binaryFormatter = new BinaryFormatter();
    binaryFormatter.Serialize(fs,member);
    fs.Close();
}