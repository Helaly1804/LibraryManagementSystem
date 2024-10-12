namespace LibraryManagementSystem.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int Total_Cost { get; set; }
        public DateOnly CheckOut_Date { get; set; }
        public DateOnly Return_Date { get; set; }
        public DateOnly Due_Date {  get; set; }
        public DateOnly OverDueDateDays;



    }
}
