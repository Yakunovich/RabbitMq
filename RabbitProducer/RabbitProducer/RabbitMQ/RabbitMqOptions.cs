namespace RabbitProducer.RabbitMQ
{
    public class RabbitMqOptions
    {
        public const string Options = "RabbitMqOptions";

        public string Hostname { get; set; } = String.Empty;
        public string RouteName { get; set; } = String.Empty;
    }
}
