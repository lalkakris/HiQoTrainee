﻿using DB.Entity;
using DB.EntityStatus;
using Service.BookingService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.BookingService.Helpers
{
    class DeskStatusHelper
    {
        protected readonly DateTime _time;
        public DeskStatusHelper(DateTime dateTime)
        {
  
           
            _time = dateTime;
        }

        public BookingDeskDTO Count(Desk desk)
        {
            BookingDeskDTO resultDesk = desk;
            if (desk.Status != DeskStatus.Fixed)
            {
                var orders = desk.Orders.Where(x => x.Desk==desk && x.DateTime == _time && (x.Status == BookingStatus.Booked || x.Status == BookingStatus.Used));
                if (orders.Count() != 0)
                {
                    resultDesk.User = orders.ToList()[0].User;
                    resultDesk.Status = DeskStatus.Booked;
                }
            }
            return resultDesk;
        }
    }
}