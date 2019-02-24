using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IUserSettingsService
    {
        UserSettings Get();
        void Save(UserSettings userSettings);
    }
}
