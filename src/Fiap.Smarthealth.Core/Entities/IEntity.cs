namespace Fiap.Smarthealth.Core.Entities;

public interface IEntity<TPrimaryKey>
{
    TPrimaryKey? Id { get; set; }
}
