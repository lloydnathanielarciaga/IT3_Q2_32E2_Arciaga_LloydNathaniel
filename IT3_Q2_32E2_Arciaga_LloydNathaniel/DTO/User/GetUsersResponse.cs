namespace IT3_Q2_32E2_Arciaga_LloydNathaniel.DTO.User
{
    public class GetUsersResponse
    {
        public List<GetUsersDTO> Users { get; set; }
        public int TotalCount => Users?.Count ?? 0;
    }

    public class GetUsersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
