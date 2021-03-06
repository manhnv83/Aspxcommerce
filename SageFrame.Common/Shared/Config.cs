﻿/*
SageFrame® - http://www.sageframe.com
Copyright (c) 2009-2010 by SageFrame
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Configuration;
using SageFrame.Web;
using System.IO;
using SageFrame.Application;
using System.Security.Cryptography;
using System.Text;

namespace SageFrame.Utilities
{   
    public class Config
    {
        public static string DataBaseOwner = GetDataBaseOwner();
        public static string ObjectQualifer = GetObjectQualifer();
        private string _SageFrameInstalled = string.Empty;

        public Config()
        {
           
        }        

        public static XmlDocument AddAppSetting(XmlDocument xmlDoc, string Key, string Value)
        {
            XmlElement xmlElement = default(XmlElement);

            // retrieve the appSettings node 
            XmlNode xmlAppSettings = xmlDoc.SelectSingleNode("//appSettings");

            if ((xmlAppSettings != null))
            {
                // get the node based on key
                XmlNode xmlNode = xmlAppSettings.SelectSingleNode(("//add[@key='" + Key + "']"));

                if ((xmlNode != null))
                {
                    // update the existing element
                    xmlElement = (XmlElement)xmlNode;
                    xmlElement.SetAttribute("value", Value);
                }
                else
                {
                    // create a new element
                    xmlElement = xmlDoc.CreateElement("add");
                    xmlElement.SetAttribute("key", Key);
                    xmlElement.SetAttribute("value", Value);
                    xmlAppSettings.AppendChild(xmlElement);
                }
            }

            // return the xml doc
            return xmlDoc;
        }

        public static void AddSiteMapProvider(string providerName, string providerType, string siteMapPath, string securityTrimmingEnabled)
        {
            XmlDocument xmlDoc = Load();
            XmlElement xmlElement = default(XmlElement);

            // retrieve the SiteMapProvider node 
            XmlNode xmlSiteMapSettings = xmlDoc.SelectSingleNode("//system.web/siteMap/providers");
            if ((xmlSiteMapSettings != null))
            {
                // create a new element
                XmlNode xmlNode = xmlSiteMapSettings.SelectSingleNode(("//add[@name='" + providerName + "']"));
                if (xmlNode != null)
                {
                    // update the existing element
                    xmlElement = (XmlElement)xmlNode;
                    xmlElement.SetAttribute("type", providerType);
                    xmlElement.SetAttribute("siteMapFile", siteMapPath);
                    xmlElement.SetAttribute("securityTrimmingEnabled", securityTrimmingEnabled);
                }
                else
                {
                    xmlElement = xmlDoc.CreateElement("add");
                    xmlElement.SetAttribute("name", providerName);
                    xmlElement.SetAttribute("type", providerType);
                    xmlElement.SetAttribute("siteMapFile", siteMapPath);
                    xmlElement.SetAttribute("securityTrimmingEnabled", securityTrimmingEnabled);
                    xmlSiteMapSettings.AppendChild(xmlElement);
                }
            }
            Save(xmlDoc);
        }

        public static void DeleteSiteMapProvider(string providerName)
        {
            XmlDocument xmlDoc = Load();
            // retrieve the SiteMapProvider node 
            XmlNode xmlSiteMapSettings = xmlDoc.SelectSingleNode("//system.web/siteMap/providers");
            if ((xmlSiteMapSettings != null))
            {
                // get the node based on key
                XmlNode xmlNode = xmlSiteMapSettings.SelectSingleNode(("//add[@name='" + providerName + "']"));
                
                if ((xmlNode != null))
                {
                    xmlSiteMapSettings.RemoveChild(xmlNode);
                }                
            }
            Save(xmlDoc);
        }

        public static void BackupConfig()
        {   
            string backupFolder = SystemSetting.glbConfigFolder + "Backup_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + "\\";

            //save the current config files
            try
            {
                SageFrame.Application.Application app = new SageFrame.Application.Application();                
                if (!Directory.Exists(app.ApplicationMapPath + backupFolder))
                {
                    Directory.CreateDirectory(app.ApplicationMapPath + backupFolder);
                }

                if (File.Exists(app.ApplicationMapPath + "\\web.config"))
                {
                    File.Copy(app.ApplicationMapPath + "\\web.config", app.ApplicationMapPath + backupFolder + "web_old.config", true);
                }
            }
            catch (Exception ex)
            {
                //Error backing up old web.config 
                //This error is not critical, so can be ignored
                throw ex;
            }

        }

        public static string GetConnectionString(string name)
        {
            string connectionString = "";

            //First check if connection string is specified in <connectionstrings> (ASP.NET 2.0 / DNN v4.x)
            if (!string.IsNullOrEmpty(name))
            {
                connectionString = WebConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
            return connectionString;
        }

        public static string GetSetting(string setting)
        {
            return WebConfigurationManager.AppSettings[setting];
        }

        public static object GetSection(string section)
        {
            return WebConfigurationManager.GetWebApplicationSection(section);
        }

        public static string GetNodeValue(XmlNode objNode, string NodeName)
        {
            string DefaultValue = string.Empty;
            string strValue = DefaultValue;

            if ((objNode[NodeName] != null))
            {
                strValue = objNode[NodeName].InnerText;

                if (string.IsNullOrEmpty(strValue) & !string.IsNullOrEmpty(DefaultValue))
                {
                    strValue = DefaultValue;
                }
            }

            return strValue;
        }

        public static XmlDocument Load()
        {
            return Load("web.config");
        }

        public static XmlDocument Load(string filename)
        {
            SageFrame.Application.Application app = new SageFrame.Application.Application();
            // open the config file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(app.ApplicationMapPath + "\\" + filename);
            // test for namespace added by Web Admin Tool
            if (!string.IsNullOrEmpty(xmlDoc.DocumentElement.GetAttribute("xmlns")))
            {
                // remove namespace
                string strDoc = xmlDoc.InnerXml.Replace("xmlns=\"http://schemas.microsoft.com/.NetConfiguration/v3.0\"", "");
                xmlDoc.LoadXml(strDoc);
            }
            return xmlDoc;
        }

        public static string Save(XmlDocument xmlDoc)
        {
            return Save(xmlDoc, "web.config");
        }

        public static string Save(XmlDocument xmlDoc, string filename)
        {
            try
            {
                SageFrame.Application.Application app = new SageFrame.Application.Application();
                string strFilePath = app.ApplicationMapPath + "\\" + filename;
                FileAttributes objFileAttributes = FileAttributes.Normal;
                if (File.Exists(strFilePath))
                {
                    // save current file attributes
                    objFileAttributes = File.GetAttributes(strFilePath);
                    // change to normal ( in case it is flagged as read-only )
                    File.SetAttributes(strFilePath, FileAttributes.Normal);
                }
                // save the config file
                XmlTextWriter writer = new XmlTextWriter(strFilePath, null);
                writer.Formatting = Formatting.Indented;
                xmlDoc.WriteTo(writer);
                writer.Flush();
                writer.Close();
                // reset file attributes
                File.SetAttributes(strFilePath, objFileAttributes);
                return "";
            }
            catch (Exception exc)
            {
                // the file permissions may not be set properly
                return exc.Message;
            }
        }

        public static void Touch()
        {
            SageFrame.Application.Application app = new SageFrame.Application.Application();
            File.SetLastWriteTime(app.ApplicationMapPath + "\\web.config", System.DateTime.Now);
        }

        public static void UpdateConnectionString(string conn)
        {
            XmlDocument xmlConfig = Load();
            //XmlNode xmlConnectionString = ((XmlNode)GetSection("sageframe/data"));
            //string name = xmlConnectionString.Attributes["SageFrameConnectionString"].ToString();
            

            //Update ConnectionStrings
            string name = "SageFrameConnectionString";
            XmlNode xmlConnection = xmlConfig.SelectSingleNode("configuration/connectionStrings/add[@name='" + name + "']");
            UpdateAttribute(xmlConnection, "connectionString", conn);

            //Update AppSetting
            string dbAppKey = "DatabaseName";
            string dbName = SeparateDatabaseName(conn);
            XmlNode xmlAppSetting = xmlConfig.SelectSingleNode("configuration/appSettings/add[@key='" + dbAppKey + "']");
            UpdateAttribute(xmlAppSetting, "value", dbName);

            //Update sqlCacheDependency
            //XmlNode xmlsqlCacheDependency = xmlConfig.SelectSingleNode("configuration/system.web/caching/sqlCacheDependency/databases/add[@connectionStringName='" + name + "']");
            //UpdateAttribute(xmlsqlCacheDependency, "name", dbName);
            //Save changes
            Save(xmlConfig);

        }

        public static string SeparateDatabaseName(string conn)
        {
            string dbName = string.Empty;
            string[] connectionParams = conn.Split(';');
            foreach (string connectionParam in connectionParams)
            {
                int index = connectionParam.IndexOf("=");
                if (index > 0)
                {
                    string key = connectionParam.Substring(0, index);
                    string value = connectionParam.Substring(index + 1);
                    switch (key.ToLower())
                    {
                        case "database":
                        case "initial catalog":
                            dbName = value;
                            break;
                    }
                }
            }
            return dbName;
        }

        //public static void UpdateDataProvider(string name, string databaseOwner, string objectQualifier)
        //{
        //    XmlDocument xmlConfig = Load();

        //    //Update provider
        //    XmlNode xmlProvider = xmlConfig.SelectSingleNode("configuration/sageframe/data/providers/add[@name='" + name + "']");
        //    UpdateAttribute(xmlProvider, "databaseOwner", databaseOwner);
        //    UpdateAttribute(xmlProvider, "objectQualifier", objectQualifier);

        //    //Save changes
        //    Save(xmlConfig);

        //}

        public static string UpdateMachineKey()
        {
            string backupFolder = SystemSetting.glbConfigFolder + "Backup_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + "\\";
            XmlDocument xmlConfig = new XmlDocument();
            string strError = "";

            //save the current config files
            BackupConfig();

            try
            {
                // open the web.config
                xmlConfig = Load();

                // create random keys for the Membership machine keys
                xmlConfig = UpdateMachineKey(xmlConfig);
            }
            catch (Exception ex)
            {
                strError += ex.Message;
            }

            // save a copy of the web.config
            strError += Save(xmlConfig, backupFolder + "web_.config");

            // save the web.config
            strError += Save(xmlConfig);

            return strError;
        }

        private static XmlDocument UpdateMachineKey(XmlDocument xmlConfig)
        {
            Config objSecurity = new Config();
            string validationKey = objSecurity.CreateKey(20);
            string decryptionKey = objSecurity.CreateKey(24);

            XmlNode xmlMachineKey = xmlConfig.SelectSingleNode("configuration/system.web/machineKey");
            UpdateAttribute(xmlMachineKey, "validationKey", validationKey);
            UpdateAttribute(xmlMachineKey, "decryptionKey", decryptionKey);

            xmlConfig = AddAppSetting(xmlConfig, "InstallationDate", System.DateTime.Today.ToShortDateString());
            xmlConfig = AddAppSetting(xmlConfig, "IsInstalled", "true");

            return xmlConfig;

        }

        public string CreateKey(int numBytes)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[numBytes];

            rng.GetBytes(buff);

            return BytesToHexString(buff);
        }

        private string BytesToHexString(byte[] bytes)
        {
            StringBuilder hexString = new StringBuilder(64);

            int counter = 0;
            for (counter = 0; counter <= bytes.Length - 1; counter++)
            {
                hexString.Append(String.Format("{0:X2}", bytes[counter]));
            }

            return hexString.ToString();
        }

        public static void UpdateAttribute(XmlNode node, string attName, string attValue)
        {
            if ((node != null))
            {
                XmlAttribute attrib = node.Attributes[attName];
                attrib.InnerText = attValue;
            }
        }

        //public static string GetProviderConfiguration(string strProvider)
        //{
        //    return GetSection("sageframe/" + strProvider);
        //Return CType(Config.GetSection("sageframe/" & strProvider), ProviderConfiguration)
        //}

        public static string GetProviderPath(string type)
        {           
            XmlNode section = (XmlNode)GetSection("sageframe/" + type);
            string _providerPath = section.Attributes["providerPath"].ToString();
            return _providerPath;
        }

        public static string GetDataBaseOwner()
        {
            string _databaseOwner = GetSetting("databaseOwner").ToString();
            if (_databaseOwner != "" && _databaseOwner.EndsWith(".") == false)
            {
                _databaseOwner += ".";
            }
            return _databaseOwner;
        }

        public static string GetObjectQualifer()
        {
            string _objectQualifier = GetSetting("objectQualifier").ToString();
            if ((_objectQualifier != "") && (_objectQualifier.EndsWith("_") == false))
            {
                _objectQualifier += "_";
            }
            return _objectQualifier;
        }

        //public static string GetUpgradeConnectionString()
        //{
        //    string _upgradeConnectionString = GetSetting("upgradeConnectionString").ToString(); 
        //    return _upgradeConnectionString;
        //}

        public static System.Version GetDatabaseVersion()
        {
            string _databaseVersion = GetSetting("databaseVersion").ToString();
            return new System.Version(_databaseVersion);
        }

        public static string GetInstallOrNot()
        {
            string _SageFrameInstalled = GetSetting("installed").ToString();
            return _SageFrameInstalled;
        }

    }
}
