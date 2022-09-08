/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PeriodicMultiPositionEvent // TypeDefIndex: 11491
{
	// Fields
	private readonly PeriodicMultiPositionEventSpotCollection _spotCollection; // 0x10
	private uint _startEventId; // 0x18
	private uint _endEventId; // 0x1C
	private uint _postEventId; // 0x20
	private SyncId _syncId; // 0x28
	private AkMultiPositionType _multiPositionType; // 0x40

	// Properties
	public uint startEventId { /* [XID] */ /* 0x00000001897872B0-0x00000001897872D0 */ get => default; } // 0x0000000184BDAEB0-0x0000000184BDAF50 
	public uint endEventId { /* [XID] */ /* 0x000000018962CFB0-0x000000018962CFD0 */ get => default; } // 0x0000000184BDADB0-0x0000000184BDAE50 
	public uint postEventId { /* [XID] */ /* 0x0000000189634B80-0x0000000189634BA0 */ get => default; /* [XID] */ /* 0x00000001897ACE10-0x00000001897ACE30 */ set {} } // 0x0000000184BDA8B0-0x0000000184BDA950 0x0000000184BDA800-0x0000000184BDA8B0
	public SyncId syncId { /* [XID] */ /* 0x0000000189795EF0-0x0000000189795F10 */ get => default; } // 0x0000000184BDAB40-0x0000000184BDAC30 
	public AkMultiPositionType multiPositionType { /* [XID] */ /* 0x000000018964AF40-0x000000018964AF60 */ get => default; } // 0x0000000184BDB0A0-0x0000000184BDB140 
	public int spotCount { /* [XID] */ /* 0x0000000189652700-0x0000000189652720 */ get => default; } // 0x0000000184BDA750-0x0000000184BDA800 
	public bool shouldSetPosition { /* [XID] */ /* 0x0000000189659EB0-0x0000000189659EF0 */ get; /* [XID] */ /* 0x0000000189664710-0x0000000189664750 */ set; } // 0x0000000184BDAC30-0x0000000184BDAC90 0x0000000184BDAE50-0x0000000184BDAEB0

	// Constructors
	public PeriodicMultiPositionEvent() {} // 0x0000000184BDB140-0x0000000184BDB1D0

	// Methods
	// [XID] // 0x000000018966F160-0x000000018966F180
	public void Set(uint startEventId, uint endEventId, SyncId syncId, AkMultiPositionType multiPositionType) {} // 0x0000000184BDAC90-0x0000000184BDADB0
	// [XID] // 0x0000000189676B10-0x0000000189676B30
	public void AddSpot(PeriodicMultiPositionEventSpot spot) {} // 0x0000000184BDAA50-0x0000000184BDAB40
	// [XID] // 0x000000018967E340-0x000000018967E360
	public void RemoveSpot(int id) {} // 0x0000000184BDA690-0x0000000184BDA750
	// [XID] // 0x0000000189685AD0-0x0000000189685AF0
	public AudioPositionArray GetPositionArray(Vector3 listenerPosition) => default; // 0x0000000184BDAF50-0x0000000184BDB0A0
	// [XID] // 0x000000018977CA00-0x000000018977CA20
	public void Clear() {} // 0x0000000184BDA950-0x0000000184BDAA50
}

