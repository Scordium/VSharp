namespace VSharpPlus.Abstractions
{
    internal class ENDPOINTS
    {
        public static readonly string ApiPoint = "https://api.vk.com/method/";
        public static readonly string GetUser = ApiPoint + "users.get?";
        public static readonly string SendMessage = ApiPoint + "messages.send?";

        public static readonly string ConfirmServerSettings = ApiPoint + "groups.getCallbackConfirmationCode?";

    }
}