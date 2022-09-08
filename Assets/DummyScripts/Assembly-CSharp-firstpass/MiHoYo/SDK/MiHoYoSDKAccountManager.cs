/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKAccountManager // TypeDefIndex: 8700
	{
		// Fields
		private const string OLD_ACCOUNT_DATA_LIST = "ACCOUNT_DATA_LIST_FILE"; // Metadata: 0x00AE2004
		private const string ACCOUNT_DATA_LIST = "MIHOYOSDK_ADL_"; // Metadata: 0x00AE201E
		private MiHoYoSDKUserDataModel userData; // 0x10
		private static MiHoYoSDKAccountManager _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKAccountManager() {} // 0x00000001859EB9A0-0x00000001859EBA00
	
		// Methods
		// [XID] // 0x0000000189A86CE0-0x0000000189A86D00
		public static MiHoYoSDKAccountManager Instance() => default; // 0x00000001859EADB0-0x00000001859EAEB0
		// [XID] // 0x000000018983F5D0-0x000000018983F5F0
		public void Init() {} // 0x00000001859EAD10-0x00000001859EADB0
		// [XID] // 0x00000001898E2A80-0x00000001898E2AA0
		private List<MiHoYoSDKUserDataModel> GetAccount() => default; // 0x00000001859EA420-0x00000001859EA6E0
		// [XID] // 0x000000018986B7C0-0x000000018986B7E0
		private List<MiHoYoSDKUserDataModel> GetOldAccount() => default; // 0x00000001859EABA0-0x00000001859EAD10
		// [XID] // 0x0000000189AA4C70-0x0000000189AA4C90
		public MiHoYoSDKUserDataModel GetCurrentAccount() => default; // 0x00000001859EA7A0-0x00000001859EA880
		// [XID] // 0x0000000189ACE2F0-0x0000000189ACE310
		public string GetAccountName() => default; // 0x00000001859EA2D0-0x00000001859EA420
		// [XID] // 0x0000000189AB3BE0-0x0000000189AB3C00
		public string GetAsteriskName() => default; // 0x00000001859EA6E0-0x00000001859EA7A0
		// [XID] // 0x0000000189ABB850-0x0000000189ABB870
		public void SetAccount(MiHoYoSDKUserDataModel account) {} // 0x00000001859EB2E0-0x00000001859EB720
		// [XID] // 0x0000000189AC2FD0-0x0000000189AC2FF0
		private void ResetOldAccount() {} // 0x00000001859EB1B0-0x00000001859EB2E0
		// [XID] // 0x00000001899DD120-0x00000001899DD140
		public static bool IsBindMobileAccount(MiHoYoSDKUserDataModel user) => default; // 0x00000001859EB0D0-0x00000001859EB1B0
		// [XID] // 0x0000000189924D20-0x0000000189924D40
		public bool IsAccountRealName() => default; // 0x00000001859EAFA0-0x00000001859EB0D0
		// [XID] // 0x00000001899E4A30-0x00000001899E4A50
		public bool IsAccountBindMobile() => default; // 0x00000001859EAEB0-0x00000001859EAFA0
		// [XID] // 0x00000001899CE320-0x00000001899CE340
		public void SetAutoLoginAccount(string jsonString) {} // 0x00000001859EB720-0x00000001859EB9A0
		// [XID] // 0x0000000189AE8BF0-0x0000000189AE8C10
		public string GetName(MiHoYoSDKUserDataModel userData) => default; // 0x00000001859EA880-0x00000001859EABA0
	}
}
