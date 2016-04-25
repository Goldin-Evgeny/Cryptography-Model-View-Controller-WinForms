using System;
using Contracts;
using System.Diagnostics;

namespace DefaultCryptoBLL.Services
{
    /// <summary>
    /// Provides implemented mechaism to inform the event logger of specific event.
    /// </summary>
    public class Logger
    {
        #region Constructor

        public Logger()
        {
        }

        #endregion
        
        #region Public methods
        public void BadKeyFileRead()
        {
            if (!EventLog.SourceExists(DefaultCryptoBLL.Properties.Resources.source))
                EventLog.CreateEventSource(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.log);
            EventLog.WriteEntry(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.badKeyFile, EventLogEntryType.Error);
        }

        public void DecryptionEnded(string decryptedFileDirectory)
        {
            if (!EventLog.SourceExists(DefaultCryptoBLL.Properties.Resources.source))
                EventLog.CreateEventSource(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.log);
            string myEvent = String.Format(DefaultCryptoBLL.Properties.Resources.eventDecryptionEnded, decryptedFileDirectory);
            EventLog.WriteEntry(DefaultCryptoBLL.Properties.Resources.source, myEvent);
        }
        
        public void DecryptionStarted()
        {
            if (!EventLog.SourceExists(DefaultCryptoBLL.Properties.Resources.source))
                EventLog.CreateEventSource(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.log);

            EventLog.WriteEntry(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.eventDecryptionStarted);
        }

        public void EncryptionEnded(string encryptedFileDirectory, string keyFileDirectory)
        {
            if (!EventLog.SourceExists(DefaultCryptoBLL.Properties.Resources.source))
                EventLog.CreateEventSource(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.log);
            string myEvent = String.Format(DefaultCryptoBLL.Properties.Resources.eventEncryptionEnded, encryptedFileDirectory, keyFileDirectory);
            EventLog.WriteEntry(DefaultCryptoBLL.Properties.Resources.source, myEvent);
        }

        public void EncryptionStarted()
        {
            if (!EventLog.SourceExists(DefaultCryptoBLL.Properties.Resources.source))
                EventLog.CreateEventSource(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.log);

            EventLog.WriteEntry(DefaultCryptoBLL.Properties.Resources.source, DefaultCryptoBLL.Properties.Resources.eventEncryptionStarted);
        }

        #endregion
    }
}
