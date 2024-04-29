﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Application.Features.Auth.Command.Login;
using YoutubeApi.Application.Features.Auth.Command.Register;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]

        public async Task<ActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]

        public async Task<ActionResult> Login(LoginCommandRequest request)
        {
            var response =await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK,response);
        }


    }
}
