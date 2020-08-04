﻿using System;
using DB.Entity;

namespace Service.AdminService.DTO.Entities
{
    public class WorkingDaysCalendarDto
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? WorkStartTime { get; set; }
        public TimeSpan? WorkEndTime { get; set; }
        public bool IsOff { get; set; }
        public RoomDto Room { get; set; }

        public static implicit operator WorkingDaysCalendarDto(WorkingDaysCalendar calendar)
        {
            return new WorkingDaysCalendarDto()
            {
                Id = calendar.Id,
                Date = calendar.Date,
                WorkStartTime = calendar.WorkStartTime,
                WorkEndTime = calendar.WorkEndTime,
                IsOff = calendar.IsOff,
                Room = calendar.Room
            };
        }

        public static explicit operator WorkingDaysCalendar(WorkingDaysCalendarDto calendar)
        {
            return new WorkingDaysCalendar()
            {
                Id = calendar.Id,
                Date = calendar.Date,
                WorkStartTime = calendar.WorkStartTime,
                WorkEndTime = calendar.WorkEndTime,
                IsOff = calendar.IsOff,
                Room = (Room) calendar.Room
            };
        }
    }
}