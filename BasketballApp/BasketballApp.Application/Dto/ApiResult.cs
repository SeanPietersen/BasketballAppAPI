namespace BasketballApp.Application.Dto
{
    public record ApiResult<T>
    {
        public bool IsSuccess { get; set; }
        public string[] Errors { get; set; }
        public T Body { get; set; }
    }
}
