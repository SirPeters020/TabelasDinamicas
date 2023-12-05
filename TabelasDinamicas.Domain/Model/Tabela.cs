﻿using TabelasDinamicas.Core.Domain;
using TabelasDinamicas.Core.DomainObjects;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TabelasDinamicas.Domain.Model;

public class Tabela : Entity, EntityBase
{
    public string Nome { get; private set; }

    public DateTime Data { get; private set; }

    public Guid EstrategiaId { get; private set; }

    public decimal ValorMinimo { get; private set; }

    public bool Ativa { get; private set; }

    public string Responsavel { get; private set; }

    public string Observacoes { get; private set; }

    public Estrategia Estrategia { get; private set; }

    private readonly List<ComplementoTabela> _complementoTabela;

    public IReadOnlyCollection<ComplementoTabela> ComplementoTabela => _complementoTabela;

    protected Tabela() => _complementoTabela = new List<ComplementoTabela>();

    public Tabela(string nome, DateTime data, Guid estrategiaId, decimal valorMinimo, bool ativa, string responsavel, string observacoes)
    {
        Nome = nome;
        Data = data;
        EstrategiaId = estrategiaId;
        ValorMinimo = valorMinimo;
        Ativa = ativa;
        Responsavel = responsavel;
        Observacoes = observacoes;
    }

    public void UpdateTabela(string nome, Guid estrategiaId, decimal valorMinimo, bool ativa, string observacoes)
    {
        Nome = nome;
        Data = DateTime.Now;
        EstrategiaId = estrategiaId;
        ValorMinimo = valorMinimo;
        Ativa = ativa;
        Observacoes = observacoes;
    }

}
