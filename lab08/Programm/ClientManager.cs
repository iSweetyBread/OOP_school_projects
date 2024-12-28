using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class ClientManager
    {
        public static void AddClient(Client client)
        {
            DatabaseManager.Create(client.FirstName, client.LastName, client.Email, client.Phone);
        }
        public static void AddClient(ClientCSV client)
        {
            DatabaseManagerCSV.Create(client.Id, client.FirstName, client.LastName, client.Email, client.Phone);
        }

        public static void DeleteClient(Client client)
        {
            DatabaseManager.Delete(client.Id);
        }
        public static void DeleteClient(ClientCSV client)
        {
            DatabaseManagerCSV.Delete(client.Id);
        }

        public static void UpdateClient(Client client, int attribute, string data)
        {
            DatabaseManager.Update(client.Id, attribute, data);
        }
        public static void UpdateClient(ClientCSV client, int attribute, string data)
        {
            DatabaseManagerCSV.Update(client.Id, attribute, data);
        }

        public static List<string> DisplayClients()
        {
            return DatabaseManager.Read();
        }
        public static List<string> DisplayClientsCSV()
        {
            return DatabaseManagerCSV.Read();
        }

        public static void SearchClient(int attribute, string data)
        {
            DatabaseManager.Search(attribute, data);
        }
        public static void SearchClientCSV(int attribute, string data)
        {
            DatabaseManagerCSV.Search(attribute, data);
        }
    }
}
