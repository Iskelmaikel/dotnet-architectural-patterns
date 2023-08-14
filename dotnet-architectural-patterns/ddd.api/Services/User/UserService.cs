namespace ddd.api.Services.User
{
    public class UserService : ServiceBase
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddUserResponse> AddNewAsync(AddUserRequest model)
        {
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                BirthDate = model.BirthDate,
                Depart = model.Depart
            };

            var repository = UnitOfWork.AsyncRepository<User>();
            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            return new AddUserResponse()
            {
                Id = user.Id,
                UserName = user.Username
            };
        }
    }
}
