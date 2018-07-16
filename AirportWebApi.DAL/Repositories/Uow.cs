using AirportWebApi.DAL.Models;
using AirportWebApi.DAL.Repositories;
using System;

namespace AirportWebApi.DAL
{
    public class Uow : IUow
    {
        private AirportContext context;

        public Uow(AirportContext context)
        {
            this.context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (typeof(T) == typeof(Ticket))
            {
                return (IRepository<T>)TicketRepository;
            }
            else if (typeof(T) == typeof(Flight))
            {
                return (IRepository<T>)FlightRepository;
            }
            else if (typeof(T) == typeof(Departure))
            {
                return (IRepository<T>)DepartureRepository;
            }
            else if (typeof(T) == typeof(Crew))
            {
                return (IRepository<T>)CrewRepository;
            }
            else if (typeof(T) == typeof(Pilot))
            {
                return (IRepository<T>)PilotRepository;
            }
            else if (typeof(T) == typeof(FlightAttendant))
            {
                return (IRepository<T>)StewardessRepository;
            }
            else if (typeof(T) == typeof(Plane))
            {
                return (IRepository<T>)PlaneRepository;
            }
            else if (typeof(T) == typeof(PlaneType))
            {
                return (IRepository<T>)PlaneTypeRepository;
            }
            else throw new Exception();

        }

        private TicketRepository ticketRepository;
        public IRepository<Ticket> TicketRepository
        {
            get
            {
                if (ticketRepository == null)
                {
                    ticketRepository = new TicketRepository(context);
                }
                return ticketRepository;
            }
        }

        private FlightRepository flightRepository;
        public IRepository<Flight> FlightRepository
        {
            get
            {
                if (flightRepository == null)
                {
                    flightRepository = new FlightRepository(context);
                }
                return flightRepository;
            }
        }

        private DepartureRepository departureRepository;
        public IRepository<Departure> DepartureRepository
        {
            get
            {
                if (departureRepository == null)
                {
                    departureRepository = new DepartureRepository(context);
                }
                return departureRepository;
            }
        }
        private CrewRepository crewRepository;
        public IRepository<Crew> CrewRepository
        {
            get
            {
                if (crewRepository == null)
                {
                    crewRepository = new CrewRepository(context);
                }
                return crewRepository;
            }
        }

        private PilotRepository pilotRepository;
        public IRepository<Pilot> PilotRepository
        {
            get
            {
                if (pilotRepository == null)
                {
                    pilotRepository = new PilotRepository(context);
                }
                return pilotRepository;
            }
        }

        private FlightAttendantRepository flightAttendantRepository;
        public IRepository<FlightAttendant> StewardessRepository
        {
            get
            {
                if (flightAttendantRepository == null)
                {
                    flightAttendantRepository = new FlightAttendantRepository(context);
                }
                return flightAttendantRepository;
            }
        }

        private PlaneRepository planeRepository;
        public IRepository<Plane> PlaneRepository
        {
            get
            {
                if (planeRepository == null)
                {
                    planeRepository = new PlaneRepository(context);
                }
                return planeRepository;
            }
        }

        private PlaneTypeRepository planeTypeRepository;

        public IRepository<PlaneType> PlaneTypeRepository
        {
            get
            {
                if (planeTypeRepository == null)
                {
                    planeTypeRepository = new PlaneTypeRepository(context);
                }
                return planeTypeRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
