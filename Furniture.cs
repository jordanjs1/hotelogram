namespace Hotelogram
{
    /// <summary>
    /// Defines furnitures with a name and count, which every <see cref="Room"/> should have.
    /// </summary>
    public class Furniture
    {
        #region Properties
        /// <summary>
        /// The name of the furniture.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The count of the furniture.
        /// </summary>
        public ushort Count { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a furniture with the specified name and count.
        /// </summary>
        /// <param name="name">The name of the furniture.</param>
        /// <param name="count">The count of the furniture.</param>
        public Furniture(string name, ushort count)
        {
            Name = name;
            Count = count;
        }
        #endregion
    }
}
