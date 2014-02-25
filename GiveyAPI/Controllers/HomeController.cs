using GiveyAPI.Models;
using GiveyAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GiveyAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GiveyUser giveyUser = null;
            var syncClient = new WebClient();
            var content = syncClient.DownloadString("http://api.givey.com/v2/users/pootsbook");

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GiveyUser));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                giveyUser = (GiveyUser)serializer.ReadObject(ms);
            }


            GiveyUserDonation giveyUserDonation = null;
            var syncDonationClient = new WebClient();
            var donationContent = syncDonationClient.DownloadString("https://api.givey.com/v2/users/pootsbook/donations");

            DataContractJsonSerializer donationSerializer = new DataContractJsonSerializer(typeof(GiveyUserDonation));
            using (var msDonation = new MemoryStream(Encoding.Unicode.GetBytes(donationContent)))
            {
                giveyUserDonation = (GiveyUserDonation)donationSerializer.ReadObject(msDonation);
            }


            GiveyViewModel giveyViewModel = new GiveyViewModel
            {
                GiveyUser = giveyUser,
                GiveyUserDonations = giveyUserDonation
            };
            return View(giveyViewModel);
        }      
    }
}