using MediatR;
using Microsoft.AspNetCore.Mvc;
using Social.API.Contracts.Users;
using Social.Application.Users.Commands.CreateUser;
using Social.Application.Users.Commands.DeleteUser;
using Social.Application.Users.Commands.UpdateEmail;
using Social.Application.Users.Commands.UpdatePassword;
using Social.Application.Users.Commands.UpdateUser;
using Social.Application.Users.Queries.GetAll;
using Social.Application.Users.Queries.GetByEmail;
using Social.Application.Users.Queries.GetById;
using Social.Application.Users.Queries.GetByName;
using Social.Application.Users.Queries.GetByUserName;

namespace Social.API.Controllers;

[Route("v1/[Controller]")]
[ApiController]
public sealed class UsersController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request) =>
        Ok(await sender.Send(
            new CreateUserCommand(
                request.FirstName,
                request.LastName,
                request.UserName,
                request.Email,
                request.Password)));

    [HttpPost]
    public async Task<IActionResult> Update([FromBody] UpdateUserCommand request) =>
        Ok(await sender.Send(
            new UpdateUserCommand(
                request.UserId,
                request.FirstName,
                request.LastName)));

    [HttpPut("email")]
    public async Task<IActionResult> UpdateEmail([FromBody] UpdateEmailRequest request) =>
        Ok(await sender.Send(
            new UpdateEmailCommand(
                request.UserId,
                request.Email)));

    [HttpPut("password")]
    public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordRequest request) =>
        Ok(await sender.Send(
            new UpdatePasswordCommand(
                request.UserId,
                request.Password)));

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id) => Ok(await sender.Send(new DeleteUserCommand(id)));

    // Queries. 

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await sender.Send(new GetAllUsersQuery()));

    [HttpGet("name:{name}")]
    public async Task<IActionResult> GetByName(string name) => Ok(await sender.Send(new GetByNameQuery(name)));

    [HttpGet("id:{id}")]
    public async Task<IActionResult> GetById(Guid id) => Ok(await sender.Send(new GetByIdQuery(id)));

    [HttpGet("userName:{userName}")]
    public async Task<IActionResult> GetByUserName(string userName) => Ok(await sender.Send(new GetByUserNameQuery(userName)));

    [HttpGet("email:{email}")]
    public async Task<IActionResult> GetByEmail(string email) => Ok(await sender.Send(new GetByEmailQuery(email)));
}
