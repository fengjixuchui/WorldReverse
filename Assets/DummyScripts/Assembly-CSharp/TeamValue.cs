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

public class TeamValue // TypeDefIndex: 21011
{
	// Fields
	public bool isRageGrowing; // 0x10
	public float rage; // 0x14
	public float maxRage; // 0x18
	public float rageThreshold; // 0x1C
	public float rageAddRatio; // 0x20
	public float rageDamgRatio; // 0x24
	public List<uint> rageAvatarList; // 0x28

	// Constructors
	public TeamValue() {} // 0x0000000181DF0340-0x0000000181DF03F0

	// Methods
	// [XID] // 0x000000018976E140-0x000000018976E160
	public void InitRage(uint entityId, float rageThreshold, float maxRage, float rageAddRatio, float rageDamgRatio) {} // 0x0000000181DEFD40-0x0000000181DEFEB0
	// [XID] // 0x0000000189775980-0x00000001897759A0
	public void RemoveRage(uint entityId) {} // 0x0000000181DEFF80-0x0000000181DF0070
	// [XID] // 0x000000018977D200-0x000000018977D220
	public void AddRage(float damage) {} // 0x0000000181DEFC80-0x0000000181DEFD40
	// [XID] // 0x0000000189784C80-0x0000000189784CA0
	public void DamgRage(float deltaTime) {} // 0x0000000181DEFEB0-0x0000000181DEFF80
	// [XID] // 0x000000018978C170-0x000000018978C190
	private void UpdateRage(float value) {} // 0x0000000181DF0070-0x0000000181DF0340
}

