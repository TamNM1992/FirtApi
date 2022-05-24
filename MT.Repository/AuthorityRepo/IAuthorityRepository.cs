using MT.Data.Dtos;

namespace MT.Repository.AuthorityRepo
{
    public interface IAuthorityRepository
    {
        public bool AddAuthority(AuthorityDto authority);
    }
}
