using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPal.Core;
using PayPal.v1.Payments;
using BraintreeHttp;
using Microsoft.Extensions.Configuration;

namespace HomePage.Controllers
{
    public class PaymentController : Controller
    {
        public IConfiguration configuration { get; }

        public PaymentController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<string> PaypalPayment(double total)
        {
            var environment = new SandboxEnvironment(configuration["PayPal:clientId"], configuration["PayPal:secret"]);
            var client = new PayPalHttpClient(environment);

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = total.ToString(),
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = configuration["PayPal:cancelUrl"],
                    ReturnUrl = configuration["PayPal:returnUrl"]
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);
            string paypalRedirectUrl = null;
            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();
                var links = result.Links.GetEnumerator();
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
            }
            return paypalRedirectUrl;
        }
    }
}
