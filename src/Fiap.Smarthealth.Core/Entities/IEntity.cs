namespace Fiap.Smarthealth.Core.Entities;

public interface IEntity<TPrimaryKey>
{
    public TPrimaryKey? Id { get; set; }
}
