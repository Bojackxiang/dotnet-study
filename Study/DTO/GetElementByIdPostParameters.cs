namespace Study.DTO
{
    public class GetElementByIdPostParameters
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{nameof(Username)}: {Username}, {nameof(Password)}: {Password}";
        }
    }
}