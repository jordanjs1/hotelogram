namespace Hotelogram
{
    /// <summary>
    /// Defines time with hours, minutes and seconds.
    /// </summary>
    public class Time
    {
        #region Properties
        /// <summary>
        /// Gets or sets the hour of the time.
        /// </summary>
        public byte Hour { get; set; }

        /// <summary>
        /// Gets or sets the minute of the time.
        /// </summary>
        public byte Minute { get; set; }

        /// <summary>
        /// Gets or sets the second of the time.
        /// </summary>
        public byte Second { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Creates a time.
        /// </summary>
        /// <param name="hour">The hours of the time.</param>
        /// <param name="minute">The minutes of the time.</param>
        /// <param name="second">The seconds of the time.</param>
        public Time(byte hour, byte minute, byte second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        #endregion
    }
}
