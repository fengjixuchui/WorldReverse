/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Dest.Math;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct RoomParams // TypeDefIndex: 11412
{
	// Fields
	public static readonly RoomParams defaultRoomParams; // 0x00
	public Vector3 position; // 0x00
	public AAB3 boundBox; // 0x0C
	public Vector3 up; // 0x24
	public Vector3 front; // 0x30
	public uint reverbAuxBus; // 0x3C
	public float reverbLevel; // 0x40
	public float wallOcclusion; // 0x44
	public float auxSendLevelToSelf; // 0x48
	public bool keepRegistered; // 0x4C
	public string name; // 0x50
	public int priority; // 0x58
	public bool isMajorRoom; // 0x5C

	// Constructors
	static RoomParams() {
		defaultRoomParams = default;
	} // 0x00000001840CD790-0x00000001840CDA50
}

