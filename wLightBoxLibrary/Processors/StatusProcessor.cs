
namespace wLightBoxLibrary
{
    public static class StatusProcessor
    {
        public static async Task<Rgbw> LoadState(string connectingMethod)
        {
            string url = $"{ connectingMethod }/api/rgbw/state";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ResultModel state = await response.Content.ReadAsAsync<ResultModel>();
                    return state.Rgbw;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }

        }
    }
}
