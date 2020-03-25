namespace Tedee.Api.CodeSamples.Actions
{
    public abstract class ActionsBase
    {
        protected ApiHttpClient _apiClient { get; }

        public ActionsBase(ApiHttpClient apiClient)
        {
            _apiClient = apiClient;
        }
    }
}
