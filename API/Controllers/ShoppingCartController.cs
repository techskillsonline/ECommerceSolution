using Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingcartservice;
        private readonly IShoppingCartItemService _shoppingcartitemservice;
        private readonly ILogger<ShoppingCartController> _logger;

        public ShoppingCartController(IShoppingCartService shoppingCartService,IShoppingCartItemService shoppingCartItemService,ILogger<ShoppingCartController> logger)
        {
            this._shoppingcartservice = shoppingCartService;
            this._shoppingcartitemservice = shoppingCartItemService;
            this._logger = logger;
        }
    }
}
