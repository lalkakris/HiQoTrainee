﻿using DB.EnttityStatus;
using DB.LookupTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entity
{
    [Table("Users")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id")]
        public int ID { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")] 
        public string LastName { get; set; }

        [Required]
        [Column("user_email")]
        public string Email { get; set; }

        [Required]
        [ForeignKey("positions_id")]
        public UserPosition Position { get; set; }

        [Required]
        [ForeignKey("role_id")]
        public UserRole Role { get; set; }

        
        [ForeignKey("workplan_id")]
        public WorkPlan WorkPlan { get; set; }

        [ForeignKey("room_id")]
        public Room Room { get; set; }

        [ForeignKey("desk_id")]
        public Desk Desk { get; set; }

        [Column("date_of_change_plan")]
        public DateTime? PlanChangeDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        
        public User(int Id,  string firstName, string lastName, string position)
        {
            ID = Id;
            FirstName = firstName;
            LastName = lastName;
            Role = (UserRole)Enum.Parse(typeof(UserRole), position);
        }
        public User(int Id, string firstName, string lastName)
        {
            ID = Id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
