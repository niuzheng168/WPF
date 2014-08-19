namespace Largeniu.DoNetCommon.Helpers
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The extention methods.
    /// </summary>
    public static class ExtentionMethods
    {
        /// <summary>
        /// The shuffle.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void Shuffle<T>(this List<T> list)
        {
            Random r = new Random();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                int p = r.Next(i);
                T tmp = list[p];
                list[p] = list[i];
                list[i] = tmp;
            }
        }
    }
}