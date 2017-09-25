using System;
using System.Runtime.Serialization;

namespace CoreSWOAS.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInstanced<T> : IEquatable<T>
    {
        /// <summary>
        /// Model's GUID
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        string Guid { get; set; }
    }
}
