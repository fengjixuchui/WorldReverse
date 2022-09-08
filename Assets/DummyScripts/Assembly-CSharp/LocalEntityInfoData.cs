/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LocalEntityInfoData : ISimplePoolObject, ITickableObject<uint> // TypeDefIndex: 21390
{
	// Fields
	private static SimpleObjectPool<LocalEntityInfoData> _pool; // 0x00
	private uint _entityId; // 0x14

	// Properties
	public uint key { /* [XID] */ /* 0x00000001899B6350-0x00000001899B6370 */ get => default; } // 0x0000000182F434B0-0x0000000182F43550 
	public int index { get; set; } // 0x0000000182F44000-0x0000000182F44060 0x0000000182F44190-0x0000000182F441F0
	public static SimpleObjectPool<LocalEntityInfoData> pool { /* [XID] */ /* 0x0000000189ADB2D0-0x0000000189ADB2F0 */ get => default; } // 0x0000000182F44450-0x0000000182F44590 
	public ActorType actorType { get; /* [XID] */ /* 0x00000001899F2330-0x00000001899F2370 */ private set; } // 0x0000000182F44710-0x0000000182F44770 0x0000000182F446B0-0x0000000182F44710
	public string alias { /* [XID] */ /* 0x00000001899FC900-0x00000001899FC940 */ get; /* [XID] */ /* 0x0000000189A06F20-0x0000000189A06F60 */ private set; } // 0x0000000182F43A30-0x0000000182F43A90 0x0000000182F442B0-0x0000000182F44310
	public string metaPath { /* [XID] */ /* 0x0000000189A115E0-0x0000000189A11620 */ get; /* [XID] */ /* 0x0000000189A1B730-0x0000000189A1B770 */ private set; } // 0x0000000182F433F0-0x0000000182F43450 0x0000000182F445F0-0x0000000182F44650
	public uint configId { /* [XID] */ /* 0x0000000189A25E50-0x0000000189A25E90 */ get; /* [XID] */ /* 0x0000000189A30250-0x0000000189A30290 */ private set; } // 0x0000000182F43FA0-0x0000000182F44000 0x0000000182F44650-0x0000000182F446B0
	public Vector3 initPos { /* [XID] */ /* 0x0000000189A3AA00-0x0000000189A3AA40 */ get; /* [XID] */ /* 0x0000000189A45290-0x0000000189A452D0 */ private set; } // 0x0000000182F43A90-0x0000000182F43B00 0x0000000182F43EC0-0x0000000182F43F30
	public Vector3 initEuler { /* [XID] */ /* 0x0000000189A4F9E0-0x0000000189A4FA20 */ get; /* [XID] */ /* 0x0000000189A5A200-0x0000000189A5A240 */ private set; } // 0x0000000182F43F30-0x0000000182F43FA0 0x0000000182F44060-0x0000000182F440D0
	public uint sceneId { /* [XID] */ /* 0x0000000189A64BA0-0x0000000189A64BE0 */ get; /* [XID] */ /* 0x0000000189A6F2E0-0x0000000189A6F320 */ private set; } // 0x0000000182F44130-0x0000000182F44190 0x0000000182F44590-0x0000000182F445F0
	public uint roomId { /* [XID] */ /* 0x0000000189A7A130-0x0000000189A7A170 */ get; /* [XID] */ /* 0x0000000189A84660-0x0000000189A846A0 */ private set; } // 0x0000000182F440D0-0x0000000182F44130 0x0000000182F43450-0x0000000182F434B0
	public uint questId { /* [XID] */ /* 0x0000000189A8F010-0x0000000189A8F050 */ get; private set; } // 0x0000000182F43550-0x0000000182F435B0 0x0000000182F43D90-0x0000000182F43DF0
	public uint level { get; /* [XID] */ /* 0x0000000189AA8000-0x0000000189AA8040 */ private set; } // 0x0000000182F44250-0x0000000182F442B0 0x0000000182F441F0-0x0000000182F44250
	public uint dropId { get; /* [XID] */ /* 0x0000000189ABA760-0x0000000189ABA7A0 */ private set; } // 0x0000000182F43E60-0x0000000182F43EC0 0x0000000182F443F0-0x0000000182F44450
	public float scale { get; /* [XID] */ /* 0x0000000189ACC660-0x0000000189ACC6A0 */ private set; } // 0x0000000182F43DF0-0x0000000182F43E60 0x0000000182F44770-0x0000000182F447E0

	// Constructors
	public LocalEntityInfoData() {} // 0x0000000182F44BD0-0x0000000182F44C40
	static LocalEntityInfoData() {} // 0x0000000182F44B70-0x0000000182F44BD0

	// Methods
	// [XID] // 0x0000000189AD37F0-0x0000000189AD3810
	public static LocalEntityInfoData Create(uint entityId, ActorType actorType, string alias, string metaPath, uint configId, Vector3 initPos, Vector3 initEuler, uint sceneId, uint roomId, uint dropId, float scale) => default; // 0x0000000182F43B00-0x0000000182F43D90
	// [XID] // 0x00000001899DB9D0-0x00000001899DB9F0
	public static void Release(LocalEntityInfoData infoData) {} // 0x0000000182F44310-0x0000000182F443F0
	// [XID] // 0x0000000189AE2B40-0x0000000189AE2B60
	public void Init(uint entityId, ActorType actorType, string alias, string metaPath, uint configId, Vector3 initPos, Vector3 initEuler, uint sceneId, uint roomId, uint dropId, float scale) {} // 0x0000000182F435B0-0x0000000182F43980
	// [XID] // 0x0000000189AD7400-0x0000000189AD7420
	public void Tick(float deltaTime) {} // 0x0000000182F43980-0x0000000182F43A30
	// [XID] // 0x0000000189ADEEF0-0x0000000189ADEF10
	public void ResetObject() {} // 0x0000000182F447E0-0x0000000182F44B70
}

