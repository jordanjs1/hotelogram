using System.Collections.Generic;
using System.Linq;

namespace Hotelogram
{
    /// <summary>
    /// Defines guests, who can be registered/reserved to a <seealso cref="Hotelogram.Room"/>.
    /// </summary>
    public class Guest : Person
    {
        #region Fields
        private static int _currentID = 1;   //Automatic ID assigner counter.
        #endregion

        #region Properties
        /// <summary>
        /// Gets the list which holds all reserved guests.
        /// </summary>
        public static List<Guest> AllReservedGuests { get; } = new List<Guest>();

        /// <summary>
        /// Gets the list which holds all registered users.
        /// </summary>
        public static List<Guest> AllRegisteredGuests { get; } = new List<Guest>();

        /// <summary>
        /// Gets the guest's ID.
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// Gets or sets the guest's room.
        /// </summary>
        public Room Room { get; set; }

        /// <summary>
        /// Gets or sets the guest's bill. Do not set unless you know what are you doing!
        /// </summary>
        public Bill Bill { get; set; }

        /// <summary>
        /// Gets the guest's registration station.
        /// </summary>
        public bool IsRegistered { get; }
        #endregion

        #region Constructors

        /// <summary>
        /// Reserves a guest without a room.
        /// </summary>
        /// <param name="tcid">The T.C. ID of the guest.</param>
        /// <param name="name">The full name of the guest.</param>
        /// <param name="gsmNumber">The GSM number of the guest.</param>
        public Guest(long tcid, string name, string gsmNumber) : base(tcid, name, "null", gsmNumber)
        {
            ID = _currentID;
            TCID = tcid;
            Name = name;
            GSMNumber = gsmNumber;
            AllReservedGuests.Add(this);
            IsRegistered = false;
            _currentID++;
        }

        /// <summary>
        /// Reserves or registers a guest with a room.
        /// </summary>
        /// <param name="tcid">The T.C. ID of the guest.</param>
        /// <param name="name">The full name of the guest.</param>
        /// <param name="gsmNumber">The GSM number of the guest.</param>
        /// <param name="room">The room the guest is being registered to.</param>
        /// <param name="register">Indicates whether the guest will be reserved or registered. If true, the guest will be registered.</param>
        public Guest(long tcid, string name, string gsmNumber, Room room, bool register) : base(tcid, name, "null", gsmNumber)
        {
            ID = _currentID++;
            TCID = tcid;
            Name = name;
            GSMNumber = gsmNumber;
            Room = room;
            
            if(register)
            {
                Bill = new Bill(this);
                AllRegisteredGuests.Add(this);
                IsRegistered = true;
            }
            else
            {
                AllReservedGuests.Add(this);
                IsRegistered = false;
            }

            //Database.MakeGuestRoomTriple(this, !register, room);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Searches guests for the given ID.
        /// </summary>
        /// <param name="id">The guest ID to be searched.</param>
        /// <returns>Returns that guest if a guest's ID matches to the given ID, otherwise returns null.</returns>
        public static Guest GetGuestByID(int id)
        {
            foreach (var g in from g in AllRegisteredGuests
                where g.ID == id
                select g)
            {
                return g;
            }

            return (from g in AllReservedGuests where g.ID == id select g).FirstOrDefault();
        }
        #endregion
    }
}
