using System;
namespace Knnithyanand.LobLabs.Libs.Core
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Title { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedAt { get; set; }
        string ModifiedBy { get; set; }
        uint Version { get; set; }

    }
}