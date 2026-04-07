using System.Security.Cryptography.X509Certificates;

namespace MQSVendasApp.Models
{
    public class SharedId
    {
        public SharedId()
        {
            Id = new Guid();
        }
        public SharedId(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
