namespace Tass_BLL.ViewModes.ResponseResult
{
    internal class ResponseResult
    {
        public record Response<T>(T Result, string? ErrorMassage, bool IsThereErrorOrNot);
    }
}
