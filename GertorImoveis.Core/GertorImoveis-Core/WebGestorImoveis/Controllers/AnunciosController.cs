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
    public class AnunciosController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;

        public readonly InterfaceAnuncioApp _interfaceAnuncioApp;

        public AnunciosController(InterfaceAnuncioApp interfaceAnuncioApp, UserManager<ApplicationUser> userManager)
        {
            _interfaceAnuncioApp = interfaceAnuncioApp;
            _userManager = userManager;
        }

        // GET: AnunciosController
        public async Task<IActionResult> Index()
        {
            var idUsuario = await RetornarIdUsuarioLogado();
            return View(await _interfaceAnuncioApp.ListarAnunciosUsuario(idUsuario));
        }

        // GET: AnunciosController/Details/
        public async Task<IActionResult> Details(int id)
        {
            return View(await _interfaceAnuncioApp.GetEntityByID(id));
        }

        // GET: AnunciosController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: AnunciosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Anuncio anuncio)
        {
            try
            {
                var idUsuario = await RetornarIdUsuarioLogado();

                anuncio.UserId = idUsuario;
                await _interfaceAnuncioApp.AddAnuncio(anuncio);

                if (anuncio.Notitycoes.Any())
                {
                    foreach (var item in anuncio.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.mensagem);
                    }

                    return View("Create", anuncio);
                }

            }
            catch
            {
                return View("Create", anuncio);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: AnunciosController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _interfaceAnuncioApp.GetEntityByID(id));
        }

        // POST: AnunciosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Anuncio anuncio)
        {
            try
            {
                var idUsuario = await RetornarIdUsuarioLogado();

                anuncio.UserId = idUsuario;
                await _interfaceAnuncioApp.UpdateAnuncio(anuncio);

                if (anuncio.Notitycoes.Any())
                {
                    foreach (var item in anuncio.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.mensagem);
                    }

                    ViewBag.Alerta = true;
                    ViewBag.Mensagem = "Verifique, ocorreu algum erro!";

                    return View("Edit", anuncio);
                }
            }
            catch
            {
                return View("Edit", anuncio);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: AnunciosController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _interfaceAnuncioApp.GetEntityByID(id));
        }

        // POST: AnunciosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Anuncio anuncio)
        {
            try
            {
                var anuncioDeletar = await _interfaceAnuncioApp.GetEntityByID(id);

                await _interfaceAnuncioApp.Delete(anuncioDeletar);

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


        [AllowAnonymous]
        [HttpGet("/api/ListarAnuncios")]
        public async Task<JsonResult> ListarAnunciosPublicados()
        {
            var t = await _interfaceAnuncioApp.ListarAnunciosPublicados();
            return Json(await _interfaceAnuncioApp.ListarAnunciosPublicados());

        }

    }
}
