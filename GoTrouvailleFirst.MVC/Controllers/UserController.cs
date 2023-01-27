using GoTrouvailleFirst.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace GoTrouvailleFirst.MVC.Controllers
{
    public class UserController : Controller
    {
        string BaseUrl = "https://localhost:44364/";
        public UserController()
        {

        }
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Response = await client.GetAsync("api/User/GetAllUser");
                if (Response.IsSuccessStatusCode)
                {
                    var result = Response.Content.ReadAsStringAsync().Result;
                    if (result == "[]")
                    {
                        return View(new List<UserDto>());
                    }
                    var data = JsonConvert.DeserializeObject<List<UserDto>>(result);                   
                    return View(data);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserDto userDto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Response = await client.PostAsJsonAsync("api/User/AddUser", userDto);
                if (Response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(userDto);
            }            
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Response = await client.GetAsync("api/User/GetUserById/"+ id);
                if (Response.IsSuccessStatusCode)
                {
                    var result = Response.Content.ReadAsStringAsync().Result;
                    if (result == "[]")
                    {
                        return View(new UserDto());
                    }
                    var data = JsonConvert.DeserializeObject<UserDto>(result);
                    return View(data);
                }
                
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserDto userDto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Response = await client.PostAsJsonAsync("api/User/UpdateUser", userDto);
                if (Response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(userDto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Response = await client.DeleteAsync("api/User/DeleteUser/"+ id);
                if (Response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
        }
    }
}
