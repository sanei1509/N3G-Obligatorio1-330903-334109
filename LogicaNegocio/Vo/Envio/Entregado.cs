namespace LogicaNegocio.Vo.Envio
{
    public record Entregado
    {
        public bool Value { get; }

        private Entregado() { }
        public Entregado(bool value)
        {
            Value = value;
        }
    }
}
