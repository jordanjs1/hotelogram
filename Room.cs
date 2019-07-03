using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelogram
{
    /// <summary>
    /// Defines rooms, which <see cref="Guest"/>s can register/reserve to. 
    /// </summary>
    public class Room
    {
        #region Fields
        #endregion

        #region Properties
        /// <summary>
        /// Gets the list which holds all rooms.
        /// </summary>
        public static List<Room> AllRooms { get; } = new List<Room>();

        /// <summary>
        /// Gets the room number.
        /// </summary>
        public int No { get; }

        /// <summary>
        /// Gets the floor number of the room.
        /// </summary>
        public int Floor { get; }

        /// <summary>
        /// Gets or sets the type of the room.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the list which holds the furniture in the room.
        /// </summary>
        public List<Furniture> FurnitureList { get; set; } = new List<Furniture>();

        /// <summary>
        /// Gets a string representation of the furniture (name and count) in the room.
        /// </summary>
        public string FurnitureString
        {
            get
            {
                var s = string.Empty;
                foreach (var f in FurnitureList)
                {
                    if(FurnitureList.IndexOf(f) != FurnitureList.Count - 1)
                        s += $"{f.Name} ({f.Count}), ";
                    else
                        s += $"{f.Name} ({f.Count})";
                }
                return s;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a Room.
        /// </summary>
        /// <param name="no">The no of the room.</param>
        /// <param name="floor">The floor the room is on.</param>
        /// <param name="type">The type of the room.</param>
        /// <param name="furnitureList">The list of furniture in the room.</param>
        public Room(int no, short floor, string type, List<Furniture> furnitureList)
        {
            No = no;
            Floor = floor;
            Type = type;
            foreach (var f in furnitureList)
            {
                FurnitureList.Add(f);
                //Database.MakeRoomFurnitureTriple(this, f);
            }

            AllRooms.Add(this);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Searches rooms for the specified number.
        /// </summary>
        /// <param name="no">The number of the room to be searched.</param>
        /// <returns>Returns that room if a room with the specified number is found, otherwise returns null.</returns>
        public static Room GetRoomByNo(uint no)
        {
            return (from r in AllRooms where r.No == no select r).FirstOrDefault();
        }
        #endregion
    }
}
