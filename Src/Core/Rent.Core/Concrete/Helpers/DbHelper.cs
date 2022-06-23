using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using Rent.Domain.Concrete;

namespace Rent.Core.Concrete.Helpers
{
    public static class DbHelper
    {
        static string _appPath = string.Empty;
        public static string DbsFiles_ConfigFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(_appPath))
                {
                    _appPath = Application.StartupPath;
                    _appPath += @"\DbFiles";
                    _appPath += @"\";
                    _appPath += "config.xml";
                }

                return _appPath;
            }
        }
        public static string ConnectionString
        {
            get
            {
                string cConString = string.Empty;
                XmlTextReader _configReader = new XmlTextReader(DbsFiles_ConfigFilePath);
                while (_configReader.Read())
                {
                    if (_configReader.NodeType == XmlNodeType.Element)
                    {
                        switch (_configReader.Name)
                        {
                            case "Servername":
                                cConString = "Server=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "Databasename":
                                cConString += "Initial Catalog=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "Username":
                                cConString += "user id=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "Password":
                                cConString += "password=" + Convert.ToString(_configReader.ReadString()) + ";";
                                break;
                        }
                    }
                }
                _configReader.Close();
                return cConString;
            }
        }
        public static string LogoConnectionString
        {
            get
            {
                string cConString = string.Empty;
                XmlTextReader _configReader = new XmlTextReader(DbsFiles_ConfigFilePath);
                while (_configReader.Read())
                {
                    if (_configReader.NodeType == XmlNodeType.Element)
                    {
                        switch (_configReader.Name)
                        {
                            case "LogoDBServername":
                                cConString = "Server=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "LogoDBDatabasename":
                                cConString += "Initial Catalog=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "LogoDBUsername":
                                cConString += "user id=" + Convert.ToString(_configReader.ReadString()) + @";";
                                break;
                            case "LogoDBPassword":
                                cConString += "password=" + Convert.ToString(_configReader.ReadString()) + ";";
                                break;
                        }
                    }
                }
                _configReader.Close();
                return cConString;
            }
        }
        public static LogoDbSetting LogoDbSettings
        {
            get
            {
                string cConString = string.Empty;
                XmlTextReader _configReader = new XmlTextReader(DbsFiles_ConfigFilePath);
                LogoDbSetting setting = new LogoDbSetting();
                while (_configReader.Read())
                {
                    if (_configReader.NodeType == XmlNodeType.Element)
                    {
                        switch (_configReader.Name)
                        {
                            case "LogoDBServername":
                                setting.LogoDBDataSource = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoDBDatabasename":
                                setting.LogoDBInitialCatalog = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoDBUsername":
                                setting.LogoDBUser = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoDBPassword":
                                setting.LogoDBPass = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoAppUsername":
                                setting.LogoDBUser = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoAppPassword":
                                setting.LogoDBPass = Convert.ToString(_configReader.ReadString());
                                break;
                            case "LogoAppPrNr":
                                setting.LogoAppPerNr = Convert.ToString(_configReader.ReadString());
                                SetLogoPeriodNumber = setting.LogoAppPerNr;
                                LogoFirmHelper.LogoPeriodNumber = GetLogoFirmNumber;
                                break;
                            case "LogoAppFirmNr":
                                setting.LogoAppFirmNr = Convert.ToString(_configReader.ReadString());
                                SetLogoFirmNumber = setting.LogoAppFirmNr;
                                LogoFirmHelper.LogoFirmNumber = GetLogoFirmNumber;
                                break;
                        }
                    }
                }
                _configReader.Close();
                return setting;
            }
        }
        public static void SaveIntegrationSetting(LogoDbSetting setting)
        {
            XmlDocument document = new XmlDocument();
            document.Load(DbsFiles_ConfigFilePath);
            document.SelectSingleNode("Netline/LogoConn/LogoDBServername").InnerText = setting.LogoDBDataSource;
            document.SelectSingleNode("Netline/LogoConn/LogoDBDatabasename").InnerText = setting.LogoDBInitialCatalog;
            document.SelectSingleNode("Netline/LogoConn/LogoDBUsername").InnerText = setting.LogoDBUser;
            document.SelectSingleNode("Netline/LogoConn/LogoDBPassword").InnerText = setting.LogoDBPass;
            document.SelectSingleNode("Netline/LogoConn/LogoIntegUsername").InnerText = setting.LogoAppUserID;
            document.SelectSingleNode("Netline/LogoConn/LogoIntegPassword").InnerText = setting.LogoAppPassword;
            document.SelectSingleNode("Netline/LogoConn/LogoIntegPrNr").InnerText = setting.LogoAppPerNr;
            document.SelectSingleNode("Netline/LogoConn/LogoIntegFirmNr").InnerText = setting.LogoAppFirmNr;
            document.Save(DbsFiles_ConfigFilePath);
        }
        public static string SetLogoFirmNumber { get; set; }
        public static string SetLogoPeriodNumber { get; set; }
        public static string GetLogoFirmNumber
        {
            get
            {
                if (string.IsNullOrEmpty(SetLogoFirmNumber))
                    return string.Empty;
                var firmNumber = SetLogoFirmNumber.PadLeft(3, '0');
                LogoFirmHelper.LogoFirmNumber = firmNumber;
                return firmNumber;
            }
        }
        public static string GetLogoPeriodNumberNumber
        {
            get
            {
                if (string.IsNullOrEmpty(SetLogoPeriodNumber))
                    return string.Empty;
                var periodNumber = SetLogoPeriodNumber.PadLeft(2, '0');
                LogoFirmHelper.LogoPeriodNumber = periodNumber;
                return periodNumber;
            }
        }
        public static int GetLogoFirmNumber_Int
        {
            get
            {
                if (string.IsNullOrEmpty(SetLogoFirmNumber))
                    return Convert.ToInt32(SetLogoFirmNumber);
                else
                    return 0;
            }
        }

    }
}
