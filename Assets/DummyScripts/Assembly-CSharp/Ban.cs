/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class Ban // TypeDefIndex: 20741
{
	// Fields
	private static Dictionary<int, List<int>> _banGroupDic; // 0x00
	private static Dictionary<int, string> _banMsgIdDic; // 0x08
	private static BanManager _banMgr; // 0x10

	// Constructors
	static Ban() {} // 0x0000000184838190-0x00000001848384E0

	// Methods
	// [XID] // 0x000000018993B330-0x000000018993B350
	private static List<int> GetGroupByGroupType(BanGroupType groupType) => default; // 0x00000001848377F0-0x0000000184837930
	// [XID] // 0x0000000189942460-0x0000000189942480
	public static void Init() {} // 0x0000000184837C70-0x0000000184837D60
	// [XID] // 0x0000000189949D80-0x0000000189949DA0
	public static void Destroy() {} // 0x0000000184837930-0x0000000184837A00
	// [XID] // 0x0000000189951960-0x0000000189951980
	public static void BanByType(uint questId, BanType banType) {} // 0x0000000184837A00-0x0000000184837AF0
	// [XID] // 0x0000000189958E70-0x0000000189958E90
	public static void FreeByType(uint questId, BanType banType) {} // 0x0000000184837D60-0x0000000184837E50
	// [XID] // 0x0000000189960540-0x0000000189960560
	public static void BanByGroupType(uint questId, BanGroupType groupType) {} // 0x0000000184838010-0x0000000184838190
	// [XID] // 0x0000000189967F00-0x0000000189967F20
	public static void FreeByGroupType(uint questId, BanGroupType groupType) {} // 0x0000000184837AF0-0x0000000184837C70
	// [XID] // 0x00000001896ACBE0-0x00000001896ACC00
	public static bool IsBan(BanType type, bool showMessage = true /* Metadata: 0x00AFE227 */) => default; // 0x0000000184837E50-0x0000000184838010
}

