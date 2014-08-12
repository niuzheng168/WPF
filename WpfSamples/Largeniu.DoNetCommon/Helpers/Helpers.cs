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

        /// <summary>
        /// The parse enum.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T">
        /// Enum Type.
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public static T ParseEnum<T>(string value) where T : struct
        {
            T result;
            Enum.TryParse(value, true, out result);
            return result;
        }

        /// <summary>
        ///     The convert enum tong string list.
        /// </summary>
        /// <typeparam name="T">
        ///     Enum Type.
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        public static IEnumerable<string> ConvertEnumTongStringList<T>() where T : struct
        {
            return Enum.GetNames(typeof(T));
        }

        /// <summary>
        ///     The convert enum to list.
        /// </summary>
        /// <typeparam name="T">
        ///     Enum Type.
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        public static IEnumerable<T> ConvertEnumToList<T>() where T : struct
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        /// <summary>
        ///     The convert enum to array.
        /// </summary>
        /// <typeparam name="T">
        ///     Enum Type.
        /// </typeparam>
        /// <returns>
        ///     The <see cref="T[]" />.
        /// </returns>
        public static T[] ConvertEnumToArray<T>() where T : struct
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        /// <summary>
        /// The get enum description.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T">
        /// Enum Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetEnumDescription<T>(T value) where T : struct
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField(value.ToString());
            DescriptionAttribute attribute =
                Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        #endregion
    }
}