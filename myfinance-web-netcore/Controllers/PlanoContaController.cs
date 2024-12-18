using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Services;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Controllers;

    [Route("[controller]")]
    public class PlanoContaController : Controller
    {
        private readonly IPlanoContaService _planoContaService;
        public PlanoContaController(IPlanoContaService planoContaService)
        {
            _planoContaService = planoContaService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Lista = _planoContaService.ListarRegistros();
            return View();
        }
        [HttpGet]
        [HttpPost]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(PlanoContaModel? planoContaModel, int? id)
        {
            if(id != null && !ModelState.IsValid)
            {
                var registro = _planoContaService.RetornarRegistro((int)id);

                var model = new PlanoContaModel()
                {
                    Id = registro.Id,
                    Nome = registro.Nome,
                    Tipo = registro.Tipo
                };

                return View(model);
            }
            else if(planoContaModel != null && ModelState.IsValid)
            {
                var planoConta = new PlanoConta
                {
                    Id = planoContaModel.Id,
                    Nome = planoContaModel.Nome,
                    Tipo = planoContaModel.Tipo
                };
                _planoContaService.Salvar(planoConta);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _planoContaService.Excluir(id);
            return RedirectToAction("Index");
        }
    }
