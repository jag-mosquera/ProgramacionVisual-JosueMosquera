﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCAPP1.Data;
using MVCAPP1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP1.Controllers
{
    public class MountainsController : Controller
    {
        readonly MainDbContext _mainDbContext;
        public MountainsController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }
        // GET: MountainsController
        public ActionResult Index()
        {
            List<Mountain> mountains = _mainDbContext.Mountains.ToList();
            return View(mountains);
        }

        // GET: MountainsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MountainsController/Create
        public ActionResult Create()
        {
            return View();
            
        }

        // POST: MountainsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mountain mountain)
        {
            _mainDbContext.Add(mountain);
            var affected = _mainDbContext.SaveChanges();
            if (affected > 0)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Mensaje"] = "No se grabo";
                return View("Mensaje");
            }
        }

        // GET: MountainsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MountainsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MountainsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MountainsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
