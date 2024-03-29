using CursoEFCore.ValueObjects;
using System;

namespace CursoEFCore.ValueObjects 
{

    public class Pedido 
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime IniciandoEm { get; set; }

        public DateTime FinalidadoEm { get; set; }

        public TipoFrete TipoFrete { get; set; }

        public StatusPedido Status { get; set; }

        public string Observacao { get; set; }

        public ICollection<PedidoItem> Itens { get; set; }

    }
}