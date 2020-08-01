using ChatApp.Core.Utils;
using Microsoft.AspNet.SignalR;
namespace ChatApp
{
    public class ChatHub : Hub
    {
        public void SendMessage(string userName, string message)
        {
            if(message.Contains(Constants.COMMAND_STOCK))
            {

            }

            Clients.All.addNewMessageToPage(userName, message);
        }
    }
}