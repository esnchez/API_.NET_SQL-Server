//using API___test.Core.Entities;
//using API___test.Core.Interfaces.IRepositories;
//using API___test.Core.Interfaces.UnitOfWork;
//using API___test.Infrastructure.Data;
//using System.Threading.Tasks;

//namespace API___test.Infrastructure.Repositories
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly IRepository<Employee> _employeeRepository;
//        private readonly IRepository<Company> _companyRepository;
//        private readonly IRepository<Team> _teamRepository;


//        public UnitOfWork(ApplicationDbContext context)
//        {
//            _context = context;
//        }


//        public IRepository<Employee> EmployeeRepository => _employeeRepository ?? new BaseRepository<Employee>(_context);

//        public IRepository<Company> CompanyRepository => _companyRepository ?? new BaseRepository<Company>(_context);

//        public IRepository<Team> TeamRepository => _teamRepository ?? new BaseRepository<Team>(_context);

//        //
//        //


//        public void Dispose()
//        {
//            if (_context != null)
//            {
//                _context.Dispose();
//            }
//        }

//        public void SaveChanges()
//        {
//            _context.SaveChanges();
//        }

//        public async Task SaveChangesAsync()
//        {
//           await _context.SaveChangesAsync();
//        }
//    }
//}
