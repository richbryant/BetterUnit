using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace BetterUnit
{
#if !NO_SERIALIZABLE
    [Serializable]
#endif
    public struct Unit : IEquatable<Unit>, IComparable<Unit>, IComparable
    {
        /// <summary>
        /// Default and only value of the <see cref="Unit"/> type.
        /// </summary>
        public static readonly Unit Value = new Unit();

        /// <summary>
        /// Task from a <see cref="Unit"/> type.
        /// </summary>
        public static readonly Task<Unit> Task = System.Threading.Tasks.Task.FromResult(Value);

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> value is equal to the current <see cref="Unit"/>. Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.
        /// </summary>
        /// <param name="other">An object to compare to the current <see cref="Unit"/> value.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.</returns>
        [Pure]
        public bool Equals(Unit other) => true;

        /// <summary>
        /// Determines whether the specified System.Object is equal to the current <see cref="Unit"/>.
        /// </summary>
        /// <param name="obj">The System.Object to compare with the current <see cref="Unit"/>.</param>
        /// <returns><c>true</c> if the specified System.Object is a <see cref="Unit"/> value; otherwise, <c>false</c>.</returns>
        [Pure]
        public override bool Equals(object obj) => obj is Unit;

        /// <summary>
        /// Returns the hash code for the current <see cref="Unit"/> value.
        /// </summary>
        /// <returns>A hash code for the current <see cref="Unit"/> value.</returns>
        [Pure]
        public override int GetHashCode() => 0;

        /// <summary>
        /// Returns a string representation of the current <see cref="Unit"/> value.
        /// </summary>
        /// <returns>String representation of the current <see cref="Unit"/> value.</returns>
        [Pure] 
        public override string ToString() => "()";

        /// <summary>
        /// Determines whether the two specified <see cref="Unit"/> values are equal. Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.</returns>
        [Pure]
        public static bool operator ==(Unit first, Unit second) => true;

        /// <summary>
        /// Determines whether the two specified <see cref="Unit"/> values are not equal. Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.</returns>
        [Pure]
        public static bool operator !=(Unit first, Unit second) => false;

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> value is greater than the second. Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.</returns>
        [Pure]
        public static bool operator >(Unit first, Unit second) => false;

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> value is greater than or equal to the second. Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.</returns>
        [Pure]
        public static bool operator >=(Unit first, Unit second) => true;

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> value is smaller than the second. Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.</returns>
        [Pure]
        public static bool operator <(Unit first, Unit second) => false;

        /// <summary>
        /// Determines whether the specified <see cref="Unit"/> value is smaller than or equal to the second. Because <see cref="Unit"/> has a single value, this always returns <c>true</c>.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value to compare.</param>
        /// <param name="second">The second <see cref="Unit"/> value to compare.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <c>false</c>.</returns>
        [Pure]
        public static bool operator <=(Unit first, Unit second) => true;

        /// <summary>
        /// Adds two values of <see cref="Unit"/>. Because <see cref="Unit"/> has a single value, this always returns Default.
        /// </summary>
        /// <param name="first">The first <see cref="Unit"/> value.</param>
        /// <param name="second">The second <see cref="Unit"/> value.</param>
        /// <returns>Because <see cref="Unit"/> has a single value, this always returns <see cref="Unit"/>.</returns>
        [Pure]
        public static Unit operator +(Unit first, Unit second) => Default;

        /// <summary>
        /// Gets the single <see cref="Unit"/> value.
        /// </summary>
        public static Unit Default => default;

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.
        /// The return value has the following meanings:
        ///  - Less than zero: This object is less than the <paramref name="other" /> parameter.
        ///  - Zero: This object is equal to <paramref name="other" />.
        ///  - Greater than zero: This object is greater than <paramref name="other" />.
        /// </returns>
        [Pure]
        public int CompareTo(Unit other) => 0;

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.
        /// The return value has these meanings:
        ///  - Less than zero: This instance precedes <paramref name="obj" /> in the sort order.
        ///  - Zero: This instance occurs in the same position in the sort order as <paramref name="obj" />.
        ///  - Greater than zero: This instance follows <paramref name="obj" /> in the sort order.
        /// </returns>
        [Pure]
        int IComparable.CompareTo(object obj) => 0;
        
        /// <summary>
        /// Provide an alternative value to unit
        /// </summary>
        /// <typeparam name="T">Alternative value type</typeparam>
        /// <param name="anything">Alternative value</param>
        /// <returns>Alternative value</returns>
        [Pure]
        public T Return<T>(T anything) => anything;
        
        public static Unit operator +(Unit a, Unit b) =>
            Default;

        [Pure]
        public static implicit operator ValueTuple(Unit _) => 
            default;
        
        [Pure]
        public static implicit operator Unit(ValueTuple _) => 
            default;
    }
}
