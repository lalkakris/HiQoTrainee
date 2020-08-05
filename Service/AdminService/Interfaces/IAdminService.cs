﻿using Service.AdminService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.AdminService.Interfaces
{
    public interface IAdminService
    {
        List<WorkingDayCalendarDto> GetWorkingDayCalendars();
        List<UserDto> GetUsers();
        List<UserDto> OrderUsersBy<TKey>(Func<UserDto, TKey> key);
        List<UserDto> FilterBy(Func<UserDto, bool> predicate, List<UserDto> users);
        void UpdateWorkPlan(UserDto user, WorkPlanDto workPlan);
        void UpdateDesk(UserDto user, DeskDto desk);
        void SetDayOff(WorkingDayCalendarDto calendar);
    }
}