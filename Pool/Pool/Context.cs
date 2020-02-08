using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Models;

namespace Context
{
    public class Context:IContext
    {

        List<Sportsman> sportsmens = new List<Sportsman>()
        {
            new Sportsman() {name = "Viktoriia Uvarova", phonenumber = "380665883835", yearsold = 18, rank = "Internationat Master of Sport"},
            new Sportsman() {name = "Ivan Ivarov", phonenumber = "380965993634", yearsold = 12, rank = "I"}
        };

        List<Coach> coachs = new List<Coach>()
        {
            new Coach() {name = "Krasnogor Tetyana", phonenumber = "380232323553", yearsold = 31, rank = "Honored Master of Sport"},
            new Coach() {name = "Petr Petrov", phonenumber = "38669664836", yearsold = 45, rank = "Master of Sport"}
        };

        List<POOL> pools = new List<POOL>()
        {
            new POOL() {namepool = "Akvarena", yearsopen = 1970, length = 50, location = "Klochkivska street 43/47" },
            new POOL() {namepool = "Kharkiv", yearsopen = 1950, length = 25, location = "Nemishlyanska"}
        };
    }

    public interface IContext
    {

    }
}
