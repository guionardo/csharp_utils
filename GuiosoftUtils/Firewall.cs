using System;
using System.Collections.Generic;
using System.Management;

namespace Guiosoft
{
    /// <summary>
    /// Firewall information
    /// </summary>
    public struct FWInfo
    {
        /// <summary>
        /// Firewall name
        /// </summary>
        public string Name;

        public override string ToString() => Name;
    }

    public static class Firewall
    {
        private static FWInfo[] _FWList = null;

        public static FWInfo[] FWList
        {
            get
            {
                if (_FWList == null)
                {
                    List<FWInfo> afw = new List<FWInfo>();
                    try
                    {
                        foreach (ManagementObject fw in new ManagementObjectSearcher(@"root\SecurityCenter" + (Environment.OSVersion.Version.Major <= 5 ? "" : "2"), "SELECT * FROM FirewallProduct").Get())
                        {
                            FWInfo fwi = new FWInfo { Name = fw["displayName"].ToString() };
                            afw.Add(fwi);
                        }
                    }
                    catch
                    {
                    }
                    _FWList = afw.ToArray();
                }
                return _FWList;
            }
        }

        public static string FWInfo()
        {
            string r = "";
            for (int i = 0; i < FWList.Length; i++)
                r += _FWList[i] + ", ";
            if (!string.IsNullOrEmpty(r))
                r = r.Substring(0, r.Length - 2);
            return r;
        }
    }
}