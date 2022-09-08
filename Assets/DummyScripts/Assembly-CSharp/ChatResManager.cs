/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatResManager : GlobalManager // TypeDefIndex: 28473
{
	// Fields
	private Dictionary<ChatDataType, string> chatDataTypeResDic; // 0x10
	private Dictionary<ChatDataContentType, string> chatDataContentResDic; // 0x18
	private Dictionary<ChatDataType, uint> chatDataTypeHandler; // 0x20
	private Dictionary<ChatDataContentType, uint> chatDataContentHandler; // 0x28

	// Constructors
	public ChatResManager() {} // 0x0000000184239D50-0x0000000184239EA0

	// Methods
	// [XID] // 0x0000000189A5D150-0x0000000189A5D170
	public override void Init() {} // 0x00000001842394C0-0x0000000184239650
	// [IDTag] // 0x0000000189A649B0-0x0000000189A649F0
	// [XID] // 0x0000000189A649B0-0x0000000189A649F0
	public void Recycle(ChatDataType type, GameObject go) {} // 0x00000001842391A0-0x00000001842392E0
	// [IDTag] // 0x0000000189A6F150-0x0000000189A6F190
	// [XID] // 0x0000000189A6F150-0x0000000189A6F190
	public void Recycle(ChatDataContentType type, GameObject go) {} // 0x00000001842392E0-0x0000000184239420
	// [IDTag] // 0x0000000189A79F20-0x0000000189A79F60
	// [XID] // 0x0000000189A79F20-0x0000000189A79F60
	public GameObject GetRes(ChatDataType type) => default; // 0x0000000184239650-0x0000000184239800
	// [IDTag] // 0x0000000189A84480-0x0000000189A844C0
	// [XID] // 0x0000000189A84480-0x0000000189A844C0
	public GameObject GetRes(ChatDataContentType type) => default; // 0x0000000184239800-0x00000001842399A0
	// [XID] // 0x0000000189A8EE20-0x0000000189A8EE40
	public override void Destroy() {} // 0x0000000184239420-0x00000001842394C0
	// [XID] // 0x0000000189A96470-0x0000000189A96490
	public void DissmissAll() {} // 0x00000001842399A0-0x0000000184239CB0
	// [XID] // 0x0000000189A9D9C0-0x0000000189A9D9E0
	public override void ReloadRes() {} // 0x0000000184239CB0-0x0000000184239D50
	// [XID] // 0x0000000189AA52D0-0x0000000189AA52F0
	public override void ClearOnLevelDestroy() {} // 0x0000000184239100-0x00000001842391A0
}

