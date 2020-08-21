﻿using DB.Entity;
using EmailService.Entities;
using EmailService.Interfaces;
using Repository.UnitOfWork;
using Service.NotificationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Service.NotificationService.Realization
{
    public class OrderNotificationService:IOrderNotification
    {
        private IUnitOfWork DataBase;
        private IEmailService EmailService;

        public OrderNotificationService(IUnitOfWork unitOfWork, IEmailService emailService) {
            DataBase = unitOfWork;
            EmailService = emailService;
        }

        protected void SendEmailСonfirmation(Order order, User user) {
            var Event = new CalendarEventEntity()
            {
                Summary = $"Booking the desk {order.Desk.Title}.",
                Start = order.DateTime.Date.AddHours(+10),
                End = order.DateTime.Date.AddHours(+18),
                Location = $"Desk located on the {order.Desk.Room.Floor} floor in the {order.Desk.RoomId} room."
            };
            EmailService.SendСonfirmation(user.Email, Event);
        }
        public void BookingConfirmed(Order order)
        {
            User user = DataBase.UserRepository.Read(order.UserId);
            if (user.BookingConfirmationNotification) {
                SendEmailСonfirmation(order, user);
            }
        }
    }
}
