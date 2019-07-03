namespace Hotelogram
{
    /// <summary>
    /// Defines persons, who is the base class for <see cref="Employee"/>s and <see cref="Guest"/>s.
    /// </summary>
    public abstract class Person
    {
        #region Properties

        /// <summary>
        /// Gets or sets the T.C. ID of the person.
        /// </summary>
        public long TCID { get; set; }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of the person.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the GSM number of the person.
        /// </summary>
        public string GSMNumber { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Creates a person.
        /// </summary>
        /// <param name="tcid">The T.C. ID of the person.</param>
        /// <param name="name">The name of the person.</param>
        /// <param name="address">The address of the person.</param>
        /// <param name="gsmNumber">The GSM number of the person.</param>
        protected Person(long tcid,  string name, string address, string gsmNumber)
        {
            TCID = tcid;
            Name = name;
            Address = address;
            GSMNumber = gsmNumber;
        }
        #endregion
    }
}
