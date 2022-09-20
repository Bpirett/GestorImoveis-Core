using ApplicationApp.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGestorImoveis.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager; 

        public readonly InterfaceClienteApp _interfaceClienteApp;
        public ClientesController(InterfaceClienteApp interfaceClienteApp, UserManager<ApplicationUser> userManager)
        {
            _interfaceClienteApp = interfaceClienteApp;
            _userManager = userManager;
        }   

        // GET: ClientesController
        public async Task<IActionResult> Index()
        {

            var idUsuario = await RetornarIdUsuarioLogado();
            return View(await _interfaceClienteApp.ListarClientesUsuario(idUsuario));
        }

        // GET: ClientesController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _interfaceClienteApp.GetEntityByID(id));
        }

        // GET: ClientesController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            try
            {

                var idUsuario = await RetornarIdUsuarioLogado();

                cliente.UserId = idUsuario;
                await _interfaceClienteApp.AddCliente(cliente);

                if (cliente.Notitycoes.Any())
                {
                    foreach (var item in cliente.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.mensagem);
                    }

                    ViewBag.Alerta = true;
                    ViewBag.Mensagem = "Verifique, ocorreu algum erro!";

                    return View("Create", cliente);
                }
                
            }
            catch
            {
                return View("Create", cliente);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ClientesController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _interfaceClienteApp.GetEntityByID(id));
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cliente cliente)
        {
            try
            {
                await _interfaceClienteApp.UpdateCliente(cliente);

                if (cliente.Notitycoes.Any())
                {
                    foreach (var item in cliente.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.mensagem);
                    }

                    ViewBag.Alerta = true;
                    ViewBag.Mensagem = "Verifique, ocorreu algum erro!";

                    return View("Edit", cliente);
                }

            }
            catch
            {
                return View("Edit", cliente);
            }


            return RedirectToAction(nameof(Index));
        }

        // GET: ClientesController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _interfaceClienteApp.GetEntityByID(id));
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Cliente cliente)
        {
            try
            {
                var clienteDeletar = await _interfaceClienteApp.GetEntityByID(id);

               await _interfaceClienteApp.Delete(clienteDeletar);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task<string> RetornarIdUsuarioLogado()
        {

            var IdUsuario = await _userManager.GetUserAsync(User);

            return IdUsuario.Id;
        }
    }
}
