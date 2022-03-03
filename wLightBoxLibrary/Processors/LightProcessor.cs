namespace wLightBoxLibrary
{
    public class LightProcessor
    {

        // this class could be used to change both color and/or effect - depending on input in Rgbw lightSet
        public static async Task<Rgbw> ChangeLight(string connectingMethod, Rgbw lightSet)
        {
            string url = $"{ connectingMethod }/api/rgbw/set";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync<Rgbw>(url, lightSet))
            {
                if (response.IsSuccessStatusCode)
                {
                    Rgbw light = await response.Content.ReadAsAsync<Rgbw>();

                    return light;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(response.ReasonPhrase);
                }
            }

        }
    }
}