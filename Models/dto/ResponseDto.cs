namespace ObjectMapper.Models.dto
{
    public class ResponseDto
    {
        public bool IsSucces { get; set; }
        public object Result { get; set; } = true;
        public IList<string> DisplayMessage { get; set; }
        public IList<string> ErrorMessage { get; set; }
    }
}
