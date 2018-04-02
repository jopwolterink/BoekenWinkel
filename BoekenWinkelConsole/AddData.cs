using System;
using BoekenWinkel;

namespace BoekenWinkelConsole
{
    public static class AddData
    {
       

        public static BoekenWinkel.BoekenWinkel GetData(){

            BoekenWinkel.BoekenWinkel bo = new BoekenWinkel.BoekenWinkel();



            bo.OpeningsTijden = "Maandag: 08:30 -- 17:00" +
                "Dinsdag: 08:30 -- 17:00" +
                "Woensdag: 08:30 -- 17:00" +
                "Donderdag: 08:30 -- 17:00" +
                "Vrijdag: 08:30 -- 17:00" +
                "Zaterdag: 08:30 -- 17:00" +
                "Zondag: Gesloten";

            bo.ContactInformatie = "Tel: 084-32588853, Adres: Hellinker 6, E-mail: info@thebookstore.nl";

            Boek boek = new Boek("1", "8324588285252", 1, 80, "The sluiper", "Jan schekking", new Afmeting(122, 21, 121), 200, 12.90m, 8);
            Boek boek1 = new Boek("1", "234546345636", 5, 40, "The hendrik valls", "Peter pieter", new Afmeting(132, 41, 221), 200, 13.90m, 3);
            Boek boek2 = new Boek("3", "005366245888", 1, 30, "The humen", "Valls Koning", new Afmeting(132, 41, 61), 200, 18.90m, 5);
            Boek boek3 = new Boek("1", "264567772245", 1, 30, "The hundergames", "Iris stengerik", new Afmeting(122, 51, 121), 200, 19.90m, 8);
            Boek boek4 = new Boek("2", "466246342422", 1, 70, "The Salinker", "Jop Wolterink", new Afmeting(122, 15, 21), 200, 13.90m, 3);
            Boek boek5 = new Boek("1", "006888828845", 1, 90, "AJ rop", "Teun Steggink", new Afmeting(12, 41, 121), 200, 14.90m, 9);

            Boek boek6 = new Boek("1", "425466660008", 1, 10, "Android Studio", "Ik kom dichterbij", new Afmeting(122, 41, 121), 200, 12.90m, 8);



            Tijdschrift tijd1 = new Tijdschrift("Ik ben slim", "Pietje puk", new Afmeting(123, 13, 74), 90, 12.90m, "6457565474332", 13, DayOfWeek.Monday, DayOfWeek.Saturday, 9);
            Tijdschrift tijd2 = new Tijdschrift("Space shuttle", "Andriaan kok", new Afmeting(129,235,35), 30, 19.90m, "56645654362", 123, DayOfWeek.Monday, DayOfWeek.Saturday, 8);
            Tijdschrift tijd3 = new Tijdschrift("Radio luisteren", "Jan beton", new Afmeting(123, 13, 74), 90, 12.90m, "6715576656672", 13, DayOfWeek.Monday, DayOfWeek.Saturday, 1);
            Tijdschrift tijd4 = new Tijdschrift("Hoe kijk ik door een raam", "Jan katon", new Afmeting(43, 123, 732), 90, 9.90m, "6477676757572", 133, DayOfWeek.Monday, DayOfWeek.Saturday, 5);
            Tijdschrift tijd5 = new Tijdschrift("Hoe wordt je dik", "Pietje puk", new Afmeting(123, 13, 74), 90, 40.90m, "67672478829107", 14, DayOfWeek.Monday, DayOfWeek.Saturday, 8);

            bo.Voorraad.Add(boek);
            bo.Voorraad.Add(boek1);
            bo.Voorraad.Add(boek2);
            bo.Voorraad.Add(boek3);
            bo.Voorraad.Add(boek4);
            bo.Voorraad.Add(boek5);
            bo.Voorraad.Add(boek6);

            bo.Voorraad.Add(tijd1);
            bo.Voorraad.Add(tijd2);
            bo.Voorraad.Add(tijd3);
            bo.Voorraad.Add(tijd4);
            bo.Voorraad.Add(tijd5);

            return bo;


        }


    }
}
