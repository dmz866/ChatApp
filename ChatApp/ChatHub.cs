using ChatApp.Core.Utils;
using Microsoft.AspNet.SignalR;
using ChatApp.Core.Interfaces;
using ChatApp.Infrastructure.Services;

namespace ChatApp
{
    public class ChatHub : Hub
    {
        private readonly IUtilsService _utilsService;
        public ChatHub()
        {
            _utilsService = new UtilsService();
        }
        public void SendMessage(string userName, string message)
        {
            if(message.Contains(Constants.COMMAND_STOCK))
            {
                _utilsService.GetStockInformation(message);
            }

            Clients.All.addNewMessageToPage(userName, message);
        }
    }
}