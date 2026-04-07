using MQSVendasApp.Enuns;

namespace MQSVendasApp.Models
{
    public class Cliente : SharedId
    {
        public TipoCadastroEnum TipoCadastroEnum { get; set; }
    }
}
