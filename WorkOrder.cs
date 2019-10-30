namespace WOI
{
    public class WorkOrder
    {
        public int Id { get; set; }
        public string WorkOrderNumber { get; set; }
        public string MaterialNumber { get; set; }
        public string Seq_no_ { get; set; }
        public string Priority { get; set; }
        public string MaterialDescription { get; set; }
        public string Target_qty { get; set; }
        public string Del_qty { get; set; }
        public string Bsc_start { get; set; }
        public string Release { get; set; }
        public string MRP_ctrlr { get; set; }
        public string Order_Type { get; set; }
        public string System_Status { get; set; }
    }
}