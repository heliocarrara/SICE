using SICE.Controllers;
using SICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICE.Areas.Cadastro.Controllers
{
    public class UsuarioController : BaseController
    {
        // GET: Cadastro/Usuario
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Index");
        }

        public ActionResult Novo()
        {
            try
            {
                var model = new VMFormUsuario();

                return View(model);
            }
            catch(Exception ex)
            {
                AddMessage(UserMessageType.error, ex);
                return Index();
            }
        }

        public ActionResult GravarFormulario(VMFormUsuario form)
        {
            try
            {
                //faz o cadastro no banco

                var novoUsuario = new Models.Usuario
                {
                    ativo = true,
                    cpf = form.cpf,
                    email = form.email,
                    senha = form.senha,
                    senhaSecundaria = "",
                    dataCriacao = DateTime.Now,
                    usuarioUID = 0
                };

                idbsiceContext.Usuario.Add(novoUsuario);

                idbsiceContext.SaveChanges();

                AddMessage(UserMessageType.success, "Usuário cadastrado com sucesso!");

                return RedirectToAction("GerenciarVisitas", "Visita", new { Area = "Comum" });
            }
            catch (Exception ex)
            {
                AddMessage(UserMessageType.error, ex);
                return Index();
            }
        }
    }
}