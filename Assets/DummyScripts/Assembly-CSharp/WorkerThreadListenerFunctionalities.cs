/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorkerThreadListenerFunctionalities : WorkerThreadFunctionalities<SharedListenerFunctionalities> // TypeDefIndex: 11325
{
	// Fields
	private readonly HashSet<SyncId> _firstPersonEmitters; // 0x20
	private readonly HashSet<SyncId> _thirdPersonEmitters; // 0x28
	private SyncId _guiListenerId; // 0x30
	private SyncId _firstPersonListenerId; // 0x48
	private SyncId _thirdPersonListenerId; // 0x60
	private SyncId _defaultListenerId; // 0x78
	private Vector3 _listenerPosition; // 0x90

	// Properties
	public Vector3 listenerPosition { /* [XID] */ /* 0x00000001895E69D0-0x00000001895E69F0 */ get => default; } // 0x000000018244AE20-0x000000018244AF00 

	// Constructors
	public WorkerThreadListenerFunctionalities() {} // Dummy constructor
	public WorkerThreadListenerFunctionalities(WorkerThreadContext context, SharedListenerFunctionalities shared) {} // 0x000000018244C4B0-0x000000018244C630

	// Methods
	// [XID] // 0x00000001895EE530-0x00000001895EE550
	public override void Init() {} // 0x000000018244B3B0-0x000000018244B450
	// [XID] // 0x00000001895F5C90-0x00000001895F5CB0
	public override void Tick(TimeSpan deltaTime) {} // 0x000000018244B450-0x000000018244B530
	// [XID] // 0x00000001895FD1F0-0x00000001895FD210
	public override void Destroy() {} // 0x000000018244ACB0-0x000000018244AD50
	// [XID] // 0x000000018961FE10-0x000000018961FE30
	public void SetGuiListenerId(SyncId syncId) {} // 0x000000018244C220-0x000000018244C2F0
	// [XID] // 0x000000018960C400-0x000000018960C420
	public void ClearGuiListenerId() {} // 0x000000018244ABD0-0x000000018244ACB0
	// [XID] // 0x0000000189613A00-0x0000000189613A20
	public void SetInLevelListenerIds(SyncId firstPersonListenerId, SyncId thirdPersonListenerId, SyncId defaultListenerId) {} // 0x000000018244B050-0x000000018244B1B0
	// [XID] // 0x0000000189603660-0x0000000189603680
	public void ClearInLevelListenerIds() {} // 0x000000018244B530-0x000000018244B650
	// [XID] // 0x00000001899587C0-0x00000001899587E0
	public void ClearKnownEmitters() {} // 0x000000018244AD50-0x000000018244AE20
	// [XID] // 0x00000001899781E0-0x0000000189978200
	public void SetToUseGuiListener(SyncId emitterId) {} // 0x000000018244AF00-0x000000018244B050
	// [XID] // 0x00000001899FF0B0-0x00000001899FF0D0
	public void SetToUseFirstPersonListener(SyncId emitterId) {} // 0x000000018244C2F0-0x000000018244C4B0
	// [XID] // 0x0000000189639360-0x0000000189639380
	public void SetToUseThirdPersonListener(SyncId emitterId) {} // 0x000000018244BA40-0x000000018244BC00
	// [XID] // 0x00000001899A0D90-0x00000001899A0DB0
	public void ResetToUseDefaultListener(SyncId emitterId) {} // 0x000000018244C080-0x000000018244C220
	// [XID] // 0x00000001896480A0-0x00000001896480C0
	public void RestoreListenerForEmitter(SyncId emitterId) {} // 0x000000018244BC00-0x000000018244BE80
	// [XID] // 0x000000018964F790-0x000000018964F7B0
	public SyncId GetListenerForEmitter(SyncId emitterId) => default; // 0x000000018244BE80-0x000000018244C080
	// [XID] // 0x0000000189657160-0x0000000189657180
	public void SetListenerVolumeOffset(ListenerPersonality personality, float offset) {} // 0x000000018244B1B0-0x000000018244B3B0
	// [XID] // 0x000000018965E850-0x000000018965E870
	public void MarkUpForEarlyBirds(bool firstPerson) {} // 0x000000018244B650-0x000000018244BA40
}

