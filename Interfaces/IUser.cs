﻿namespace BuilderDemo.Interfaces
{
    public interface IUser: ITicketHolder
    {
        void SetIdentity(IUserIdentity identity);
        bool CanAcceptIdentity(IUserIdentity identity);
    }
}
