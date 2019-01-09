using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using SimpleApi.Services;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _service;
        public ItemController(IItemService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("AddItem")]
        public ActionResult<Item> AddItem(Item item)
        {
            var items = _service.AddItem(item);

            if (items == null)
            {
                return NotFound();
            }
            return items;
        }

        [HttpGet]
        [Route("GetItem")]
        public ActionResult<Dictionary<string, Item>> GetItem()
        {
            var items = _service.GetItem();
            if (items.Count == 0)
            {
                return NotFound();
            }
            return items;
        }
    }
}

