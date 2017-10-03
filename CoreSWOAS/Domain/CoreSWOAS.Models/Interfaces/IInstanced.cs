using System;
using System.Runtime.Serialization;

namespace CoreSWOAS.Models.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInstanced<T> : IEquatable<T> where T : class
    {
        /// <summary>
        /// Model's GUID
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        string Guid { get; set; }
    }
}