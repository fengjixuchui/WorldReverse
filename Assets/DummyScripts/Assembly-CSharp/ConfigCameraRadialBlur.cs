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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigCameraRadialBlur : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17799
{
	// Fields
	private SimpleSafeFloat powerRawNum; // 0x10
	private SimpleSafeFloat blurTimeRawNum; // 0x14
	private SimpleSafeFloat fadeTimeRawNum; // 0x18

	// Properties
	public float power { /* [XID] */ /* 0x00000001899F4310-0x00000001899F4330 */ get => default; /* [XID] */ /* 0x00000001899FB870-0x00000001899FB890 */ private set {} } // 0x0000000182DE4170-0x0000000182DE4250 0x0000000182DE3490-0x0000000182DE3570
	public float blurTime { /* [XID] */ /* 0x0000000189A02B10-0x0000000189A02B30 */ get => default; /* [XID] */ /* 0x0000000189A0A240-0x0000000189A0A260 */ private set {} } // 0x0000000182DE3DC0-0x0000000182DE3EA0 0x0000000182DE3CE0-0x0000000182DE3DC0
	public float fadeTime { /* [XID] */ /* 0x0000000189A11B60-0x0000000189A11B80 */ get => default; /* [XID] */ /* 0x0000000189A18D90-0x0000000189A18DB0 */ private set {} } // 0x0000000182DE2FA0-0x0000000182DE3080 0x0000000182DE3080-0x0000000182DE3160

	// Constructors
	public ConfigCameraRadialBlur() {} // 0x0000000182DE4550-0x0000000182DE45E0

	// Methods
	// [XID] // 0x0000000189A20490-0x0000000189A204B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182DE4250-0x0000000182DE4370
	// [XID] // 0x0000000189A278C0-0x0000000189A278E0
	public void InitEmpty() {} // 0x0000000182DE38F0-0x0000000182DE39E0
	[BlackList] // 0x0000000189A2F030-0x0000000189A2F070
	// [XID] // 0x0000000189A2F030-0x0000000189A2F070
	public bool FromJson(JSONNode node) => default; // 0x0000000182DE3570-0x0000000182DE38F0
	// [XID] // 0x0000000189A39830-0x0000000189A39850
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182DE26F0-0x0000000182DE2B40
	// [XID] // 0x0000000189A410B0-0x0000000189A410D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C87 */, bool useObjectPool = false /* Metadata: 0x00AF7C8B */) => default; // 0x0000000182DE39E0-0x0000000182DE3CE0
	// [XID] // 0x0000000189A48710-0x0000000189A48730
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C8C */, bool useObjectPool = false /* Metadata: 0x00AF7C90 */) => default; // 0x0000000182DE3160-0x0000000182DE3490
	[BlackList] // 0x0000000189A4FF20-0x0000000189A4FF60
	// [XID] // 0x0000000189A4FF20-0x0000000189A4FF60
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182DE2B40-0x0000000182DE2E10
	// [XID] // 0x0000000189A5A5B0-0x0000000189A5A5D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182DE3EA0-0x0000000182DE4170
	[BlackList] // 0x0000000189A61D10-0x0000000189A61D50
	// [XID] // 0x0000000189A61D10-0x0000000189A61D50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182DE2E10-0x0000000182DE2EB0
	[BlackList] // 0x0000000189A6C7C0-0x0000000189A6C800
	// [XID] // 0x0000000189A6C7C0-0x0000000189A6C800
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182DE2EB0-0x0000000182DE2FA0
	[BlackList] // 0x0000000189A76F70-0x0000000189A76FB0
	// [XID] // 0x0000000189A76F70-0x0000000189A76FB0
	public virtual void ReturnToObjectPool() {} // 0x0000000182DE44B0-0x0000000182DE4550
	[BlackList] // 0x0000000189A81990-0x0000000189A819D0
	// [XID] // 0x0000000189A81990-0x0000000189A819D0
	public virtual void OnPoolAllocated() {} // 0x0000000182DE4410-0x0000000182DE44B0
	[BlackList] // 0x0000000189A8C3D0-0x0000000189A8C410
	// [XID] // 0x0000000189A8C3D0-0x0000000189A8C410
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182DE4370-0x0000000182DE4410
}

