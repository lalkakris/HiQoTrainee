﻿using DB.Entity;
using Service.AdminService.DTO.Entities;

namespace Service.AdminService.Changers
{
    public static class WorkPlanChanger
    {
        public static WorkPlan ChangeFromDto(WorkPlan plan, WorkPlanDto source)
        {
            plan.DeskGuaranteed = source.DeskGuaranteed;
            plan.MaxOfficeDay = source.MaxOfficeDay;
            plan.MinOfficeDay = source.MinOfficeDay;
            plan.Plan = source.Plan;
            plan.PlanDescription = source.PlanDescription;
            plan.Priority = source.Priority;
            return plan;
        }
    }
}