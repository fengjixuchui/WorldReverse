/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Room // TypeDefIndex: 11411
{
	// Fields
	public static ulong INVALID_ROOM_ID; // 0x00
	public static uint OUTDOOR_NAME_ID; // 0x08
	public SyncId syncId; // 0x10
	public uint nameId; // 0x28

	// Properties
	public Vector3 position { get; set; } // 0x0000000182182FC0-0x0000000182183030 0x0000000182182E70-0x0000000182182EE0
	public AAB3 boundBox { /* [XID] */ /* 0x00000001897CCE60-0x00000001897CCEA0 */ get; set; } // 0x0000000182182F50-0x0000000182182FC0 0x0000000182183090-0x0000000182183100
	public Vector3 up { /* [XID] */ /* 0x00000001897DEBA0-0x00000001897DEBE0 */ get; set; } // 0x00000001821826B0-0x0000000182182720 0x0000000182182CB0-0x0000000182182D20
	public Vector3 front { /* [XID] */ /* 0x00000001897F11A0-0x00000001897F11E0 */ get; set; } // 0x0000000182182640-0x00000001821826B0 0x00000001821825D0-0x0000000182182640
	public uint reverbAuxBus { /* [XID] */ /* 0x00000001898031D0-0x0000000189803210 */ get; set; } // 0x0000000182182B80-0x0000000182182BE0 0x0000000182182A40-0x0000000182182AA0
	public float reverbLevel { /* [XID] */ /* 0x0000000189814B90-0x0000000189814BD0 */ get; set; } // 0x0000000182182500-0x0000000182182570 0x0000000182182AA0-0x0000000182182B10
	public float wallOcclusion { /* [XID] */ /* 0x0000000189826CB0-0x0000000189826CF0 */ get; set; } // 0x0000000182182C40-0x0000000182182CB0 0x0000000182182EE0-0x0000000182182F50
	public float auxSendLevelToSelf { /* [XID] */ /* 0x0000000189838980-0x00000001898389C0 */ get; set; } // 0x0000000182182420-0x0000000182182490 0x0000000182183100-0x0000000182183170
	public bool keepRegistered { /* [XID] */ /* 0x000000018984A3B0-0x000000018984A3F0 */ get; set; } // 0x0000000182183170-0x00000001821831D0 0x0000000182181D90-0x0000000182181DF0
	public string name { /* [XID] */ /* 0x000000018985BEC0-0x000000018985BF00 */ get; set; } // 0x00000001821831D0-0x0000000182183230 0x0000000182182E00-0x0000000182182E70
	public int priority { /* [XID] */ /* 0x000000018986D5F0-0x000000018986D630 */ get; set; } // 0x0000000182183030-0x0000000182183090 0x0000000182182B10-0x0000000182182B80
	public bool isMajorRoom { /* [XID] */ /* 0x000000018987F470-0x000000018987F4B0 */ get; set; } // 0x0000000182182570-0x00000001821825D0 0x0000000182182D90-0x0000000182182E00
	public List<RoomTrigger> triggers { /* [XID] */ /* 0x0000000189890C40-0x0000000189890C80 */ get; private set; } // 0x0000000182182BE0-0x0000000182182C40 0x0000000182182D20-0x0000000182182D90

	// Constructors
	public Room() {} // Dummy constructor
	public Room(SyncId syncId, uint nameId, RoomParams roomParams) {} // 0x0000000182183430-0x0000000182183830
	static Room() {} // 0x0000000182183380-0x0000000182183430

	// Methods
	// [XID] // 0x0000000189BC9B40-0x0000000189BC9B60
	public bool SampleAt(Vector3 position, out RoomTrigger value) {
		value = default;
		return default;
	} // 0x0000000182182720-0x0000000182182A40
	// [XID] // 0x0000000189682DD0-0x0000000189682DF0
	public override string ToString() => default; // 0x0000000182183230-0x0000000182183380
	// [XID] // 0x0000000189718C50-0x0000000189718C70
	public MmoronRoomParams GetWwiseRoomParams() => default; // 0x0000000182181DF0-0x0000000182182420
}

