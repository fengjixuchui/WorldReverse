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

public sealed class H5ActivityModule : BaseModule // TypeDefIndex: 21513
{
	// Fields
	private Dictionary<uint, H5ActivityInfo> _dataDict; // 0x10
	private Dictionary<uint, bool> _showRedPoint; // 0x18
	private List<H5ActivityInfo> _cachedActivityId; // 0x20

	// Constructors
	public H5ActivityModule() {} // 0x0000000182804760-0x0000000182804850

	// Methods
	// [XID] // 0x0000000189B6E080-0x0000000189B6E0A0
	public H5ActivityInfo GetInfo(uint activityId) => default; // 0x0000000182804350-0x0000000182804440
	// [XID] // 0x0000000189B75830-0x0000000189B75850
	public bool ShouldActivityShowRedPoint(uint scheduleId) => default; // 0x0000000182804070-0x0000000182804190
	// [XID] // 0x0000000189B7CCD0-0x0000000189B7CCF0
	public void SetActivityRedpointDone(uint scheduleId) {} // 0x0000000182804440-0x0000000182804570
	// [XID] // 0x0000000189B84B70-0x0000000189B84B90
	public override bool OnPacket(Packet packet) => default; // 0x0000000182803600-0x0000000182803720
	// [XID] // 0x0000000189B8B920-0x0000000189B8B940
	public override void ClearOnBackHome() {} // 0x0000000182803FD0-0x0000000182804070
	// [XID] // 0x0000000189B93110-0x0000000189B93130
	public override void ClearOnDisconnect() {} // 0x0000000182804570-0x0000000182804610
	// [XID] // 0x0000000189B9A660-0x0000000189B9A680
	public override void ClearOnLevelDestroy() {} // 0x0000000182803A60-0x0000000182803B00
	// [XID] // 0x0000000189BA1E50-0x0000000189BA1E70
	public void RequestGetAllH5ActivityInfo() {} // 0x0000000182804190-0x0000000182804270
	// [XID] // 0x0000000189BA9240-0x0000000189BA9260
	private void OnGetAllH5ActivityInfoRsp(GetAllH5ActivityInfoRsp rsp) {} // 0x0000000182803E50-0x0000000182803FD0
	// [XID] // 0x0000000189BB09D0-0x0000000189BB09F0
	private void OnH5ActivityIdsNotify(H5ActivityIdsNotify ntf) {} // 0x00000001828034D0-0x0000000182803580
	// [XID] // 0x0000000189BB7CE0-0x0000000189BB7D00
	private void HandleH5ActivityListInternal(RepeatedMessageField<H5ActivityInfo> list) {} // 0x0000000182803720-0x0000000182803A60
	// [XID] // 0x0000000189BBF3D0-0x0000000189BBF3F0
	private void ClearDataDict() {} // 0x0000000182803BE0-0x0000000182803E50
	// [XID] // 0x0000000189BC6F90-0x0000000189BC6FB0
	private bool ShouldH5ActivityShow(H5ActivityInfo activityInfo) => default; // 0x0000000182804610-0x0000000182804760
	// [XID] // 0x0000000189BCECC0-0x0000000189BCECE0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000182803B00-0x0000000182803BE0
}

