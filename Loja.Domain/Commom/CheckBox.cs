namespace Loja.Domain.Commom
{
    public class CheckBox
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Checked { get; set; } = false;
    }
}
