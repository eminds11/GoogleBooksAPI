using HTTPClientDEMO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace HTTPClientDEMO.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHttpClientFactory _clientFactory;
        public BookDetail bookDetails { get; set; }
        public VolumeInfo volumeInfo{ get; set; }
        public List<VolumeInfo> volumeList { get; set; }

        public HomeController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // Source demo for the below code: https://www.youtube.com/watch?v=DznxdvwvNkQ

        public async Task<IActionResult> Index()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://jsonplaceholder.typicode.com/todos/1");
//                "https://openlibrary.org/isbn/9780140328721.json");

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
          
            var response = client.SendAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {

                var jsonString = await response.Content.ReadAsStreamAsync();
                bookDetails = await JsonSerializer.DeserializeAsync<BookDetail>(jsonString);
            }
            else
            {
                bookDetails = new BookDetail();
            }

            return View(bookDetails);
        }

        // GET - add book to library from form
        public IActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index1(string SearchString, string SearchType)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
    //                "https://www.googleapis.com/books/v1/volumes?q=isbn:9781847946249&key=AIzaSyCp7hT6VbwagdF3KVNFUaHH9GvFDZ1oAFk");
    "https://www.googleapis.com/books/v1/volumes?q=" + SearchType + ":" + SearchString + "&key=AIzaSyCp7hT6VbwagdF3KVNFUaHH9GvFDZ1oAFk");

                var client = _clientFactory.CreateClient();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.SendAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                var googleBookDetail = await JsonSerializer.DeserializeAsync<GoogleBookDetail>(responseStream);
                volumeInfo = googleBookDetail.Items.First().VolumeInfo;

                Console.WriteLine(googleBookDetail.Items.Count);

                var itemList = googleBookDetail.Items;

                IList<VolumeInfo> volumeList = new List<VolumeInfo>();

                foreach (var v in itemList)
                {
                    Console.WriteLine(v.VolumeInfo.Title);
                    volumeList.Add(v.VolumeInfo);
                }
            }
            else
            {
                volumeInfo = new VolumeInfo();
            }

            return View("Index2", volumeList);
        }

        //public IActionResult Index2(VolumeInfo volumeInfo)
        //{
        //    return View(volumeInfo);
        //}

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
