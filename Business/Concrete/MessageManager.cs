using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessagesDal _messagesdal;

        public MessageManager(IMessagesDal messagesdal)
        {
            _messagesdal = messagesdal;
        }

        public void Add(Messages t)
        {
            _messagesdal.Insert(t);
        }

        public void Delete(Messages t)
        {
            _messagesdal.Delete(t);
        }

        public Messages GetById(int id)
        {
            return _messagesdal.GetById(id);
        }

        public List<Messages> GetList()
        {
            return _messagesdal.GetListAll();
        }

        public List<Messages> GetListById(int id)
        {
            return _messagesdal.GetListAllById(x => x.Id == id);
        }

        public void Update(Messages t)
        {
            _messagesdal.Update(t);
        }
    }
}
