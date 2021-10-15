namespace Project.Models
{
    public class MasterModel<T>
    {
        public bool Status { get; set;  }
        public T Result { get; set; }
        public string[] Errors { get; set; }
    }
}
