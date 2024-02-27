using bai01.Models;
using Microsoft.AspNetCore.Mvc;

namespace bai01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account { Id = 1,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 2,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1483487034/fr/photo/portrait-dun-mignon-avatar-f%C3%A9minin-de-jeu-vid%C3%A9o.webp?b=1&s=170667a&w=0&k=20&c=N0WIi2YpJBMaIEHZso-4xzuY57u_Km9Bl3Ri4vyg9ro=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 3,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1401980646/fr/photo/sculpture-classique-rendue-en-3d-avatar-metaverse-avec-r%C3%A9seau-de-lignes-violettes-brillantes.webp?b=1&s=170667a&w=0&k=20&c=t868bpaj4_Qc8iy2kxVbhpYfc0gtzbPhiKDDLdgP8kE=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 4,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 5,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1746378669/fr/photo/avatar-num%C3%A9rique-metaverse-dun-jeune-homme-indien-marchant-dans-un-monde-3d-immersif-un.webp?b=1&s=170667a&w=0&k=20&c=ksa-bzdhWiY_oeBkJfpf91wyhsU6skNuNcf2oKA4ais=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 6,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi",Name ="profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account { Id = 1,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 2,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1483487034/fr/photo/portrait-dun-mignon-avatar-f%C3%A9minin-de-jeu-vid%C3%A9o.webp?b=1&s=170667a&w=0&k=20&c=N0WIi2YpJBMaIEHZso-4xzuY57u_Km9Bl3Ri4vyg9ro=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 3,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1401980646/fr/photo/sculpture-classique-rendue-en-3d-avatar-metaverse-avec-r%C3%A9seau-de-lignes-violettes-brillantes.webp?b=1&s=170667a&w=0&k=20&c=t868bpaj4_Qc8iy2kxVbhpYfc0gtzbPhiKDDLdgP8kE=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 4,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 5,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1746378669/fr/photo/avatar-num%C3%A9rique-metaverse-dun-jeune-homme-indien-marchant-dans-un-monde-3d-immersif-un.webp?b=1&s=170667a&w=0&k=20&c=ksa-bzdhWiY_oeBkJfpf91wyhsU6skNuNcf2oKA4ais=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
                new Account { Id = 6,Email="email1",Phone="099999991",Address="Address1"
                ,Avatar="https://media.istockphoto.com/id/1211442700/fr/photo/digital-power-intelligence-artificielle-leadership-s%C3%A9curit%C3%A9-r%C3%A9seau.webp?b=1&s=170667a&w=0&k=20&c=Z4EWfKOQVLXKR6RxZ9m-ByVIW0PTh1veUhByACZXqI8=",
                Gender=1,Bio="Bio1",Birthday = new DateTime(2002/05/28)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.account = account;
            return View();
        }
    }
}
