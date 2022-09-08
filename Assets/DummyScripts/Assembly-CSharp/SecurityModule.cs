/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SecurityModule : BaseModule // TypeDefIndex: 21650
{
	// Fields
	private const string KILL_CLIENT_TITLE_TEXT = "TIP_TITLE"; // Metadata: 0x00AFFACE
	private const string KILL_CLIENT_MSG_TEXT = "UI_GAMEDATA_EXCEPTION"; // Metadata: 0x00AFFADB
	private WaitForSeconds _waitForSCSeconds; // 0x10
	private const int S_P = -6; // Metadata: 0x00AFFAF4
	private const string SAFETYPE_ERROR_TAG = "GameAnimData"; // Metadata: 0x00AFFAF8
	private const int SAFETYPE_REPORT_INTERVAL = 100; // Metadata: 0x00AFFB08
	private const int SAFETYPE_REPORT_MIN_COUNT = 1; // Metadata: 0x00AFFB0C
	private int _safeTypeErrorCounter; // 0x1C
	private int _safeTypeReportCounter; // 0x20

	// Properties
	public bool MTPEnabled { get; private set; } // 0x00000001815703C0-0x0000000181570420 0x0000000181571050-0x00000001815710B0

	// Nested types
	public enum SafeTypeErrorType // TypeDefIndex: 21651
	{
		BOOL = 0,
		DOUBLE = 1,
		FLOAT = 2,
		INT32 = 3,
		INT64 = 4,
		UINT32 = 5,
		UINT64 = 6
	}

	// Constructors
	public SecurityModule() {} // 0x00000001815715C0-0x0000000181571680

	// Methods
	// [XID] // 0x0000000189A1CFF0-0x0000000189A1D010
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181570930-0x0000000181570A00
	// [XID] // 0x0000000189A33050-0x0000000189A33070
	public void InitMTP() {} // 0x0000000181570420-0x00000001815704F0
	// [XID] // 0x0000000189A3A960-0x0000000189A3A980
	public void OnPlayerDataNotify(uint regionId, string openId, string nickName) {} // 0x0000000181571390-0x0000000181571460
	// [XID] // 0x0000000189A422D0-0x0000000189A422F0
	public void StartReportCoroutine() {} // 0x00000001815707F0-0x0000000181570890
	// [XID] // 0x0000000189A498E0-0x0000000189A49900
	public void StopReportCoroutine() {} // 0x0000000181571130-0x00000001815711D0
	// [XID] // 0x0000000189A51230-0x0000000189A51250
	public override bool OnPacket(Packet packet) => default; // 0x0000000181570570-0x0000000181570670
	// [XID] // 0x0000000189A58880-0x0000000189A588A0
	public override void ClearOnDisconnect() {} // 0x00000001815712F0-0x0000000181571390
	// [XID] // 0x0000000189A60360-0x0000000189A60380
	public override void ClearOnLevelDestroy() {} // 0x0000000181570890-0x0000000181570930
	// [XID] // 0x0000000189A67EF0-0x0000000189A67F10
	public void OnApplicationPause(bool isPause) {} // 0x0000000181570C10-0x0000000181570CC0
	// [XID] // 0x0000000189A6F280-0x0000000189A6F2A0
	private void RegisterDisconnectHandle() {} // 0x0000000181570AB0-0x0000000181570C10
	// [XID] // 0x0000000189A76AE0-0x0000000189A76B00
	private void OnCheckSegmentCRCNotify(CheckSegmentCRCNotify notify) {} // 0x0000000181571460-0x00000001815715C0
	[DebuggerHidden] // 0x0000000189A7E3E0-0x0000000189A7E420
	// [XID] // 0x0000000189A7E3E0-0x0000000189A7E420
	private IEnumerator ReportCheckSegmentCRCReq(CheckSegmentCRCNotify notify) => default; // 0x00000001815711D0-0x00000001815712F0
	// [XID] // 0x0000000189A88F70-0x0000000189A88F90
	public void ReportSafeTypeValueError(SafeTypeErrorType errorType) {} // 0x0000000181570D60-0x0000000181571050
	// [XID] // 0x0000000189A90790-0x0000000189A907B0
	public void DoString(byte[] luaBytes) {} // 0x0000000181570A00-0x0000000181570AB0
}

