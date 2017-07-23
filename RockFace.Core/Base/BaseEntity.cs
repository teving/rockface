using System;

namespace RockFace.Core.Base
{
    public abstract class BaseEntity
    {
        private const int HashMultiplier = 31;
        private readonly Lazy<int> cachedHashCode;

        protected BaseEntity()
        {
            cachedHashCode = new Lazy<int>(CalculateHashCode);
        }

        public int Id { get; set; }
        public bool IsTransient => Id == 0;

        #region Equality

        private int CalculateHashCode()
        {
            var hashCode = GetType().GetHashCode();
            return (hashCode * HashMultiplier) ^ Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj == null || IsTransient || GetType() != obj.GetType())
                return false;

            var compareTo = obj as BaseEntity;
            if (compareTo == null || compareTo.IsTransient)
                return false;

            return Id == compareTo.Id;
        }

        public override int GetHashCode()
        {
            return cachedHashCode.Value;
        }

        #endregion
    }
}