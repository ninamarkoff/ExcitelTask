namespace Excitel.Data.FileRepository
{
    public abstract class FileRepository<TEntity, TFileStream> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TFileStream : class
    {
        private readonly TFileStream _fileStream;

        public FileRepository(TFileStream fileStream)
        {
            this._fileStream = fileStream;
        }
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
