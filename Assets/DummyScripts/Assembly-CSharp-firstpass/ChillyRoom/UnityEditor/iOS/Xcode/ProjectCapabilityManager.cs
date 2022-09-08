/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	public class ProjectCapabilityManager // TypeDefIndex: 10430
	{
		// Fields
		private readonly string m_BuildPath; // 0x10
		private readonly string m_TargetGuid; // 0x18
		private readonly string m_PBXProjectPath; // 0x20
		private readonly string m_EntitlementFilePath; // 0x28
		private PlistDocument m_Entitlements; // 0x30
		private PlistDocument m_InfoPlist; // 0x38
		protected internal PBXProject project; // 0x40
	
		// Constructors
		public ProjectCapabilityManager() {} // Dummy constructor
		public ProjectCapabilityManager(string pbxProjectPath, string entitlementFilePath, string targetName) {} // 0x0000000186EF8290-0x0000000186EF83F0
	
		// Methods
		// [XID] // 0x0000000189BD3490-0x0000000189BD34B0
		public void WriteToFile() {} // 0x0000000186EF8150-0x0000000186EF8290
		// [XID] // 0x0000000189847580-0x00000001898475A0
		public void AddiCloud(bool keyValueStorage, bool iCloudDocument, string[] customContainers) {} // 0x0000000186EF7470-0x0000000186EF7A50
		// [XID] // 0x000000018984ED60-0x000000018984ED80
		public void AddPushNotifications(bool development) {} // 0x0000000186EF6B80-0x0000000186EF6D80
		// [XID] // 0x00000001899103B0-0x00000001899103D0
		public void AddGameCenter() {} // 0x0000000186EF5340-0x0000000186EF5610
		// [XID] // 0x000000018985D100-0x000000018985D120
		public void AddWallet(string[] passSubset) {} // 0x0000000186EF6F20-0x0000000186EF72D0
		// [XID] // 0x00000001899270E0-0x0000000189927100
		public void AddSiri() {} // 0x0000000186EF6D80-0x0000000186EF6F20
		// [XID] // 0x000000018986C150-0x000000018986C170
		public void AddApplePay(string[] merchants) {} // 0x0000000186EF47E0-0x0000000186EF4A70
		// [XID] // 0x0000000189873650-0x0000000189873670
		public void AddInAppPurchase() {} // 0x0000000186EF5AD0-0x0000000186EF5BE0
		// [XID] // 0x0000000189944C50-0x0000000189944C70
		public void AddMaps(MapsOptions options) {} // 0x0000000186EF6080-0x0000000186EF6940
		// [XID] // 0x0000000189882180-0x00000001898821A0
		public void AddPersonalVPN() {} // 0x0000000186EF6940-0x0000000186EF6B80
		// [XID] // 0x00000001898897D0-0x00000001898897F0
		public void AddBackgroundModes(BackgroundModesOptions options) {} // 0x0000000186EF4D00-0x0000000186EF5190
		// [XID] // 0x0000000189890D40-0x0000000189890D60
		public void AddKeychainSharing(string[] accessGroups) {} // 0x0000000186EF5D80-0x0000000186EF6080
		// [XID] // 0x00000001898982E0-0x0000000189898300
		public void AddInterAppAudio() {} // 0x0000000186EF5BE0-0x0000000186EF5D80
		// [XID] // 0x000000018989F520-0x000000018989F540
		public void AddAssociatedDomains(string[] domains) {} // 0x0000000186EF4A70-0x0000000186EF4D00
		// [XID] // 0x00000001898A70C0-0x00000001898A70E0
		public void AddAppGroups(string[] groups) {} // 0x0000000186EF4550-0x0000000186EF47E0
		// [XID] // 0x00000001898AE9E0-0x00000001898AEA00
		public void AddHomeKit() {} // 0x0000000186EF5930-0x0000000186EF5AD0
		// [XID] // 0x00000001898B5D70-0x00000001898B5D90
		public void AddDataProtection() {} // 0x0000000186EF5190-0x0000000186EF5340
		// [XID] // 0x00000001898BD680-0x00000001898BD6A0
		public void AddHealthKit() {} // 0x0000000186EF5610-0x0000000186EF5930
		// [XID] // 0x00000001898C4FC0-0x00000001898C4FE0
		public void AddWirelessAccessoryConfiguration() {} // 0x0000000186EF72D0-0x0000000186EF7470
		// [XID] // 0x0000000189901740-0x0000000189901760
		private PlistDocument GetOrCreateEntitlementDoc() => default; // 0x0000000186EF7A50-0x0000000186EF7BA0
		// [XID] // 0x00000001898D3E50-0x00000001898D3E70
		private PlistDocument GetOrCreateInfoDoc() => default; // 0x0000000186EF7BA0-0x0000000186EF7D20
		// [XID] // 0x0000000189ADDA50-0x0000000189ADDA70
		private PlistElementString GetOrCreateStringElementInArray(PlistElementArray root, string value) => default; // 0x0000000186EF7D20-0x0000000186EF7FD0
		// [XID] // 0x00000001898E3240-0x00000001898E3260
		private PlistElementDict GetOrCreateUniqueDictElementInArray(PlistElementArray root) => default; // 0x0000000186EF7FD0-0x0000000186EF8150
	}
}
