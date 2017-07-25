using System;
using System.Collections.Generic;
using System.Management;

namespace Guiosoft
{
    /// <summary>
    /// Antivirus information
    /// </summary>
    public struct AVInfo
    {
        /// <summary>
        /// Date of the last update on virus
        /// </summary>
        public DateTime LastUpdate;

        /// <summary>
        /// Name of antivirus
        /// </summary>
        public string Name;
        public override string ToString() => Name + " [" + LastUpdate.ToString() + "]";
    }

    /// <summary>
    /// Class for antivirus identification installed on the operating system.
    /// </summary>
    public static class Antivirus
    {
        private static AVInfo[] _AVList = null;

        /// <summary>
        /// List of the antivirus installed
        /// </summary>
        public static AVInfo[] AVList
        {
            get
            {
                if (_AVList == null)
                {
                    List<AVInfo> avl = new List<AVInfo>();
                    try
                    {
                        foreach (ManagementObject av in new ManagementObjectSearcher(@"root\SecurityCenter" + (Environment.OSVersion.Version.Major <= 5 ? "" : "2"), "SELECT * FROM AntiVirusProduct").Get())
                        {
                            AVInfo avi = new AVInfo { Name = av["displayName"].ToString() };
                            DateTime.TryParse(av["timestamp"].ToString(), out avi.LastUpdate);
                            avl.Add(avi);
                        }
                    }
                    catch
                    {
                    }
                    _AVList = avl.ToArray();
                }
                return _AVList;
            }
        }

        /// <summary>
        /// Returns all the antivirus installed on the system
        /// </summary>
        /// <returns></returns>
        public static string AVInfo()
        {
            string r = "";
            for (int i = 0; i < AVList.Length; i++)
                r += _AVList[i] + ", ";
            if (!string.IsNullOrEmpty(r))
                r = r.Substring(0, r.Length - 2);
            return r;
        }

        /// <summary>
        /// Update the list of antivirus
        /// </summary>
        public static void Update()
        {
            _AVList = null;
            var x = AVList;
        }
    }
}