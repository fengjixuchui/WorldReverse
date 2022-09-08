/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.PS4SDK
{
	public static class PS4SDKInterop // TypeDefIndex: 26479
	{
		// Fields
		private const string LIB_NAME = "PS4SDKPlugin"; // Metadata: 0x00B0C364
		public const int SCE_SYSTEM_PARAM_ENTER_BUTTON_ASSIGN_CIRCLE = 0; // Metadata: 0x00B0C374
		public const int SCE_SYSTEM_PARAM_ENTER_BUTTON_ASSIGN_CROSS = 1; // Metadata: 0x00B0C378
		private const int SCE_NP_COUNTRY_CODE_LENGTH = 2; // Metadata: 0x00B0C37C
		private const int SCE_USER_SERVICE_MAX_USER_NAME_LENGTH = 16; // Metadata: 0x00B0C380
		private const int SCE_NP_ONLINEID_MAX_LENGTH = 16; // Metadata: 0x00B0C384
		private const int SCE_OK = 0; // Metadata: 0x00B0C388
		public const int SCE_MSG_DIALOG_SYSMSG_TYPE_TRC_PSN_CHAT_RESTRICTION = 1; // Metadata: 0x00B0C38C
		public const int SCE_MSG_DIALOG_SYSMSG_TYPE_TRC_PSN_UGC_RESTRICTION = 2; // Metadata: 0x00B0C390
		public const int SCE_COMMON_DIALOG_STATUS_NONE = 0; // Metadata: 0x00B0C394
		public const int SCE_COMMON_DIALOG_STATUS_INITIALIZED = 1; // Metadata: 0x00B0C398
		public const int SCE_COMMON_DIALOG_STATUS_RUNNING = 2; // Metadata: 0x00B0C39C
		public const int SCE_COMMON_DIALOG_STATUS_FINISHED = 3; // Metadata: 0x00B0C3A0
	
		// Methods
		// [XID] // 0x0000000189B38110-0x0000000189B38130
		public static int SetContentRestriction(string[] countryCodeArray, int[] ageArray, int defaultAge) => default; // 0x0000000183BAC0B0-0x0000000183BAC200
		// [XID] // 0x0000000189B3FB20-0x0000000189B3FB40
		public static bool CheckNpAvailability() => default; // 0x0000000183BAAFC0-0x0000000183BAB060
		// [XID] // 0x0000000189B47380-0x0000000189B473A0
		public static int GetParentalControlInfo(out int chatRestriction, out int ugcRestriction) {
			chatRestriction = default;
			ugcRestriction = default;
			return default;
		} // 0x0000000183BAB840-0x0000000183BAB900
		// [XID] // 0x0000000189B4EC20-0x0000000189B4EC40
		public static int InitSystemMsgDialog() => default; // 0x0000000183BABBB0-0x0000000183BABC50
		// [XID] // 0x0000000189B56480-0x0000000189B564A0
		public static int ShowSystemMsgDialog(int dialogType) => default; // 0x0000000183BAC2A0-0x0000000183BAC340
		// [XID] // 0x0000000189B5DC30-0x0000000189B5DC50
		public static int GetMsgDialogStatus() => default; // 0x0000000183BAB660-0x0000000183BAB700
		// [XID] // 0x0000000189B65280-0x0000000189B652A0
		public static int ReleaseSystemMsgDialog() => default; // 0x0000000183BABE30-0x0000000183BABED0
		// [XID] // 0x0000000189B6C780-0x0000000189B6C7A0
		public static int InitializeNpToolkit2() => default; // 0x0000000183BABCF0-0x0000000183BABD90
		// [XID] // 0x0000000189B73EF0-0x0000000189B73F10
		public static int TerminateNpToolkit2() => default; // 0x0000000183BAC3E0-0x0000000183BAC480
		// [XID] // 0x0000000189B7B560-0x0000000189B7B580
		public static int InitializeNpToolkit2Friend() => default; // 0x0000000183BABC50-0x0000000183BABCF0
		// [XID] // 0x0000000189B82EC0-0x0000000189B82EE0
		public static int TerminateNpToolkit2Friend() => default; // 0x0000000183BAC340-0x0000000183BAC3E0
		// [XID] // 0x0000000189B8A480-0x0000000189B8A4A0
		public static int RequestGetFriends() => default; // 0x0000000183BABF70-0x0000000183BAC010
		// [XID] // 0x0000000189B91AA0-0x0000000189B91AC0
		public static int GetNumOfFriends() => default; // 0x0000000183BAB7A0-0x0000000183BAB840
		// [XID] // 0x0000000189B98EE0-0x0000000189B98F00
		public static bool GetFriendReadyState() => default; // 0x0000000183BAB5C0-0x0000000183BAB660
		// [XID] // 0x0000000189BA02A0-0x0000000189BA02C0
		public static int SetFriendReadyState(bool state) => default; // 0x0000000183BAC200-0x0000000183BAC2A0
		// [XID] // 0x0000000189BA7AC0-0x0000000189BA7AE0
		public static string GetFriendByIndex(int index) => default; // 0x0000000183BAB4F0-0x0000000183BAB5C0
		// [XID] // 0x0000000189BAEE70-0x0000000189BAEE90
		public static ulong GetFriendAccountIDByIndex(int index) => default; // 0x0000000183BAB450-0x0000000183BAB4F0
		// [XID] // 0x0000000189BB6520-0x0000000189BB6540
		public static int RequestGetBlockedUsers() => default; // 0x0000000183BABED0-0x0000000183BABF70
		// [XID] // 0x0000000189BBDBA0-0x0000000189BBDBC0
		public static int GetNumOfBlockedUsers() => default; // 0x0000000183BAB700-0x0000000183BAB7A0
		// [XID] // 0x0000000189BC58A0-0x0000000189BC58C0
		public static bool GetBlockedUserReadyState() => default; // 0x0000000183BAB3B0-0x0000000183BAB450
		// [XID] // 0x0000000189BCD340-0x0000000189BCD360
		public static int SetBlockedUserReadyState(bool state) => default; // 0x0000000183BAC010-0x0000000183BAC0B0
		// [XID] // 0x0000000189BD4800-0x0000000189BD4820
		public static string GetBlockedUserByIndex(int index) => default; // 0x0000000183BAB2E0-0x0000000183BAB3B0
		// [XID] // 0x0000000189BDC370-0x0000000189BDC390
		public static ulong GetBlockedUserAccountIDByIndex(int index) => default; // 0x0000000183BAB240-0x0000000183BAB2E0
		// [XID] // 0x00000001895E8BD0-0x00000001895E8BF0
		public static string TestPS4GetRandomString() => default; // 0x0000000183BAC480-0x0000000183BAC550
		// [XID] // 0x00000001895F0460-0x00000001895F0480
		public static int CreateSession(string sessionImagePath) => default; // 0x0000000183BAB1A0-0x0000000183BAB240
		// [XID] // 0x00000001895F7EB0-0x00000001895F7ED0
		public static int CheckJoinSessionEvent() => default; // 0x0000000183BAAF20-0x0000000183BAAFC0
		// [XID] // 0x00000001895FF270-0x00000001895FF290
		public static string GetSessionOnlineID() => default; // 0x0000000183BAB9A0-0x0000000183BABA70
		// [XID] // 0x0000000189606AF0-0x0000000189606B10
		public static int ClearSessionOnlineID() => default; // 0x0000000183BAB100-0x0000000183BAB1A0
		// [XID] // 0x000000018960E470-0x000000018960E490
		public static ulong GetSessionAccountID() => default; // 0x0000000183BAB900-0x0000000183BAB9A0
		// [XID] // 0x0000000189615AE0-0x0000000189615B00
		public static int ClearSessionAccountID() => default; // 0x0000000183BAB060-0x0000000183BAB100
		// [XID] // 0x000000018961D340-0x000000018961D360
		public static int JoinSession() => default; // 0x0000000183BABD90-0x0000000183BABE30
		// [XID] // 0x0000000189624790-0x00000001896247B0
		public static bool HasJoinSessionOnlineID() => default; // 0x0000000183BABB10-0x0000000183BABBB0
		// [XID] // 0x000000018962BF10-0x000000018962BF30
		public static bool HasJoinSessionAccountID() => default; // 0x0000000183BABA70-0x0000000183BABB10
	}
}
