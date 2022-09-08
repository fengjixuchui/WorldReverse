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

public class WTRustler // TypeDefIndex: 11254
{
	// Fields
	private readonly WorkerThreadContext _context; // 0x10
	private readonly PostEventCallback _callback; // 0x18
	private uint _rtpcId; // 0x20
	private uint _eventId; // 0x24
	private uint _playingId; // 0x28
	private bool _pending; // 0x2C
	private SyncId _syncId; // 0x30

	// Constructors
	public WTRustler() {} // Dummy constructor
	public WTRustler(WorkerThreadContext context) {} // 0x00000001841B3490-0x00000001841B3540

	// Methods
	// [XID] // 0x000000018968A7A0-0x000000018968A7C0
	public void Start(uint rtpcId, uint eventId, SyncId syncId) {} // 0x00000001841B2B70-0x00000001841B2CB0
	// [XID] // 0x0000000189BBD620-0x0000000189BBD640
	public void Update(List<Vector3> treePositions) {} // 0x00000001841B3000-0x00000001841B3110
	// [XID] // 0x0000000189B85AC0-0x0000000189B85AE0
	public void Stop() {} // 0x00000001841B2A80-0x00000001841B2B70
	// [XID] // 0x00000001896A0D00-0x00000001896A0D20
	private void UpdateObjectPositions(List<Vector3> treePositions) {} // 0x00000001841B2DB0-0x00000001841B3000
	// [XID] // 0x000000018999C440-0x000000018999C460
	private void SetTreeNumRtpc(float value) {} // 0x00000001841B32C0-0x00000001841B33B0
	// [XID] // 0x00000001896AF620-0x00000001896AF640
	private void PlayEvent() {} // 0x00000001841B3110-0x00000001841B32C0
	// [XID] // 0x00000001896B6D20-0x00000001896B6D40
	private void StopEvent() {} // 0x00000001841B33B0-0x00000001841B3490
	// [XID] // 0x0000000189664A50-0x0000000189664A70
	private void PostEventCallback(uint eventId, SyncId syncId, uint playingId, uint postId) {} // 0x00000001841B2CB0-0x00000001841B2DB0
}

