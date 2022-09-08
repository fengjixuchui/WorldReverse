/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class TalkProxy // TypeDefIndex: 21669
{
	// Methods
	// [XID] // 0x00000001896B2C50-0x00000001896B2C70
	public static void ClearNpcTalk() {} // 0x0000000183DF9300-0x0000000183DF93C0
	// [XID] // 0x000000018960AF50-0x000000018960AF70
	public static void SetNpcTalkDirty() {} // 0x0000000183DF9240-0x0000000183DF9300
	// [XID] // 0x0000000189B43CB0-0x0000000189B43CD0
	public static uint GetValidTalkByNpcID(uint npcConfigID, uint questMainId, bool isDiscard) => default; // 0x0000000183DF9140-0x0000000183DF9240
	// [XID] // 0x00000001896C8D00-0x00000001896C8D20
	public static uint GetGadgetValidTalkByMapInstId(uint mapInstId, uint groupId) => default; // 0x0000000183DF93C0-0x0000000183DF94A0
	// [XID] // 0x00000001896D06A0-0x00000001896D06C0
	public static ConfigTalkScheme GetData(uint talkID) => default; // 0x0000000183DF8EE0-0x0000000183DF8FB0
	// [XID] // 0x00000001896D7BB0-0x00000001896D7BD0
	public static ConfigDialogScheme GetDialogData(uint dialogID) => default; // 0x0000000183DF94A0-0x0000000183DF9570
	// [XID] // 0x00000001896DF440-0x00000001896DF460
	public static void LoadDialogAsync(ConfigTalkScheme talkConfig, Action onFinishHandler, uint questMainId) {} // 0x0000000183DF8FB0-0x0000000183DF9140
	// [XID] // 0x0000000189840020-0x0000000189840040
	public static void LoadDialogSync(ConfigTalkScheme talkConfig, Action onFinishHandler, uint questMainId) {} // 0x0000000183DF9570-0x0000000183DF9700
}

