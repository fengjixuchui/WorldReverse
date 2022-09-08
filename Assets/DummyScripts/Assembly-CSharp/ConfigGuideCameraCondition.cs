/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class ConfigGuideCameraCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18234
{
	// Fields
	private GuideCameraAction _action; // 0x20
	private SimpleSafeFloat paramRawNum; // 0x24
	private Vector3 _forward; // 0x28

	// Properties
	public GuideCameraAction action { /* [XID] */ /* 0x0000000189872A90-0x0000000189872AB0 */ get => default; /* [XID] */ /* 0x000000018987A710-0x000000018987A730 */ private set {} } // 0x0000000184969920-0x00000001849699C0 0x000000018496A2B0-0x000000018496A360
	public float param { /* [XID] */ /* 0x00000001898818E0-0x0000000189881900 */ get => default; /* [XID] */ /* 0x0000000189888EE0-0x0000000189888F00 */ private set {} } // 0x000000018496B770-0x000000018496B850 0x000000018496B690-0x000000018496B770

	// Constructors
	public ConfigGuideCameraCondition() {} // 0x000000018496B8F0-0x000000018496B990

	// Methods
	// [XID] // 0x0000000189890200-0x0000000189890220
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018496B580-0x000000018496B690
	// [XID] // 0x0000000189897800-0x0000000189897820
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018496B1C0-0x000000018496B270
	// [XID] // 0x000000018989ECC0-0x000000018989ECE0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF911B */) => default; // 0x000000018496ADF0-0x000000018496AEE0
	// [XID] // 0x00000001898A6740-0x00000001898A6760
	public override int GetHashNum() => default; // 0x0000000184969710-0x00000001849697E0
	// [XID] // 0x00000001898ADE70-0x00000001898ADE90
	public override void InitEmpty() {} // 0x000000018496A850-0x000000018496A920
	[BlackList] // 0x00000001898B52D0-0x00000001898B5310
	// [XID] // 0x00000001898B52D0-0x00000001898B5310
	public override bool FromJson(JSONNode node) => default; // 0x0000000184969F30-0x000000018496A2B0
	// [XID] // 0x00000001898BFC60-0x00000001898BFC80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184968E30-0x0000000184969190
	[BlackList] // 0x00000001898C7540-0x00000001898C7580
	// [XID] // 0x00000001898C7540-0x00000001898C7580
	public static new ConfigGuideCameraCondition ParseFromJson(JSONNode node) => default; // 0x000000018496AF40-0x000000018496B160
	// [XID] // 0x00000001898D1C90-0x00000001898D1CB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF911C */, bool useObjectPool = false /* Metadata: 0x00AF9120 */) => default; // 0x000000018496AAF0-0x000000018496ADF0
	// [XID] // 0x00000001898D9530-0x00000001898D9550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9121 */, bool useObjectPool = false /* Metadata: 0x00AF9125 */) => default; // 0x0000000184969A40-0x0000000184969D20
	// [XID] // 0x00000001898E11E0-0x00000001898E1200
	public static new ConfigGuideCameraCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9126 */, bool useObjectPool = false /* Metadata: 0x00AF912A */) => default; // 0x000000018496A360-0x000000018496A550
	[BlackList] // 0x00000001898E8BA0-0x00000001898E8BE0
	// [XID] // 0x00000001898E8BA0-0x00000001898E8BE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184969190-0x0000000184969460
	// [XID] // 0x00000001898F33A0-0x00000001898F33C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018496B2F0-0x000000018496B580
	[BlackList] // 0x00000001898FA9A0-0x00000001898FA9E0
	// [XID] // 0x00000001898FA9A0-0x00000001898FA9E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018496AA00-0x000000018496AAF0
	// [XID] // 0x0000000189905460-0x0000000189905480
	private void HandleCameraData(CameraEntity cameraEntity) {} // 0x00000001849697E0-0x00000001849698C0
	// [XID] // 0x000000018990CD30-0x000000018990CD50
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000184969E20-0x0000000184969F30
	// [XID] // 0x00000001899144E0-0x0000000189914500
	public override bool Ready(object body = null) => default; // 0x000000018496A5C0-0x000000018496A7D0
	[BlackList] // 0x000000018991C060-0x000000018991C0A0
	// [XID] // 0x000000018991C060-0x000000018991C0A0
	public override void AutoAllocTypeFields() {} // 0x0000000184969460-0x0000000184969500
	[BlackList] // 0x0000000189926780-0x00000001899267C0
	// [XID] // 0x0000000189926780-0x00000001899267C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184969500-0x00000001849695F0
	[BlackList] // 0x0000000189930E40-0x0000000189930E80
	// [XID] // 0x0000000189930E40-0x0000000189930E80
	public override void ReturnToObjectPool() {} // 0x000000018496B850-0x000000018496B8F0
}

