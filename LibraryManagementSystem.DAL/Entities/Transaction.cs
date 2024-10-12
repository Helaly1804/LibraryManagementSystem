﻿using DataAccessLayer.entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSysytem.Models
{
    public class Transaction
    {
        public int ID { get; set; }

        public decimal Total_Cost { get; set; }

        public DateTime CheckOut_Date { get; set; }

        public DateTime Due_Date { get; set; }

        public int OverDueDate_Days { get; set; }

        public DateTime? Return_Date { get; set; }

        [ForeignKey("Librarian")]
        public int LibrarianID_FK { get; set; }
        public Librarian Librarian { get; set; }

        [ForeignKey("Member")]
        public int MemberID_FK { get; set; }
        public Member Member { get; set; }
    }

}
