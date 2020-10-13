using Khanar_Dokan_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Khanar_Dokan_API.Controllers
{
    [RoutePrefix("khanardokan")]
    public class SystemController : ApiController
    {
        FoodItemRepository FoodRepo = new FoodItemRepository();
        UserRepository UserRepo = new UserRepository();

        [Route("")]
        //[BasicAuthorization]
        public IHttpActionResult Get()
        {
            return Ok(FoodRepo.GetAll());
        }

        [Route("Login")]
        public IHttpActionResult LoginGet(int id)
        {
            return Ok(UserRepo.GetById(id));
        }
    }
}
