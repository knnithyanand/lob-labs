namespace Knnithyanand.LobLabs.Libs.Core
{
    public class TextAttribute : EntityAttribute
    {
        public TextAttribute(string name, string description = "") : base(name, description)
        {
            Type = AttributeDataType.Text;
        }

        public override dynamic Value { get; set; }
    }
}