using AutoMapper;
using MT.Common.Enums;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Repository.AuthorityRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AuthorityServices
{
    public class AuthorityService : IAuthorityService
    {
        private IAuthorityRepository _authorityRepository;
        private IMapper _mapper;

        public AuthorityService(IAuthorityRepository authority, IMapper mapper)
        {
            //  mình gọi thằng authority trong pipeline ra, gắn nó vào thằng _authorityRepository để dùng
            _authorityRepository = authority;
            _mapper = mapper;
        }
        public bool AddAuthority(AuthorityDto authorityDto)
        {
            var temp = _authorityRepository.AddAuthority(authorityDto);
            return temp;
        }
        public bool CheckUserRole(Role[] roles, Guid userId)
        {
            // 1 action cho phép nhiều quyền có thể truy cập. 1 user thì có thể có nhiều quyền
            // ví dụ sửa điểm thì giáo viên chủ nhiệm - trưởng khoa - hiệu trưởng - hiệu phó
            // ông A có quyền trưởng khoa, quyền giám thị, quyền ra đề ...
            // => vậy ông A có quyền vào sửa điểm (quyền trưởng khoa)
            var roleByUsers = _authorityRepository.GetAuthorityByUser(userId);
            if(roleByUsers != null && roleByUsers.Any(x=> roles.Contains((Role)Enum.Parse(typeof(Role), x.Code, true))))
                return true;
            return false;
        }
    }
}
