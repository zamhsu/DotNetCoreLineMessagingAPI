namespace LineMessagingAPI.Models.Message.Flex.Container
{
    public class BubbleStyleModel
    {
        public BlockStyleModel header { get; set; }

        public BlockStyleModel hero { get; set; }

        public BlockStyleModel body { get; set; }

        public BlockStyleModel footer { get; set; }
    }

    public class BlockStyleModel
    {
        public string backgroundColor { get; set; }

        public bool separator { get; set; }

        public string separatorColor { get; set; }
    }
}