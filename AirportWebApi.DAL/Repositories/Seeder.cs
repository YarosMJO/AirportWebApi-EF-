﻿using AirportWebApi.DAL.Models;
using System;
using System.Collections.Generic;

namespace Repositories.Seeder
{
    public class Seeder
    {
        public readonly List<Pilot> Pilots = new List<Pilot>()
        {
             new Pilot(){ Name="Nikolas", Surname="Morreti",Birthday=new DateTime(1415, 7, 19),Experience=1},
                  new Pilot(){ Name="Alessio", Surname="Rossi",Birthday=new DateTime(1404, 6, 21),Experience=3},
                  new Pilot(){ Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(1414, 3, 17),Experience=4},
                  new Pilot(){ Name="Beppe", Surname="Mancini",Birthday=new DateTime(1406, 1, 14),Experience=7},
                  new Pilot(){ Name="Adelaide", Surname="Giordano",Birthday=new DateTime(1998, 8, 14),Experience=2}
        };

        public readonly List<FlightAttendant> FlightAttendants = new List<FlightAttendant>()
        {
             new FlightAttendant(){ Name="Natali", Surname="Smith",Birthday=new DateTime(1415, 7, 19)},
                  new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)},
                  new FlightAttendant(){ Name="Olia", Surname="Howard",Birthday=new DateTime(1998, 8, 14)}
        };

        public readonly List<Crew> Crews = new List<Crew>()
          {
              new Crew(){Pilot=new Pilot(){Name="Alessio", Surname="Rossi",Birthday=new DateTime(1404, 6, 21),Experience=3},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},
              new Crew(){Pilot=new Pilot(){ Name="Adelaide", Surname="Giordano",Birthday=new DateTime(1998, 8, 14),Experience=2},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},
              new Crew(){Pilot=new Pilot(){ Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(1414, 3, 17),Experience=4},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}}
          };

        static DateTime now = DateTime.Now;

        public readonly List<Plane> Planes = new List<Plane>()
          {
              new Plane(){ Name="Ан-1",Type = new PlaneType(){ Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114},LifeTime = TimeSpan.FromTicks(14000000),ReleaseDate = now},
              new Plane(){ Name="Ан-2",Type = new PlaneType(){Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114 },LifeTime = TimeSpan.FromTicks(14000000),ReleaseDate = now},
              new Plane(){Name="Ан-3",Type = new PlaneType(){ Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114},LifeTime = TimeSpan.FromTicks(14000000),ReleaseDate = now},
              new Plane(){ Name="Ан-1",Type = new PlaneType(){ Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114},LifeTime = TimeSpan.FromTicks(14000000),ReleaseDate = now},
              new Plane(){ Name="Ан-2",Type = new PlaneType(){ Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114},LifeTime = TimeSpan.FromTicks(14000000),ReleaseDate = now}
          };

        public readonly List<PlaneType> PlaneTypes = new List<PlaneType>()
          {
              new PlaneType(){Carrying = 100, LifeTime = TimeSpan.FromTicks(14000000),Model="Model1",SeatsCapacity = 114},
              new PlaneType(){Carrying = 95, LifeTime = TimeSpan.FromTicks(14000000),Model="Model2",SeatsCapacity = 100},
              new PlaneType(){Carrying = 87, LifeTime = TimeSpan.FromTicks(14000000),Model="Model3",SeatsCapacity = 80},

          };
        public readonly List<Flight> Flights = new List<Flight>()
          {
              new Flight(){ArrivalTime=now,DeparturePoint = "Adelaida",DepartureTime = now, Destination="Boston",
                  Tickets = new List<Ticket>(){new Ticket() {Price = 50,FlightNumber = 1},
              new Ticket() {Price = 60,FlightNumber = 1},
              new Ticket() {Price = 70,FlightNumber = 1}} },
              new Flight(){ArrivalTime=now,DeparturePoint = "Oslo",DepartureTime = now, Destination="Alabama",
                  Tickets = new List<Ticket>(){ new Ticket() {Price = 80,FlightNumber = 2},
              new Ticket() {Price = 90,FlightNumber = 2},
              new Ticket() {Price = 50,FlightNumber = 2}} },
              new Flight(){ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                  Tickets = new List<Ticket>(){ new Ticket() {Price = 50,FlightNumber = 3},
              new Ticket() {Price = 40,FlightNumber = 3},
              new Ticket() {Price = 14,FlightNumber = 3}} },
              new Flight(){ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                  Tickets = new List<Ticket>(){new Ticket() {Price = 50,FlightNumber = 4},
              new Ticket() {Price = 50,FlightNumber = 4},
              new Ticket() {Price = 70,FlightNumber = 4}} },
              new Flight(){ArrivalTime=now,DeparturePoint = "Pitsburg",DepartureTime = now, Destination="NewYork",
                  Tickets = new List<Ticket>(){ new Ticket() {Price = 70,FlightNumber = 5},
              new Ticket() {Price = 10,FlightNumber = 5},
              new Ticket() {Price = 14,FlightNumber = 5},
              new Ticket() {Price = 100,FlightNumber = 5}} }
          };
        public readonly List<Ticket> Tickets = new List<Ticket>() {
              new Ticket() {Price = 50,FlightNumber = 1},
              new Ticket() {Price = 60,FlightNumber = 1},
              new Ticket() {Price = 70,FlightNumber = 1},
              new Ticket() {Price = 80,FlightNumber = 2},
              new Ticket() {Price = 90,FlightNumber = 2},
              new Ticket() {Price = 50,FlightNumber = 2},
              new Ticket() {Price = 50,FlightNumber = 3},
              new Ticket() {Price = 40,FlightNumber = 3},
              new Ticket() {Price = 14,FlightNumber = 3},
              new Ticket() {Price = 50,FlightNumber = 4},
              new Ticket() {Price = 50,FlightNumber = 4},
              new Ticket() {Price = 70,FlightNumber = 4},
              new Ticket() {Price = 70,FlightNumber = 5},
              new Ticket() {Price = 10,FlightNumber = 5},
              new Ticket() {Price = 14,FlightNumber = 5},
              new Ticket() {Price = 100,FlightNumber = 5}
          };

        public readonly List<Departure> departures = new List<Departure>()
          {
              new Departure(){Crew=new Crew(){ Pilot=new Pilot(){Name="Alessio", Surname="Rossi",Birthday=new DateTime(1404, 6, 21),Experience=3},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},DepartureDate= now,FlightNumber=1,Plane= new Plane(){ } },
              new Departure(){Crew=new Crew(){ Pilot=new Pilot(){ Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(1414, 3, 17),Experience=4},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},DepartureDate= now,FlightNumber=1,Plane=new Plane(){ }},
              new Departure(){Crew=new Crew(){ Pilot=new Pilot(){ Name="Adelaide", Surname="Giordano",Birthday=new DateTime(1998, 8, 14),Experience=2},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},DepartureDate= now,FlightNumber=1,Plane=new Plane(){ }},
              new Departure(){Crew=new Crew(){Pilot=new Pilot(){ Name="Gennaro", Surname="Calabresi",Birthday=new DateTime(1414, 3, 17),Experience=4},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}} },DepartureDate= now,FlightNumber=1,Plane=new Plane(){ }},
              new Departure(){Crew=new Crew(){ Pilot=new Pilot(){Name="Alessio", Surname="Rossi",Birthday=new DateTime(1404, 6, 21),Experience=3},FlightAttendants = new List<FlightAttendant>(){new FlightAttendant(){ Name="Maria", Surname="Johnson",Birthday=new DateTime(1404, 6, 21)},
                  new FlightAttendant(){ Name="Kate", Surname="	Williams",Birthday=new DateTime(1414, 3, 17)},
                  new FlightAttendant(){ Name="Mila", Surname="Jones",Birthday=new DateTime(1406, 1, 14)}}},DepartureDate= now,FlightNumber=1,Plane=new Plane(){ }}
          };

    }
}

