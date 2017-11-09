namespace LetsChat
{
    public class UserInformation
    {
        public UserInformation(string connectionId, string name, string imageUrl)
        {
            this.ConnectionId = connectionId;
            this.Name = name;
            this.ImageUrl = imageUrl;
        }

        public string ImageUrl { get; }

        public string ConnectionId { get; }

        public string Name { get; }
    }
}