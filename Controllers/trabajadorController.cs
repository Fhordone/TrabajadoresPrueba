using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabajadores.Models;

namespace Trabajadores.Controllers;

public class TrabajadorController : Controller
{
    private readonly TrabajadoresPruebaContext _context;
    private readonly ILogger<HomeController> _logger;
}