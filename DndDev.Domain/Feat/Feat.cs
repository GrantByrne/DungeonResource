namespace DndDev.Domain.Feat
{
    /// <summary>
    /// Datatype to hold all the information surrounding a feat
    /// </summary>
    public class Feat
    {

        /// <summary>
        /// The UID for the feat in the database
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the feat
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The details about the feat
        /// </summary>
        public string Benefit { get; set; }

        /// <summary>
        /// ???
        /// </summary>
        public string Normal { get; set; }

        /// <summary>
        /// The extra details around the feat
        /// </summary>
        public string Special { get; set; }

        /// <summary>
        /// High level deliniation of feat
        /// </summary>
        public FeatType FeatType { get; set; }

    }
}
