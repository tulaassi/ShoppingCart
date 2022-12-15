using API.Models;
using API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Users")]
    public class UserController : ApiController
    {
        IDataRepository<UserTable> _dataRepository;
        public UserController()







        {
            this._dataRepository = new UserRepository(new
    shopingcartEntities());
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<UserTable> GetAllUsers()
        {
            var users = _dataRepository.GetAll();
            return users;
        }
        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateUser(UserTable user)
        {
            UserTable userObj = null;
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                _dataRepository.Add(user);
            }
            catch (Exception)
            {
                throw;







            }
            return Ok("Data Saved");








        }
        //[Http]
        //public IHttpActionResult AddUser(UserTable User)
        //{
        //_dataRepository.AddUser(UserTable);
        //return OK;







    }
}

