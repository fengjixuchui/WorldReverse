/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Sony.PS4.Dialog
{
	public class Common // TypeDefIndex: 9727
	{
		// Properties
		public static bool IsDialogOpen { /* [XID] */ /* 0x00000001898C1F10-0x00000001898C1F30 */ get => default; } // 0x0000000186739AA0-0x0000000186739B40 
		public static bool IsErrorDialogOpen { /* [XID] */ /* 0x00000001898C9870-0x00000001898C9890 */ get => default; } // 0x0000000186739B40-0x0000000186739BE0 
	
		// Events
		public static event Messages.EventHandler OnGotDialogResult;
	
		// Nested types
		public enum SystemMessageType // TypeDefIndex: 9728
		{
			TRC_EMPTY_STORE = 0,
			TRC_PSN_CHAT_RESTRICTION = 1,
			TRC_PSN_UGC_RESTRICTION = 2,
			WARNING_SWITCH_TO_SIMULVIEW = 3,
			CAMERA_NOT_CONNECTED = 4,
			WARNING_PROFILE_PICTURE_AND_NAME_NOT_SHARED = 5
		}
	
		public enum UserMessageType // TypeDefIndex: 9729
		{
			OK = 0,
			YESNO = 1,
			NONE = 2,
			OK_CANCEL = 3,
			CANCEL = 4
		}
	
		public enum CommonDialogResult // TypeDefIndex: 9730
		{
			RESULT_BUTTON_NOT_SET = 0,
			RESULT_BUTTON_OK = 1,
			RESULT_BUTTON_CANCEL = 2,
			RESULT_BUTTON_YES = 3,
			RESULT_BUTTON_NO = 4,
			RESULT_BUTTON_1 = 5,
			RESULT_BUTTON_2 = 6,
			RESULT_BUTTON_3 = 7,
			RESULT_CANCELED = 8,
			RESULT_ABORTED = 9,
			RESULT_CLOSED = 10
		}
	
		// Constructors
		public Common() {} // 0x0000000186739920-0x0000000186739980
	
		// Methods
		private static extern int PrxCommonDialogInitialise(); // 0x0000000186738B20-0x0000000186738C00
		private static extern void PrxCommonDialogUpdate(); // 0x00000001867390D0-0x00000001867391B0
		private static extern bool PrxCommonDialogIsDialogOpen(); // 0x0000000186738C00-0x0000000186738CE0
		private static extern bool PrxCommonDialogErrorMessage(uint errorCode); // 0x0000000186738950-0x0000000186738A40
		private static extern bool PrxCommonDialogSystemMessage(SystemMessageType type, int userId); // 0x0000000186738FD0-0x00000001867390D0
		private static extern bool PrxCommonDialogClose(); // 0x0000000186738870-0x0000000186738950
		private static extern bool PrxErrorDialogIsDialogOpen(); // 0x0000000186739340-0x0000000186739420
		private static extern bool PrxCommonDialogProgressBar(string str); // 0x0000000186738ED0-0x0000000186738FD0
		private static extern bool PrxCommonDialogProgressBarSetPercent(int percent); // 0x0000000186738DE0-0x0000000186738ED0
		private static extern bool PrxCommonDialogProgressBarSetMessage(string str); // 0x0000000186738CE0-0x0000000186738DE0
		private static extern bool PrxCommonDialogUserMessage(UserMessageType type, bool infobar, string str, string button1, string button2, string button3); // 0x00000001867391B0-0x0000000186739340
		private static extern CommonDialogResult PrxCommonDialogGetResult(); // 0x0000000186738A40-0x0000000186738B20
		// [XID] // 0x00000001898D1040-0x00000001898D1060
		public static bool ShowErrorMessage(uint errorCode) => default; // 0x0000000186739570-0x0000000186739610
		// [XID] // 0x00000001898D86E0-0x00000001898D8700
		public static bool ShowSystemMessage(SystemMessageType type, int userId) => default; // 0x00000001867396C0-0x0000000186739780
		// [XID] // 0x00000001899FA790-0x00000001899FA7B0
		public static bool ShowProgressBar(string message) => default; // 0x0000000186739610-0x00000001867396C0
		// [XID] // 0x00000001898E8020-0x00000001898E8040
		public static bool SetProgressBarPercent(int percent) => default; // 0x00000001867394D0-0x0000000186739570
		// [XID] // 0x00000001898EF750-0x00000001898EF770
		public static bool SetProgressBarMessage(string message) => default; // 0x0000000186739420-0x00000001867394D0
		// [XID] // 0x0000000189A5F9F0-0x0000000189A5FA10
		public static bool ShowUserMessage(UserMessageType type, bool infoBar, string str) => default; // 0x0000000186739780-0x0000000186739880
		// [XID] // 0x0000000189A67310-0x0000000189A67330
		public static bool Close() => default; // 0x00000001867385B0-0x0000000186738650
		// [XID] // 0x0000000189A761D0-0x0000000189A761F0
		public static CommonDialogResult GetResult() => default; // 0x0000000186738650-0x00000001867386F0
		// [XID] // 0x0000000189A7DBC0-0x0000000189A7DBE0
		public static void ProcessMessage(Messages.PluginMessage msg) {} // 0x0000000186738790-0x0000000186738870
		// [XID] // 0x0000000189A6E960-0x0000000189A6E980
		public static void Initialise() {} // 0x00000001867386F0-0x0000000186738790
		// [XID] // 0x0000000189A85470-0x0000000189A85490
		public static void Update() {} // 0x0000000186739880-0x0000000186739920
	}
}
