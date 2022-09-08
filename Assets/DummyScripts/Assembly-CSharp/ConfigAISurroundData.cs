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
public class ConfigAISurroundData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17448
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat turnSpeedOverrideRawNum; // 0x14
	private SimpleSafeFloat startDistanceRawNum; // 0x18
	private SimpleSafeFloat surroundRadiusRawNum; // 0x1C
	private string[] _turningStates; // 0x20
	private SimpleSafeFloat detectFrontDistanceRawNum; // 0x28
	private SimpleSafeFloat detectFrontOffsetUpRawNum; // 0x2C
	private SimpleSafeFloat detectFrontOffsetForwardRawNum; // 0x30

	// Properties
	public int speedLevel { /* [XID] */ /* 0x0000000189874180-0x00000001898741A0 */ get => default; /* [XID] */ /* 0x000000018987BC60-0x000000018987BC80 */ private set {} } // 0x000000018434C720-0x000000018434C7F0 0x000000018434CB70-0x000000018434CC50
	public float turnSpeedOverride { /* [XID] */ /* 0x0000000189882E30-0x0000000189882E50 */ get => default; /* [XID] */ /* 0x000000018988A690-0x000000018988A6B0 */ private set {} } // 0x000000018434CA90-0x000000018434CB70 0x000000018434D260-0x000000018434D340
	public float startDistance { /* [XID] */ /* 0x0000000189891B40-0x0000000189891B60 */ get => default; /* [XID] */ /* 0x0000000189899470-0x0000000189899490 */ private set {} } // 0x000000018434DEA0-0x000000018434DF80 0x000000018434C9B0-0x000000018434CA90
	public float surroundRadius { /* [XID] */ /* 0x00000001898A0690-0x00000001898A06B0 */ get => default; /* [XID] */ /* 0x00000001898A7D50-0x00000001898A7D70 */ private set {} } // 0x000000018434D920-0x000000018434DA00 0x000000018434D340-0x000000018434D420
	public string[] turningStates { /* [XID] */ /* 0x00000001898AF810-0x00000001898AF830 */ get => default; /* [XID] */ /* 0x00000001898B6DD0-0x00000001898B6DF0 */ private set {} } // 0x000000018434D420-0x000000018434D4C0 0x000000018434CC50-0x000000018434CD00
	public float detectFrontDistance { /* [XID] */ /* 0x00000001898BE4A0-0x00000001898BE4C0 */ get => default; /* [XID] */ /* 0x00000001898C5CD0-0x00000001898C5CF0 */ private set {} } // 0x000000018434C8D0-0x000000018434C9B0 0x000000018434DF80-0x000000018434E060
	public float detectFrontOffsetUp { /* [XID] */ /* 0x00000001898CD460-0x00000001898CD480 */ get => default; /* [XID] */ /* 0x00000001898D4E50-0x00000001898D4E70 */ private set {} } // 0x000000018434E060-0x000000018434E140 0x000000018434EA10-0x000000018434EAF0
	public float detectFrontOffsetForward { /* [XID] */ /* 0x00000001898DC7F0-0x00000001898DC810 */ get => default; /* [XID] */ /* 0x00000001898E4220-0x00000001898E4240 */ private set {} } // 0x000000018434C7F0-0x000000018434C8D0 0x000000018434D840-0x000000018434D920

	// Constructors
	public ConfigAISurroundData() {} // 0x000000018434EB90-0x000000018434ECC0

	// Methods
	// [XID] // 0x00000001898EBCD0-0x00000001898EBCF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018434E720-0x000000018434E8D0
	// [XID] // 0x00000001898F3540-0x00000001898F3560
	public void InitEmpty() {} // 0x000000018434DA00-0x000000018434DBA0
	[BlackList] // 0x00000001898FAB20-0x00000001898FAB60
	// [XID] // 0x00000001898FAB20-0x00000001898FAB60
	public bool FromJson(JSONNode node) => default; // 0x000000018434D4C0-0x000000018434D840
	// [XID] // 0x00000001899055C0-0x00000001899055E0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018434B9A0-0x000000018434C240
	// [XID] // 0x000000018990CEB0-0x000000018990CED0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EF9 */, bool useObjectPool = false /* Metadata: 0x00AF6EFD */) => default; // 0x000000018434DBA0-0x000000018434DEA0
	// [XID] // 0x00000001899146A0-0x00000001899146C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EFE */, bool useObjectPool = false /* Metadata: 0x00AF6F02 */) => default; // 0x000000018434CD00-0x000000018434D260
	[BlackList] // 0x000000018991C1C0-0x000000018991C200
	// [XID] // 0x000000018991C1C0-0x000000018991C200
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018434C240-0x000000018434C510
	// [XID] // 0x0000000189926920-0x0000000189926940
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018434E140-0x000000018434E720
	[BlackList] // 0x000000018992DF10-0x000000018992DF50
	// [XID] // 0x000000018992DF10-0x000000018992DF50
	public virtual void AutoAllocTypeFields() {} // 0x000000018434C510-0x000000018434C5B0
	[BlackList] // 0x00000001899382D0-0x0000000189938310
	// [XID] // 0x00000001899382D0-0x0000000189938310
	public virtual void AutoRecycleTypeFields() {} // 0x000000018434C5B0-0x000000018434C720
	[BlackList] // 0x0000000189942A10-0x0000000189942A50
	// [XID] // 0x0000000189942A10-0x0000000189942A50
	public virtual void ReturnToObjectPool() {} // 0x000000018434EAF0-0x000000018434EB90
	[BlackList] // 0x000000018994D170-0x000000018994D1B0
	// [XID] // 0x000000018994D170-0x000000018994D1B0
	public virtual void OnPoolAllocated() {} // 0x000000018434E970-0x000000018434EA10
	[BlackList] // 0x0000000189957A40-0x0000000189957A80
	// [XID] // 0x0000000189957A40-0x0000000189957A80
	public virtual void OnBeforePoolRecycled() {} // 0x000000018434E8D0-0x000000018434E970
}

