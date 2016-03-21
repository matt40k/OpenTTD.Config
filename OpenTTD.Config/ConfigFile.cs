using System;
using System.IO;

namespace OpenTTD.Config
{
    public class ConfigFile
    {
        string _dir = null;

        public ConfigFile()
        {
            SetDirectory = GetDefaultDirectory;
        }

        public ConfigFile(string dir)
        {
            if (Directory.Exists(dir))
                _dir = dir;
        }

        public string GetFileName
        {
            get { return "openttd.cfg"; }
        }

        public string GetFilePath
        {
            get { return Path.Combine(GetDirectory, GetFileName; }
        }

        public string GetDirectory
        {
            get
            {
                if (!string.IsNullOrEmpty(_dir) && Directory.Exists(_dir))
                    return _dir;
            }
        }

        public string SetDirectory
        {
            set
            {
                if (Directory.Exists(value))
                    _dir = value;
            }
        }

        public string GetDefaultDirectory
        {
            get
            {
                string myDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (Directory.Exists(myDoc))
                {
                    string configDir = Path.Combine(myDoc, "OpenTTD");
                    if (!Directory.Exists(configDir))
                    {
                        // The folder doesn't exist yet, lets try create it
                        try
                        {
                            Directory.CreateDirectory(configDir);
                        }
                        catch (IOException CreateConfigDir)
                        {
                            
                        }
                        catch (UnauthorizedAccessException DeniedCreateConfigDir)
                        {

                        }
                    }
                    if (Directory.Exists(configDir))
                        return configDir;
                }
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }
    }
}
