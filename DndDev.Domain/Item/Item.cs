
namespace DndDev.Domain.Item
{
    /// <summary>
    /// Hold all the details regarding the information for an item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The unique identifier for the item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The high level name of the item
        /// </summary>
        public int Name { get; set; }

        /// <summary>
        /// The weight of the item
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// The description of the time
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Determines whether the item is magical
        /// </summary>
        public ItemType ItemEnum { get; set; }

        /// <summary>
        /// High level description of the item (damage, spell it uses, etc...)
        /// </summary>
        public string HighDescription { get; set; }

    }
}
