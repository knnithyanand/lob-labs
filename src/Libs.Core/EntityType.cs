using System;
using System.Collections.Generic;

namespace Knnithyanand.LobLabs.Libs.Core
{
    public class EntityType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public uint Version { get; set; }
        public List<EntityAttribute> Attributes { get; set; }
        public EntityType()
        {
            Id = Guid.NewGuid();
            CreatedAt = ModifiedAt = DateTime.Now;
            Version = 0;
            Attributes = new List<EntityAttribute>();
        }
        
        public EntityType(string name, string desc) : this()
        {
            Name = name;
            Description = desc;
        }
    }
}
