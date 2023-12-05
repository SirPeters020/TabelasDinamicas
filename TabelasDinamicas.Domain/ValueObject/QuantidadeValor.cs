namespace TabelasDinamicas.Domain.ValueObject;

public class QuantidadeValor
{
    public decimal Quantidade { get; private set; }
    public decimal Valor { get; private set; }

    public QuantidadeValor(decimal quantidade, decimal valor)
    {
        Quantidade = quantidade;
        Valor = valor;
    }
}
