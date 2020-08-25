﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.UserNotificationsService.Interface;

namespace HiQo_Remote_Booking.Controllers
{
    /// <summary>
    /// Controller for configuring user notifications
    /// </summary>
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class UserNotificationsController : Controller
    {
        private readonly IUserNotificationsService _userNotificationsService;
        public UserNotificationsController(IUserNotificationsService userNotificationsService)
        {
            _userNotificationsService = userNotificationsService;
        }
       
        /// <summary>
        /// Сonfiguring calendar sync notifications.
        /// </summary>
        /// <param name="userID">The unique User ID.</param>
        /// <param name="flag">On/off notifications.</param>
        /// <returns>A bool containing the information about flag of notifications.</returns>
        [HttpPost]
        [Route("user/settings/notifications/calendarSync/{userID}/{flag}")]
        public IActionResult SetCalendarSyncNotifications(int userID, bool flag)
        {
            return Json(_userNotificationsService.CalendarSyncNotification(userID,flag));
        }
       
        /// <summary>
        /// Сonfiguring cancellation booking notifications.
        /// </summary>
        /// <param name="userID">The unique User ID.<</param>
        /// <param name="flag">On/off notifications.</param>
        /// <returns>A bool containing the information about flag of notifications.</returns>
        [HttpPost]
        [Route("user/settings/notifications/cancellation/{userID}/{flag}")]
        public IActionResult SetCancellationNotification(int userID, bool flag)
        {
            return Json(_userNotificationsService.CancellationNotification(userID, flag));
        }

        /// <summary>
        /// Сonfiguring confirmation booking notifications.
        /// </summary>
        /// <param name="userID">The unique User ID.</param>
        /// <param name="flag">On/off notifications.</param>
        /// <returns>A bool containing the information about flag of notifications.</returns>
       [HttpPost]
       [Route("user/settings/notifications/confirmation/{userID}/{flag}")]
        public IActionResult SetConfirmationNotification(int userID, bool flag)
        {
            return Json(_userNotificationsService.ConfirmationNotification(userID, flag));
        }
    }
}