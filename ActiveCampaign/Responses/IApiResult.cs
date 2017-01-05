namespace ActiveCampaign.Responses
{
    public interface IApiResult
    {
        int ResultCode { get; set; }
    }
    
    public static class ApiResultHelper
    {
        public static bool HasError(this IApiResult result)
        {
            return result.ResultCode != 1;
        }
    }
}