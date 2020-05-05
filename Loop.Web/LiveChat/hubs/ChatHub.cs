using Microsoft.AspNet.SignalR;

namespace Loop.Web.LiveChat.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Call the broadcastMessage method to update Clients
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}