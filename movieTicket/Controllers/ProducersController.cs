using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieTicket.Data;
using movieTicket.Data.Services;
using movieTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //GET:producers/details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);

        }

        //GET:producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //POST:producers/create
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")]Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET:producers/edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        //POST:producers/edit/5
        public async Task<IActionResult> Edit(int id,[Bind("Id, ProfilePictureURL, FullName, Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            if(id== producer.Id)
            { 
            await _service.UpdateAsync(id,producer);
            return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        //GET:producers/delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost,ActionName("Delete")]
        //POST:producers/deleteconfirm/5
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
