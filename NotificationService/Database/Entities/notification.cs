using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Database.Entities
{
    public class notification
    {
        [Key]
        public int NotificationsId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
