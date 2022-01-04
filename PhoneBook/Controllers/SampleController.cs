using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System;
using System.Collections;
using System.Collections.Generic;
namespace PhoneBook.Controllers
{
    public class SampleController : Controller
    {

        public ArrayList myArray = new ArrayList();
        public void ShowName()
        {
            // Initilize Person Model with fake values
            myArray.Add(new Person("Farshad", "Nematpour", "09160000000", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("Dani", "NikNasab", "09359995874", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("saadegh", "Shakeri", "09026458824", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("Mahmood", "Farhaadi", "09333935279", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("Zohre", "Zaaaki", "09370587065", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("Kaave", "KavianPoor", "09333647855", "Iran,Ahvaz,Yoosefi"));
            myArray.Add(new Person("Karim", "Zeheiri", "0613589655", "Iran,Ahvaz,Yoosefi"));

            // gather all people in  query1
            //var query1 = from Person p in myArray select p;
            // if condition for find exact people based User-Search
            // forech ( item in query1) { if (userSerachInTextBox == item.name|item.Family|item.Phone|item.Address| ) }
        }


        public void Peoples()
        {

            var Peoples = new List<string>()
        {
            "Farshad nematpour",
            "Mohamad nezami",
            "Ali saaki",
            "Morteza azizi"
        };


            ViewBag.Peoples = Peoples;
        }


        





    }
}