namespace BusinessLogic.Extensions
{
    public static class MovieExtensions
    {
        public static DTO.Movie ToDTO(this DomainModels.Movie m)
        {
            return new DTO.Movie()
            {
                Id = m.Id,
                Name = m.Name,
                Genre = m.Genre,
                UserId = m.UserId
            };
        }
    }
}
