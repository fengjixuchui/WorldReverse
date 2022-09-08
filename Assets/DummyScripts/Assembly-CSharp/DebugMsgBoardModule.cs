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
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DebugMsgBoardModule : BaseModule // TypeDefIndex: 21464
{
	// Fields
	public static bool open; // 0x00
	private const string BASE_URL = "http://paizicnqa.yuanshen.com:9501/api/v1/"; // Metadata: 0x00AFF849
	public DebugBoardInfo curDebugBoardInfo; // 0x10
	private List<DebugBoardInfo> _boardInfoList; // 0x18
	private Dictionary<uint, List<DebugBlletinInfo>> _cacheBlletinInfos; // 0x20

	// Properties
	public List<DebugBoardInfo> boardInfoList { /* [XID] */ /* 0x0000000189945700-0x0000000189945720 */ get => default; } // 0x0000000181C45ED0-0x0000000181C45F70 

	// Constructors
	public DebugMsgBoardModule() {} // 0x0000000181C47350-0x0000000181C47400
	static DebugMsgBoardModule() {} // 0x0000000181C472F0-0x0000000181C47350

	// Methods
	// [XID] // 0x000000018994CB90-0x000000018994CBB0
	public override void ClearOnLevelDestroy() {} // 0x0000000181C45F70-0x0000000181C46040
	// [XID] // 0x0000000189954290-0x00000001899542B0
	public override void ClearOnDisconnect() {} // 0x0000000181C470C0-0x0000000181C47170
	// [XID] // 0x000000018995BC00-0x000000018995BC20
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181C47200-0x0000000181C472F0
	// [XID] // 0x0000000189963780-0x00000001899637A0
	public void AddBoard(DebugBoardInfo info, Action<DebugBoardInfo> onAddBoardEnd, Action onAddBoardFailed) {} // 0x0000000181C46700-0x0000000181C46A70
	// [XID] // 0x000000018996AB80-0x000000018996ABA0
	public void AddBulletin(uint id, DebugBlletinInfo info, Action<List<DebugBlletinInfo>> onAddBulletinEnd, Action onAddBulletinFailed) {} // 0x0000000181C46A70-0x0000000181C46D60
	// [XID] // 0x00000001899727F0-0x0000000189972810
	public void GetBoard(uint sence_id) {} // 0x0000000181C46D60-0x0000000181C46FF0
	// [IDTag] // 0x0000000189979FB0-0x0000000189979FF0
	// [XID] // 0x0000000189979FB0-0x0000000189979FF0
	private bool ListFromJson(JSONNode node, out List<DebugBoardInfo> list) {
		list = default;
		return default;
	} // 0x0000000181C46540-0x0000000181C46700
	// [IDTag] // 0x00000001899843F0-0x0000000189984430
	// [XID] // 0x00000001899843F0-0x0000000189984430
	private bool ListFromJson(JSONNode node, out List<DebugBlletinInfo> list) {
		list = default;
		return default;
	} // 0x0000000181C46380-0x0000000181C46540
	// [XID] // 0x000000018998F000-0x000000018998F020
	public void GetBulletin(uint board_id, Action<List<DebugBlletinInfo>> onGetBulletinEnd) {} // 0x0000000181C46040-0x0000000181C46300
	// [XID] // 0x0000000189996A80-0x0000000189996AA0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181C46FF0-0x0000000181C470C0
}

