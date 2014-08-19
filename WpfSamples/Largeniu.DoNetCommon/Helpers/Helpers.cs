namespace Largeniu.DoNetCommon.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    ///     The helpers.
    /// </summary>
    public class Helpers
    {
        #region Public Methods and Operators

        /// <summary>
        /// The generic get value.
        /// </summary>
        /// <param name="result">
        /// The result.
        /// </param>
        /// <param name="srcString">
        /// The src string.
        /// </param>
        /// <typeparam name="T">
        /// Source Type.
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool GenericGetValue<T>(out T result, string srcString)
        {
            Type typeT = typeof(T);

            if (typeT == typeof(string))
            {
                result = (T)Convert.ChangeType(srcString, typeof(T));
                return true;
            }

            Type[] argTypes = { typeof(string), typeT.MakeByRefType() };

            MethodInfo methodInfo = typeT.GetMethod("TryParse", argTypes);

            if (methodInfo == null)
            {
                result = default(T);
                return false;
            }

            object[] args = { srcString, null };
            var successfulParse = (bool)methodInfo.Invoke(null, args);
            if (!successfulParse)
            {
                result = default(T);
                return false;
            }

            result = (T)args[1];
            return true;
        }

        #endregion
    }
}