using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double inputPrice, [FromQuery] string paymentMethod, [FromQuery] string cardNumber = null)
        {


            if (inputPrice <= 0)
            {
                return "Costo no puede ser menor o igual a 0";
            }
            if (paymentMethod == "efectivo")
            {
                return $"Debes pagar {inputPrice}";
            }
            if (paymentMethod.Equals("tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                if (cardNumber == null || cardNumber.Length != 16)
                {
                    return "El numero de tarjeta tiene que tener 16 digitos";
                }

                double total = inputPrice * 1.10;
                return $"El valor a pagar con tarjeta es: {total}";



            }
            else
            {
                return "La forma de pago no es válida. Debe ser 'efectivo' o 'tarjeta'.";
            }
        }
    }
}