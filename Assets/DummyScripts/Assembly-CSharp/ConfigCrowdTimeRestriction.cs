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
public class ConfigCrowdTimeRestriction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17766
{
	// Fields
	private SimpleSafeFloat startTimeOfDayRawNum; // 0x10
	private SimpleSafeFloat endTimeOfDayRawNum; // 0x14
	private bool _showCrowd; // 0x18

	// Properties
	public float startTimeOfDay { /* [XID] */ /* 0x00000001897C9600-0x00000001897C9620 */ get => default; /* [XID] */ /* 0x00000001897D0BF0-0x00000001897D0C10 */ private set {} } // 0x00000001841F7B20-0x00000001841F7C00 0x00000001841F8080-0x00000001841F8160
	public float endTimeOfDay { /* [XID] */ /* 0x00000001897D8A30-0x00000001897D8A50 */ get => default; /* [XID] */ /* 0x00000001897DFBD0-0x00000001897DFBF0 */ private set {} } // 0x00000001841F8160-0x00000001841F8240 0x00000001841F7A40-0x00000001841F7B20
	public bool showCrowd { /* [XID] */ /* 0x00000001897E71F0-0x00000001897E7210 */ get => default; /* [XID] */ /* 0x00000001897EEED0-0x00000001897EEEF0 */ private set {} } // 0x00000001841F7FE0-0x00000001841F8080 0x00000001841F8770-0x00000001841F8820

	// Constructors
	public ConfigCrowdTimeRestriction() {} // 0x00000001841F88C0-0x00000001841F8920

	// Methods
	// [XID] // 0x00000001897F6540-0x00000001897F6560
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841F8510-0x00000001841F8630
	// [XID] // 0x00000001897FDC80-0x00000001897FDCA0
	public void InitEmpty() {} // 0x00000001841F7C00-0x00000001841F7CE0
	[BlackList] // 0x0000000189805410-0x0000000189805450
	// [XID] // 0x0000000189805410-0x0000000189805450
	public bool FromJson(JSONNode node) => default; // 0x00000001841F76C0-0x00000001841F7A40
	// [XID] // 0x000000018980FDF0-0x000000018980FE10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841F6B30-0x00000001841F6F40
	// [XID] // 0x0000000189817400-0x0000000189817420
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B75 */, bool useObjectPool = false /* Metadata: 0x00AF7B79 */) => default; // 0x00000001841F7CE0-0x00000001841F7FE0
	// [XID] // 0x000000018981ED80-0x000000018981EDA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B7A */, bool useObjectPool = false /* Metadata: 0x00AF7B7E */) => default; // 0x00000001841F7390-0x00000001841F76C0
	[BlackList] // 0x00000001898262D0-0x0000000189826310
	// [XID] // 0x00000001898262D0-0x0000000189826310
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841F6F40-0x00000001841F7210
	// [XID] // 0x0000000189830920-0x0000000189830940
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841F8240-0x00000001841F8510
	[BlackList] // 0x0000000189837EE0-0x0000000189837F20
	// [XID] // 0x0000000189837EE0-0x0000000189837F20
	public virtual void AutoAllocTypeFields() {} // 0x00000001841F7210-0x00000001841F72B0
	[BlackList] // 0x0000000189842680-0x00000001898426C0
	// [XID] // 0x0000000189842680-0x00000001898426C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841F72B0-0x00000001841F7390
	[BlackList] // 0x000000018984CA00-0x000000018984CA40
	// [XID] // 0x000000018984CA00-0x000000018984CA40
	public virtual void ReturnToObjectPool() {} // 0x00000001841F8820-0x00000001841F88C0
	[BlackList] // 0x0000000189856B60-0x0000000189856BA0
	// [XID] // 0x0000000189856B60-0x0000000189856BA0
	public virtual void OnPoolAllocated() {} // 0x00000001841F86D0-0x00000001841F8770
	[BlackList] // 0x0000000189861010-0x0000000189861050
	// [XID] // 0x0000000189861010-0x0000000189861050
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841F8630-0x00000001841F86D0
}

