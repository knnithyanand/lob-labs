using System;

namespace Knnithyanand.LobLabs.Libs.Core
{
    public abstract class EntityAttribute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public uint Version { get; set; }

        public AttributeDataType Type { get; set; }
        public abstract dynamic Value { get; set; }

        public EntityAttribute()
        {
            Id = Guid.NewGuid();
            CreatedAt = ModifiedAt = DateTime.Now;
            Version = 0;
        }

        public EntityAttribute(string name, string description = "") : this()
        {
            Name = name;
            Description = description;
        }

    }
}
