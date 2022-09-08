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

[RecycleType] // 0x0000000189ADEFB0-0x0000000189ADEFD0
public class SECTR_LayerLoader : IEmptyInitable, IHashable, IAutoAllocRecycleJobThread // TypeDefIndex: 18974
{
	// Fields
	private string _layerName; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_StreamObject[] _virtualObjects; // 0x18

	// Properties
	public string layerName { /* [XID] */ /* 0x0000000189A2A700-0x0000000189A2A720 */ get => default; /* [XID] */ /* 0x0000000189A31C40-0x0000000189A31C60 */ private set {} } // 0x00000001849AD940-0x00000001849AD9E0 0x00000001849AD570-0x00000001849AD620
	public SECTR_StreamObject[] virtualObjects { /* [XID] */ /* 0x0000000189A39690-0x0000000189A396B0 */ get => default; /* [XID] */ /* 0x0000000189A40E50-0x0000000189A40E70 */ private set {} } // 0x00000001849ADC50-0x00000001849ADCF0 0x00000001849AD620-0x00000001849AD6D0

	// Constructors
	public SECTR_LayerLoader() {} // 0x00000001849ADDA0-0x00000001849ADE00

	// Methods
	// [XID] // 0x0000000189A484B0-0x0000000189A484D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849AD9E0-0x00000001849ADAF0
	// [XID] // 0x0000000189A4FD80-0x0000000189A4FDA0
	public void InitEmpty() {} // 0x00000001849AD190-0x00000001849AD270
	[BlackList] // 0x0000000189A57290-0x0000000189A572D0
	// [XID] // 0x0000000189A57290-0x0000000189A572D0
	public bool FromJson(JSONNode node) => default; // 0x00000001849ACE10-0x00000001849AD190
	// [XID] // 0x0000000189A61BD0-0x0000000189A61BF0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001849AC440-0x00000001849AC710
	// [XID] // 0x0000000189A69AF0-0x0000000189A69B10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB607 */, bool useObjectPool = false /* Metadata: 0x00AFB60B */) => default; // 0x00000001849AD270-0x00000001849AD570
	// [XID] // 0x0000000189A70DE0-0x0000000189A70E00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB60C */, bool useObjectPool = false /* Metadata: 0x00AFB610 */) => default; // 0x00000001849ACB50-0x00000001849ACE10
	[BlackList] // 0x0000000189A78880-0x0000000189A788C0
	// [XID] // 0x0000000189A78880-0x0000000189A788C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001849AC710-0x00000001849AC9E0
	// [XID] // 0x0000000189A83100-0x0000000189A83120
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849AD6D0-0x00000001849AD940
	[BlackList] // 0x0000000189A8A9B0-0x0000000189A8A9F0
	// [XID] // 0x0000000189A8A9B0-0x0000000189A8A9F0
	public virtual void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001849AC9E0-0x00000001849ACA90
	[BlackList] // 0x0000000189A94F30-0x0000000189A94F70
	// [XID] // 0x0000000189A94F30-0x0000000189A94F70
	public virtual void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001849ACA90-0x00000001849ACB50
	[BlackList] // 0x0000000189A9F670-0x0000000189A9F6B0
	// [XID] // 0x0000000189A9F670-0x0000000189A9F6B0
	public virtual void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001849ADCF0-0x00000001849ADDA0
	// [XID] // 0x0000000189AA9B00-0x0000000189AA9B20
	public virtual void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001849ADBA0-0x00000001849ADC50
	// [XID] // 0x0000000189AB1A40-0x0000000189AB1A60
	public virtual void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001849ADAF0-0x00000001849ADBA0
}

