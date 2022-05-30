using ConcecionariaVehiculos.Data;

namespace ConcecionariaVehiculos.Repository.Class
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
{
        protected readonly ApplicationDBContext _context;

        public GenericRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(int? id)
        {
            var entity = GetById(id);
            if (entity == null)
            {
                throw new Exception("No se encontró el objeto.");
            }
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int? id)
        {
            var entity = _context.Set<T>().Find(id);
            return entity;
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
