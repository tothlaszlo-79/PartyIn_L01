namespace PartyIn_L01.Models
{
    public static class Repository
    {
        private static List<GuestResponse> respones = 
            new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get { return respones; }
        }

        public static void AddResponse(GuestResponse guestResponse)
        {
            respones.Add(guestResponse);
        }


    }
}
