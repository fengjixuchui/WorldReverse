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
public class ConfigSafeTypeReportData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18126
{
	// Fields
	private SimpleSafeInt32 maxCountRawNum; // 0x10

	// Properties
	public int maxCount { /* [XID] */ /* 0x0000000189BDAE80-0x0000000189BDAEA0 */ get => default; /* [XID] */ /* 0x00000001895E7870-0x00000001895E7890 */ private set {} } // 0x0000000181F31E20-0x0000000181F31EF0 0x0000000181F31970-0x0000000181F31A50

	// Constructors
	public ConfigSafeTypeReportData() {} // 0x0000000181F32390-0x0000000181F32420

	// Methods
	// [XID] // 0x00000001895EF180-0x00000001895EF1A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F320D0-0x0000000181F321B0
	// [XID] // 0x00000001895F6B60-0x00000001895F6B80
	public void InitEmpty() {} // 0x0000000181F31A50-0x0000000181F31B20
	[BlackList] // 0x00000001895FDF40-0x00000001895FDF80
	// [XID] // 0x00000001895FDF40-0x00000001895FDF80
	public bool FromJson(JSONNode node) => default; // 0x0000000181F315F0-0x0000000181F31970
	// [XID] // 0x0000000189608A70-0x0000000189608A90
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181F30DE0-0x0000000181F30FE0
	// [XID] // 0x0000000189610270-0x0000000189610290
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C03 */, bool useObjectPool = false /* Metadata: 0x00AF8C07 */) => default; // 0x0000000181F31B20-0x0000000181F31E20
	// [XID] // 0x0000000189617530-0x0000000189617550
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C08 */, bool useObjectPool = false /* Metadata: 0x00AF8C0C */) => default; // 0x0000000181F31420-0x0000000181F315F0
	[BlackList] // 0x000000018961F080-0x000000018961F0C0
	// [XID] // 0x000000018961F080-0x000000018961F0C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F30FE0-0x0000000181F312B0
	// [XID] // 0x00000001896297D0-0x00000001896297F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F31EF0-0x0000000181F320D0
	[BlackList] // 0x00000001896310A0-0x00000001896310E0
	// [XID] // 0x00000001896310A0-0x00000001896310E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F312B0-0x0000000181F31350
	[BlackList] // 0x000000018963B7E0-0x000000018963B820
	// [XID] // 0x000000018963B7E0-0x000000018963B820
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F31350-0x0000000181F31420
	[BlackList] // 0x0000000189645E40-0x0000000189645E80
	// [XID] // 0x0000000189645E40-0x0000000189645E80
	public virtual void ReturnToObjectPool() {} // 0x0000000181F322F0-0x0000000181F32390
	[BlackList] // 0x0000000189650610-0x0000000189650650
	// [XID] // 0x0000000189650610-0x0000000189650650
	public virtual void OnPoolAllocated() {} // 0x0000000181F32250-0x0000000181F322F0
	[BlackList] // 0x000000018965AED0-0x000000018965AF10
	// [XID] // 0x000000018965AED0-0x000000018965AF10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F321B0-0x0000000181F32250
}

