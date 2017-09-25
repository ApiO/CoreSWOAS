namespace CoreSWOAS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class InstancedPostIt: PostIt, IInstanced<InstancedPostIt>
    {
        /// <inheritdoc />
        public string Guid { get; set; }

        /// <inheritdoc />
        public bool Equals(InstancedPostIt other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other) && string.Equals(Guid, other.Guid);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((InstancedPostIt) obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (Guid != null ? Guid.GetHashCode() : 0);
            }
        }
    }
}
