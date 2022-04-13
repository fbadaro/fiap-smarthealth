namespace Fiap.Smarthealth.Core.Entities
{
    public class EntityValidationResult
    {
        public bool IsValid { get; set; }

        public List<string> Messages { get; set; } = new List<string>();
    }
}
