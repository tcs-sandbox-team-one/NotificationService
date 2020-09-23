using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotificationService.Database;
using NotificationService.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotificationService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        DatabaseContext db;

        public object TimesheetID { get; private set; }

        public NotificationController()
        {
            db = new DatabaseContext();

        }

        // GET: api/<NotificationController>
        [ActionName("getAllNotifications")]
        [HttpGet]
        public IEnumerable<notification> Get()
        {
            return db.Notifications.ToList();
        }

        // GET api/<NotificationController>/5
        [ActionName("getNotification")]
        [HttpGet("{id}")]
        public IEnumerable<notification> Get(int id)
        {
            return db.Notifications.FromSql("SELECT * FROM notificationdb.notifications where NotificationsId={0}", id);
        }

        // POST api/<NotificationController>
        [ActionName("insertNotification")]
        [HttpPost]
        public IActionResult Post([FromBody] notification n)
        {
            db.Notifications.Add(n);

            db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<NotificationController>/5
        [ActionName("deactivateNotification")]
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] notification n)
        {
            var existingnotification = db.Notifications.Where(s => s.NotificationsId == n.NotificationsId).FirstOrDefault<notification>();
            

            if (existingnotification!=null)
            {
                existingnotification.Status = n.Status;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
            ////string status = "D";
            //try
            //{
            //    if(id!= n.NotificationsId)
            //    {
            //        return BadRequest("ID mismatch");
            //    }

            //    //var notificationToUpdate = db.Notifications.SingleOrDefault(x => x.NotificationsId == id);

            //    if(n == null)
            //    {
            //        return NotFound($"Notification with id = {id} not found");

            //            }
            //    db.Stat.
            //    db.SaveChanges();
            //    return StatusCode(StatusCodes.Status201Created);

            //}

            //catch(Exception ex)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError, ex);
            //}
        

        // DELETE api/<NotificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
