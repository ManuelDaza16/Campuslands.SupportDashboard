using System.Net.Http;
using System.Net.Http.Json;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Campuslands.SupportDashboard.Models;

namespace Campuslands.SupportDashboard.Services
{
    public class TicketService
    {
        private readonly HttpClient _httpClient;

        public TicketService(IHttpClientFactory httpClientFactory, NavigationManager navigationManager)
        {
            _httpClient = httpClientFactory.CreateClient();
            if (_httpClient.BaseAddress is null)
            {
                _httpClient.BaseAddress = new Uri(navigationManager.BaseUri);
            }
        }

        public async Task<List<Ticket>> GetTicketsAsync()
        {
            var tickets = await _httpClient.GetFromJsonAsync<List<Ticket>>("tickets.json");
            return tickets ?? new List<Ticket>();
        }

        public async Task<Ticket?> GetTicketByIdAsync(int id)
        {
            var tickets = await GetTicketsAsync();
            return tickets.FirstOrDefault(t => t.Id == id);
        }

        public async Task UpdateStatusAsync(int id, string newStatus)
        {
            await Task.Delay(200);
            Console.WriteLine($"[Simulación PATCH] Ticket {id} actualizado a estado: {newStatus}");
        }
    }
}

