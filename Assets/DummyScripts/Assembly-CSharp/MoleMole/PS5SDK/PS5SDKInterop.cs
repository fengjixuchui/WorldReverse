/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.PS5SDK
{
	public static class PS5SDKInterop // TypeDefIndex: 26482
	{
		// Fields
		private const string LIB_NAME = "PS5SDKPlugin"; // Metadata: 0x00B0C3A4
		public const int SCE_SYSTEM_PARAM_ENTER_BUTTON_ASSIGN_CIRCLE = 0; // Metadata: 0x00B0C3B4
		public const int SCE_SYSTEM_PARAM_ENTER_BUTTON_ASSIGN_CROSS = 1; // Metadata: 0x00B0C3B8
		private const int SCE_NP_COUNTRY_CODE_LENGTH = 2; // Metadata: 0x00B0C3BC
		private const int SCE_USER_SERVICE_MAX_USER_NAME_LENGTH = 16; // Metadata: 0x00B0C3C0
		private const int SCE_NP_ONLINEID_MAX_LENGTH = 16; // Metadata: 0x00B0C3C4
		private const int SCE_OK = 0; // Metadata: 0x00B0C3C8
		public const int SCE_MSG_DIALOG_SYSMSG_TYPE_PSN_COMMUNICATION_RESTRICTION = 6; // Metadata: 0x00B0C3CC
		public const int SCE_COMMON_DIALOG_STATUS_NONE = 0; // Metadata: 0x00B0C3D0
		public const int SCE_COMMON_DIALOG_STATUS_INITIALIZED = 1; // Metadata: 0x00B0C3D4
		public const int SCE_COMMON_DIALOG_STATUS_RUNNING = 2; // Metadata: 0x00B0C3D8
		public const int SCE_COMMON_DIALOG_STATUS_FINISHED = 3; // Metadata: 0x00B0C3DC
	
		// Methods
		// [XID] // 0x0000000189668180-0x00000001896681A0
		public static int RequestCommunicationRestrictStatus() => default; // 0x0000000183BAC910-0x0000000183BACA00
		// [XID] // 0x000000018966FC40-0x000000018966FC60
		public static int GetCommunicationRestrictStatus() => default; // 0x0000000183BAC550-0x0000000183BAC640
		// [XID] // 0x00000001896774A0-0x00000001896774C0
		public static int InitSystemMsgDialog() => default; // 0x0000000183BAC730-0x0000000183BAC820
		// [XID] // 0x000000018967EA30-0x000000018967EA50
		public static int ShowSystemMsgDialog(int dialogType) => default; // 0x0000000183BACA00-0x0000000183BACAF0
		// [XID] // 0x00000001896862C0-0x00000001896862E0
		public static int GetMsgDialogStatus() => default; // 0x0000000183BAC640-0x0000000183BAC730
		// [XID] // 0x000000018968E170-0x000000018968E190
		public static int ReleaseSystemMsgDialog() => default; // 0x0000000183BAC820-0x0000000183BAC910
	}
}
