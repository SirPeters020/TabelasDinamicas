using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDinamicas.Domain.Model;

public class ComplementoRegistro
{
    public Guid RegistroId { get; private set; }

    public Guid ComplementoId { get; private set; }

    public string Valor { get; private set; }

    public DateTime Data { get; private set; }

    public bool Atual { get; set; }

    public bool Nova { get; private set; }

    public Registros Registro { get; }

    public Complemento Complemento { get; private set; }
}
