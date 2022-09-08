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
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelTransmitAvatarPlugin : BaseComponentPlugin // TypeDefIndex: 12129
{
	// Fields
	private float _portalTransmitTime; // 0x58
	private Coroutine _curTransCoroutine; // 0x60
	private Coroutine _curQuitCoroutine; // 0x68
	private Coroutine _curWaitCoroutine; // 0x70
	private InLevelBaseLoadingDialogContext _progressDialog; // 0x78
	private Vector3 _curTransTargetPos; // 0x80
	private float _curTransYaw; // 0x8C
	private EvtTransmitAvatar.TransmitType _curTransType; // 0x90
	private uint _token; // 0x94
	private const uint QUICK_TRANSPORT_REMINDER = 1109002; // Metadata: 0x00AEB53D

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189722DB0-0x0000000189722DD0 */ get => default; } // 0x0000000183C2B210-0x0000000183C2B2B0 

	// Constructors
	public LevelTransmitAvatarPlugin() {} // 0x0000000183C2B1A0-0x0000000183C2B210

	// Methods
	// [XID] // 0x000000018972A3C0-0x000000018972A3E0
	public override void Init() {} // 0x0000000183C29FA0-0x0000000183C2A0B0
	// [XID] // 0x0000000189731C60-0x0000000189731C80
	private bool UseNewTrans() => default; // 0x0000000183C28F30-0x0000000183C29010
	// [XID] // 0x00000001897391E0-0x0000000189739200
	public override void Destroy() {} // 0x0000000183C295F0-0x0000000183C296B0
	// [XID] // 0x0000000189740FA0-0x0000000189740FC0
	public void ClearCurLoad() {} // 0x0000000183C28BF0-0x0000000183C28DB0
	// [XID] // 0x00000001897487D0-0x00000001897487F0
	public void ClearCurQuitLoad() {} // 0x0000000183C2A6C0-0x0000000183C2A7F0
	// [XID] // 0x000000018974FD70-0x000000018974FD90
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183C29AF0-0x0000000183C29BD0
	// [XID] // 0x0000000189757440-0x0000000189757460
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000183C2B050-0x0000000183C2B1A0
	// [XID] // 0x000000018975EB90-0x000000018975EBB0
	private void RefreshEntities() {} // 0x0000000183C296B0-0x0000000183C29890
	// [XID] // 0x0000000189766070-0x0000000189766090
	private void PlayerTransport(Vector3 targetPos, float yaw, EvtTransmitAvatar.TransmitType transType, EnterType enterType, uint token) {} // 0x0000000183C2A8A0-0x0000000183C2AEE0
	// [XID] // 0x000000018976D8C0-0x000000018976D8E0
	private void PerformFinishCB() {} // 0x0000000183C29010-0x0000000183C29300
	// [XID] // 0x0000000189774CA0-0x0000000189774CC0
	private void LoadFinishCB() {} // 0x0000000183C2A1C0-0x0000000183C2A270
	// [XID] // 0x000000018977C580-0x000000018977C5A0
	private void ProgressFinishCB() {} // 0x0000000183C2A110-0x0000000183C2A1C0
	// [XID] // 0x0000000189784080-0x00000001897840A0
	private void TransClearCB() {} // 0x0000000183C2A7F0-0x0000000183C2A8A0
	// [XID] // 0x000000018978B7F0-0x000000018978B810
	public void CheckTransFinishCB() {} // 0x0000000183C29300-0x0000000183C295F0
	// [XID] // 0x0000000189792BF0-0x0000000189792C10
	private void ClearInLevelMainPage() {} // 0x0000000183C29A00-0x0000000183C29AF0
	// [XID] // 0x000000018979A2C0-0x000000018979A2E0
	private void FireTransmitEvent(int phase) {} // 0x0000000183C29890-0x0000000183C29A00
	[DebuggerHidden] // 0x00000001897A2260-0x00000001897A22A0
	// [XID] // 0x00000001897A2260-0x00000001897A22A0
	private IEnumerator InterPlayerTransport(Vector3 pos, float yaw, EvtTransmitAvatar.TransmitType type) => default; // 0x0000000183C2AEE0-0x0000000183C2B050
	// [XID] // 0x00000001897ACA00-0x00000001897ACA20
	private void LoadingLevelProgress(SECTR_Manager.ProgressType loadType, float loadProgress) {} // 0x0000000183C29D30-0x0000000183C29FA0
	// [XID] // 0x00000001897B4760-0x00000001897B4780
	private void OnLoadFinish(EvtTransmitAvatar.TransmitType type) {} // 0x0000000183C2A270-0x0000000183C2A5D0
	[DebuggerHidden] // 0x00000001897BC6D0-0x00000001897BC710
	// [XID] // 0x00000001897BC6D0-0x00000001897BC710
	private IEnumerator PlayerTransmitQuick(Vector3 pos, float yaw) => default; // 0x0000000183C29BD0-0x0000000183C29D30
	// [XID] // 0x00000001897C6FD0-0x00000001897C6FF0
	private void PlayerTransmitDirectly() {} // 0x0000000183C28DB0-0x0000000183C28F30
}

