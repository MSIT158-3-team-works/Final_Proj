namespace projRESTfulApiFitConnect.DTO
{
    public class FieldInfoDto
    {
        public int GymId { get; set; }
        public string? FieldName { get; set; } = null!;
        public string? Floor { get; set; } = null!;
        public string? FieldPhoto { get; set; } = null!;
        public string? FieldDescribe { get; set; } = null!;
        public bool Status { get; set; }
    }
}
