﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("[controller]")]
public class ProjectsController : ApiController
{
    [HttpGet]
    public IActionResult ListProjects()
    {
        return Ok(Array.Empty<string>());
    }
}
