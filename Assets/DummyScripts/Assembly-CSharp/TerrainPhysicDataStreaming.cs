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

public class TerrainPhysicDataStreaming // TypeDefIndex: 31941
{
	// Fields
	private static TerrainPhysicDataStreaming msInstance; // 0x00
	private Vector3 _oldPosition; // 0x10
	private float _recheckDistance; // 0x1C
	private readonly List<WeakReference> _terrains; // 0x20

	// Properties
	public static TerrainPhysicDataStreaming Instance { /* [XID] */ /* 0x000000018970FF90-0x000000018970FFB0 */ get => default; } // 0x0000000183517480-0x0000000183517550 

	// Constructors
	private TerrainPhysicDataStreaming() {} // 0x0000000183517BA0-0x0000000183517C70
	static TerrainPhysicDataStreaming() {} // 0x0000000183517B20-0x0000000183517BA0

	// Methods
	// [XID] // 0x00000001897172E0-0x0000000189717300
	public void OnTeleport(Vector3 pos) {} // 0x0000000183516E80-0x00000001835170D0
	// [XID] // 0x000000018971ED90-0x000000018971EDB0
	private void CheckCollider(Terrain terrain) {} // 0x0000000183517850-0x0000000183517B20
	// [XID] // 0x0000000189726300-0x0000000189726320
	public void RegistTerrain(Terrain terrain) {} // 0x00000001835170D0-0x0000000183517210
	// [XID] // 0x000000018972D910-0x000000018972D930
	public void UnregistTerrain(Terrain terrain) {} // 0x0000000183517210-0x0000000183517480
	// [XID] // 0x0000000189735090-0x00000001897350B0
	public void UpdatePosition(Vector3 position) {} // 0x0000000183517550-0x0000000183517850
}

