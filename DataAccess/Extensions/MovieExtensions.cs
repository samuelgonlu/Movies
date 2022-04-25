namespace DataAccess.Extensions
{
    public static class MovieExtensions
    {
        public static BusinessLogic.DomainModels.Movie ToDomainModel(this Models.Movie m)
        {
            return new BusinessLogic.DomainModels.Movie
            {
                Id = m.Id,
                Name = m.Name,
                Genre = m.Genre,
                UserId = m.UserId.ToString(),
            };
        }
    }
}
