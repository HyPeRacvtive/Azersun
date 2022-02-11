using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessagesDal _messagesdal;

        public MessageManager(IMessagesDal messagesdal)
        {
            _messagesdal = messagesdal;
        }

        public void MessageAdd(Messages message)
        {
            _messagesdal.Insert(message);
                }
    }
}
