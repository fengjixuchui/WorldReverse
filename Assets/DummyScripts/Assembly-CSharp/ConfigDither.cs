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
public class ConfigDither : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17956
{
	// Fields
	private SimpleSafeFloat showDitherDurationRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDitherByStartDitherAction _startDitherAction; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDitherByBetweenCameraAndAvatar _betweenCameraAndAvatar; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDitherByNormalBetweenCamera _normalBetweenCamera; // 0x28

	// Properties
	public float showDitherDuration { /* [XID] */ /* 0x00000001897DAA80-0x00000001897DAAA0 */ get => default; /* [XID] */ /* 0x00000001898F0300-0x00000001898F0320 */ private set {} } // 0x00000001850C5070-0x00000001850C5150 0x00000001850C4F90-0x00000001850C5070
	public ConfigDitherByStartDitherAction startDitherAction { /* [XID] */ /* 0x00000001898F7D90-0x00000001898F7DB0 */ get => default; /* [XID] */ /* 0x00000001898FF410-0x00000001898FF430 */ private set {} } // 0x00000001850C4960-0x00000001850C4A00 0x00000001850C48B0-0x00000001850C4960
	public ConfigDitherByBetweenCameraAndAvatar betweenCameraAndAvatar { /* [XID] */ /* 0x0000000189906BB0-0x0000000189906BD0 */ get => default; /* [XID] */ /* 0x000000018990E6D0-0x000000018990E6F0 */ private set {} } // 0x00000001850C4030-0x00000001850C40D0 0x00000001850C4A00-0x00000001850C4AB0
	public ConfigDitherByNormalBetweenCamera normalBetweenCamera { /* [XID] */ /* 0x0000000189915D40-0x0000000189915D60 */ get => default; /* [XID] */ /* 0x000000018991D7B0-0x000000018991D7D0 */ private set {} } // 0x00000001850C3CB0-0x00000001850C3D50 0x00000001850C4BE0-0x00000001850C4C90

	// Constructors
	public ConfigDither() {} // 0x00000001850C5860-0x00000001850C58F0

	// Methods
	// [XID] // 0x0000000189924FE0-0x0000000189925000
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850C5500-0x00000001850C5680
	// [XID] // 0x000000018992C5A0-0x000000018992C5C0
	public void InitEmpty() {} // 0x00000001850C4AB0-0x00000001850C4BE0
	[BlackList] // 0x0000000189933BE0-0x0000000189933C20
	// [XID] // 0x0000000189933BE0-0x0000000189933C20
	public bool FromJson(JSONNode node) => default; // 0x00000001850C4530-0x00000001850C48B0
	// [XID] // 0x000000018993E530-0x000000018993E550
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001850C34F0-0x00000001850C39E0
	// [XID] // 0x0000000189945BC0-0x0000000189945BE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84BF */, bool useObjectPool = false /* Metadata: 0x00AF84C3 */) => default; // 0x00000001850C4C90-0x00000001850C4F90
	// [XID] // 0x000000018994D070-0x000000018994D090
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84C4 */, bool useObjectPool = false /* Metadata: 0x00AF84C8 */) => default; // 0x00000001850C40D0-0x00000001850C4530
	[BlackList] // 0x0000000189954760-0x00000001899547A0
	// [XID] // 0x0000000189954760-0x00000001899547A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001850C39E0-0x00000001850C3CB0
	// [XID] // 0x000000018995F1B0-0x000000018995F1D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850C5150-0x00000001850C5500
	[BlackList] // 0x0000000189966A90-0x0000000189966AD0
	// [XID] // 0x0000000189966A90-0x0000000189966AD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001850C3D50-0x00000001850C3DF0
	[BlackList] // 0x0000000189971660-0x00000001899716A0
	// [XID] // 0x0000000189971660-0x00000001899716A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001850C3DF0-0x00000001850C4030
	[BlackList] // 0x000000018997B940-0x000000018997B980
	// [XID] // 0x000000018997B940-0x000000018997B980
	public virtual void ReturnToObjectPool() {} // 0x00000001850C57C0-0x00000001850C5860
	[BlackList] // 0x0000000189985F70-0x0000000189985FB0
	// [XID] // 0x0000000189985F70-0x0000000189985FB0
	public virtual void OnPoolAllocated() {} // 0x00000001850C5720-0x00000001850C57C0
	[BlackList] // 0x0000000189990C90-0x0000000189990CD0
	// [XID] // 0x0000000189990C90-0x0000000189990CD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001850C5680-0x00000001850C5720
}

