/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public class CVRSettings // TypeDefIndex: 6478
	{
		// Fields
		private IVRSettings FnTable; // 0x10
	
		// Constructors
		public CVRSettings() {} // Dummy constructor
		internal CVRSettings(IntPtr pInterface) {} // 0x0000000186470710-0x0000000186470850
	
		// Methods
		public string GetSettingsErrorNameFromEnum(EVRSettingsError eError) => default; // 0x0000000186470100-0x00000001864701B0
		public bool Sync(bool bForce, ref EVRSettingsError peError) => default; // 0x0000000186470670-0x0000000186470710
		public void SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError) {} // 0x00000001864703A0-0x0000000186470450
		public void SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError) {} // 0x0000000186470510-0x00000001864705C0
		public void SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError) {} // 0x0000000186470450-0x0000000186470510
		public void SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError) {} // 0x00000001864705C0-0x0000000186470670
		public bool GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x000000018646FF10-0x000000018646FFB0
		public int GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x0000000186470060-0x0000000186470100
		public float GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) => default; // 0x000000018646FFB0-0x0000000186470060
		public void GetString(string pchSection, string pchSettingsKey, StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError) {} // 0x00000001864701B0-0x0000000186470270
		public void RemoveSection(string pchSection, ref EVRSettingsError peError) {} // 0x0000000186470310-0x00000001864703A0
		public void RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError) {} // 0x0000000186470270-0x0000000186470310
	}
}
