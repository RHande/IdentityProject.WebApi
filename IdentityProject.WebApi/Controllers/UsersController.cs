using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Web_Models;
using IdentityProject.WebApi.Web_Models.Dtos.Users.Request;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]

public class UsersController : Controller
{
   private IUserService _userService;

   public UsersController(IUserService userService)//Constructor Injection
   {
      _userService = userService;
   }

   [HttpGet("getall")]
   public IActionResult GetAll()
   {
      var result = _userService.GetAllUsers();
      return Ok(result);
   }
   
   [HttpPost("add")]
   public IActionResult Add(AddUserRequestDto user)
   {
      var result = _userService.Add(user);
      return Ok(result);
   }
   
   [HttpGet("getbyemail")]
   public IActionResult GetByEmail(string email)
   {
      AddUserRequestDto dto = new AddUserRequestDto();
      User user = (User)dto;
      
      
      
      var result = _userService.GetByEmail(email);
      return Ok(result);
   }
   
   
   
   
   
   
   
}