// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName ="Eda";
person1.LastName ="Demir";
person1.NationalIdentity =12345;
person1.DateOfBirthYear=1987;

PttManager ptt = new PttManager(new PersonManager());

ptt.GiveMask(person1);