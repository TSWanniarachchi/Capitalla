﻿namespace QuickAccounting.Enums
{
    /*
     * Note: 
     * - Do not change the values in this enum as they map directly to the database.
     * - Modifying these values may cause issues with data consistency.
     * - If changes are necessary, consult with the project leader and obtain approval.
     */
    public enum DaysOfWeek
    {
        /// <summary>
        /// The first day of the week.
        /// </summary>
        Sunday = 1,

        /// <summary>
        /// The start of the work week.
        /// </summary>
        Monday = 2,

        /// <summary>
        /// The second day of the work week.
        /// </summary>
        Tuesday = 3,

        /// <summary>
        /// The middle of the work week.
        /// </summary>
        Wednesday = 4,

        /// <summary>
        /// The fourth day of the week.
        /// </summary>
        Thursday = 5,

        /// <summary>
        /// The last day of the work week.
        /// </summary>
        Friday = 6,

        /// <summary>
        /// The day of rest or leisure.
        /// </summary>
        Saturday = 7
    }
}
