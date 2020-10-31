using _net_api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _net_api.Controllers
{
    [ApiController]
    [Route ("/api/person/")]
    public class PersonController:ControllerBase {
        Person person = new Person();
        [HttpPost("create")]
        public Person create(Person persona){
            return persona;
        }

        [HttpPost("actualizar")]
        public Person actualizar(Person persona){
            return persona;
        }
    }
}