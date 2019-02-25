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
        private readonly string _userSettingsPath;
        private UserSettings _cachedUserSettings;

        public UserSettingsService(ILocalFileService localFileService, ISerializationService serializationService, string userSettingsPath)
        {
            _localFileService = localFileService;
            _serializationService = serializationService;
            _userSettingsPath = userSettingsPath;
        }

        public UserSettings Get()
        {
            return _cachedUserSettings ?? (_cachedUserSettings = GetUserSettingsFromStorage());
        }

        public void Save(UserSettings userSettings)
        {
            _cachedUserSettings = userSettings;
            var serializedData = _serializationService.Serialize(_cachedUserSettings);
            _localFileService.Save(serializedData, _userSettingsPath);
        }

        private UserSettings GetUserSettingsFromStorage()
        {
            var fileData = _localFileService.Get(_userSettingsPath);
            return _serializationService.Deserialize<UserSettings>(fileData);
        }
    }
}
