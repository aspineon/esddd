namespace NDDDSample.Domain.Model.Cargos
{
    #region Usings

    using Infrastructure.Validations;
    using Shared;

    #endregion

    /// <summary>
    /// Uniquely identifies a particular cargo. Automatically generated by the application.
    /// </summary>
    public class TrackingId : IValueObject<TrackingId>
    {
        private readonly string id;

        #region Constr

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id"></param>
        public TrackingId(string id)
        {
            Validate.NotNull(id);
            this.id = id;
        }


        protected TrackingId()
        {
            // Needed by Hibernate
        }

        #endregion

        #region Props

        /// <summary>
        /// String representation of this tracking id.
        /// </summary>
        public string IdString
        {
            get { return id; }
        }

        #endregion

        #region IValueObject<TrackingId> Members

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool SameValueAs(TrackingId other)
        {
            return other != null && id.Equals(other.id);
        }

        #endregion

        #region Object's override

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TrackingId other = (TrackingId) obj;

            return SameValueAs(other);
        }


        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override string ToString()
        {
            return id;
        }

        #endregion
    }
}