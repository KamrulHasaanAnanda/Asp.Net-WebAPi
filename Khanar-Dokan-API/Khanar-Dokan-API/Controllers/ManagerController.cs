using Khanar_Dokan_API.Models;
using Khanar_Dokan_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Khanar_Dokan_API.Controllers
{
    [RoutePrefix("khanardokan/manager")]
    public class ManagerController : ApiController
    {
        UserRepository UserRepo = new UserRepository();
        HistoryRepository HistoryRepo = new HistoryRepository();
        EmployeeRepository EmployeeRepo = new EmployeeRepository();
        FoodItemRepository FoodItemRepo = new FoodItemRepository();
        InvoiceRepository InvoiceRepo = new InvoiceRepository();
        CommentRepository CommentRepo = new CommentRepository();
        ContactRepository ContactRepo = new ContactRepository();

        [Route("orderlist")]
        //[BasicAuthorization]
        public IHttpActionResult GetOrder()
        {
            return Ok(HistoryRepo.GetOrderFromCustomer());
        }

        [Route("orderlist/{id}")]
        public IHttpActionResult PutOrder([FromBody]History his, [FromUri]int id)
        {
            his.hid = id;
            //HistoryRepo.Edit(his);
            his.hstatus = "Cheif";
            return Ok(his);
        }

        [Route("employee")]
        public IHttpActionResult GetEmployee()
        {
            return Ok(EmployeeRepo.GetEmployeesForManager());
            //return Ok(EmployeeRepo.GetAll());
        }

        [Route("employee")]
        public IHttpActionResult PostEmployee(Employee em)
        {
            EmployeeRepo.Insert(em);
            string url = Url.Link("GetEmployeeById", new { id = em.eid });
            return Created(url, em);
        }

        [Route("employee/{id}")]
        public IHttpActionResult PutEmployee([FromBody]Employee em, [FromUri]int id)
        {
            em.eid = id;
            EmployeeRepo.Edit(em);
            return Ok(em);
        }

        [Route("employee/{id}")]
        public IHttpActionResult DeleteEmployee(int id)
        {
            EmployeeRepo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("comment")]
        public IHttpActionResult GetComment()
        {
            return Ok(CommentRepo.GetAll());
        }

        [Route("comment/{id}")]
        public IHttpActionResult DeleteComment(int id)
        {
            CommentRepo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("contact")]
        public IHttpActionResult GetContact()
        {
            return Ok(ContactRepo.GetAll());
        }

        [Route("cheiforder")]
        public IHttpActionResult GetCheifOrder()
        {
            return Ok(HistoryRepo.GetCheifOrderPending());
        }

        [Route("orderdelivery")]
        public IHttpActionResult GetDeliveryBoyOrder()
        {
            return Ok(HistoryRepo.GetDeliveryBoyOrderPending());
        }

        [Route("orderdone")]
        public IHttpActionResult GetOrderIsDone()
        {
            return Ok(HistoryRepo.GetOrderDone());
        }


        [Route("fooditem")]
        public IHttpActionResult GetFoodItem()
        {
            return Ok(FoodItemRepo.GetAll());
        }

        [Route("fooditem")]
        public IHttpActionResult PostFoodItem(FoodItem fi)
        {
            FoodItemRepo.Insert(fi);
            string url = Url.Link("GetFoodItemById", new { id = fi.fid });
            return Created(url, fi);
        }

        [Route("fooditem/{id}")]
        public IHttpActionResult PutFoodItem([FromBody]FoodItem fi, [FromUri]int id)
        {
            fi.fid = id;
            FoodItemRepo.Edit(fi);
            return Ok(fi);
        }

        [Route("fooditem/{id}")]
        public IHttpActionResult DeleteFoodItem(int id)
        {
            FoodItemRepo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("userlist")]
        public IHttpActionResult GetUser()
        {
            return Ok(UserRepo.GetAll());
        }
        
        [Route("userlist/{id}")]
        //[BasicAuthorization]
        public IHttpActionResult GetUserDetials(int id)
        {
            return Ok(InvoiceRepo.GetInvoicesWithUser(id));
        }
    }
}
