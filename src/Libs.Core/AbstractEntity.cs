using System;

namespace Knnithyanand.LobLabs.Libs.Core
{
    public abstract class AbstractEntity : IEntity
    {
        public Guid Id { get; set; }
        public virtual string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public uint Version { get; set; }

        public AbstractEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = ModifiedAt = DateTime.Now;
            Version = 0;
        }
    }
}
