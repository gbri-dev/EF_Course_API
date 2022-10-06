namespace CursoEFCore.ValueObjects 
{

        public enum TipoFrete 
        {
            CIF, //quando o cliente paga o frete

            FOB,    // quando o destinatario paga

            SemFrete, //quando o cliente vai a loja e retira ela
        }
}