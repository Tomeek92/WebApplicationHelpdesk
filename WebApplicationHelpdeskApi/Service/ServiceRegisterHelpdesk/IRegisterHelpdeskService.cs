﻿using WebApplicationHelpdeskDomain.Entities.Register;

namespace WebApplicationHelpdeskApi.Service.ServiceRegisterHelpdesk
{
    public interface IRegisterHelpdeskService
    {
        Task Create(RegisterForHelpdesk registerForHelpdesk);
    }
}