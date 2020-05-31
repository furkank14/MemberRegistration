using MemberRegistration.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.DependenceResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();

            //Console.WriteLine("Ad:");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("Soyad:");
            //string LastName = Console.ReadLine();
            //Console.WriteLine("Email:");
            //string Email = Console.ReadLine();
            //Console.WriteLine("Tc:");
            //string Tc = Console.ReadLine();
            //Console.WriteLine("Doğum Tarihi(/):");
            //string Birth = Console.ReadLine();

            //string[] b = Birth.Split('/');


            memberService.Add(new Member
            {
                //FirstName = FirstName,
                //LastName = LastName,
                //Email = Email,
                //TcNo = Tc,
                //DateOfBirth = new DateTime(Convert.ToInt32(b[2]), Convert.ToInt32(b[1]), Convert.ToInt32(b[0]))

                FirstName = "Furkan",
                LastName = "Karataş",
                Email = "furkan.karatas1414@gmail.com",
                TcNo = "22348507347",
                DateOfBirth = new DateTime(2005,10,27)

            });

            Console.WriteLine("Eklendi");

            Console.ReadLine();

        }
    }
}
