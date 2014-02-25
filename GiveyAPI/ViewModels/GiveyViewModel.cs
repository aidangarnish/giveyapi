using GiveyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiveyAPI.ViewModels
{
    public class GiveyViewModel
    {
        public GiveyUser GiveyUser { get; set; }
        public GiveyUserDonation GiveyUserDonations { get; set; }
    }
}