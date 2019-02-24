using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Services.Serializers;
using Services.Storage;

namespace Services
{
    class UserSettingsService : IUserSettingsService
    {
        private readonly ILocalFileService _localFileService;
        private readonly ISerializationService _serializationService;

        public UserSettingsService(ILocalFileService localFileService, ISerializationService serializationService)
        {
            _localFileService = localFileService;
            _serializationService = serializationService;
        }

        public UserSettings Get()
        {
            throw new NotImplementedException();
        }

        public void Save(UserSettings userSettings)
        {
            throw new NotImplementedException();
        }
    }
}
