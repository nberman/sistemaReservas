using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistemaReservas.Shared;
using sistemaReservas.Server.Models;

namespace sistemaReservas.Server.Controllers;
[Microsoft.AspNetCore.Components.Route("[controller]")]
    


public class UserController : ControllerBase
{
    private readonly ILogger<UserController> logger;
    private readonly ApplicationDbContext _context;

    public UserController(ILogger<UserController> logger, ApplicationDbContext context)
    {
        this.logger = logger;
        this._context = context;
    }

    [HttpPost("loginuser")]
    public async Task<ActionResult<User>> LoginUser(User user)
    {
        User loggedInUser = await _context.Users.Where(u => u.EmailAddress == user.EmailAddress && u.Password == user.Password).FirstOrDefaultAsync();
        if (loggedInUser != null)
        {
            var claim = new Claim(ClaimTypes.Name, loggedInUser.EmailAddress);
            var claimsIdentity = new ClaimsIdentity(new[] {claim}, "serverAuth");
            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);
        }

        return await Task.FromResult(loggedInUser) ?? throw new InvalidOperationException();
    }

    [HttpGet("getcurrentuser")]
    public async Task<ActionResult<User>> GetCurrentUser()
    {
        User currentUser = new User();

        if (User.Identity.IsAuthenticated)
        {
            currentUser.EmailAddress = User.FindFirstValue(ClaimTypes.Name);
        }

        return await Task.FromResult(currentUser);
    }

    [HttpGet("logoutuser")]
    public async Task<ActionResult<String>> LogOutUser()
    {
        await HttpContext.SignOutAsync();
        return "Success";
    }
    
}