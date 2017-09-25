using System;
using System.Runtime.Serialization;

//using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;

namespace CoreSWOAS.Models
{
    /// <inheritdoc />
    /// <summary>
    /// Post-it data structure
    /// </summary>
    [DataContract]
    public class PostIt : IEquatable<PostIt>
    {
        /// <summary>
        /// The title of the post-it
        /// </summary>
        [DataMember(IsRequired = true)]
        public string Title { get; set; }

        /// <summary>
        /// The content of the post-it
        /// </summary>
        [DataMember(IsRequired = true)]
        public string Content { get; set; }

        /// <inheritdoc />
        public bool Equals(PostIt other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Title, other.Title) && string.Equals(Content, other.Content);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((PostIt) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0) * 397) ^ (Content != null ? Content.GetHashCode() : 0);
            }
        }
    }
}
