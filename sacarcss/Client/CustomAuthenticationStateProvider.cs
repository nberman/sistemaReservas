using System.Net.Http.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using sistemaReservas.Shared.Models;


namespace sistemaReservas.Client;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly HttpClient _httpClient;

    public CustomAuthenticationStateProvider(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        User currentUser = await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser");

        if (currentUser != null && currentUser.EmailAddress != null)
        {
            var claim = new Claim(ClaimTypes.Name, currentUser.EmailAddress);
            var claimsIdentity = new ClaimsIdentity(new[] {claim}, "serverAuth");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            return new AuthenticationState(claimsPrincipal);
            
        }
        else
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }
    
}