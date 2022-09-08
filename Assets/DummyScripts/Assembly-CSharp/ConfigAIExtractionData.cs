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
public class ConfigAIExtractionData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17481
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat extractionDistanceRawNum; // 0x14
	private SimpleSafeFloat extractionAngleMaxRawNum; // 0x18
	private SimpleSafeFloat extractionAngleMinRawNum; // 0x1C
	private SimpleSafeFloat triggerDistanceRawNum; // 0x20
	private SimpleSafeFloat killSelfTimeRawNum; // 0x24

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001898B8620-0x00000001898B8640 */ get => default; /* [XID] */ /* 0x00000001898BFE20-0x00000001898BFE40 */ private set {} } // 0x0000000183D88310-0x0000000183D883E0 0x0000000183D883E0-0x0000000183D884C0
	public float extractionDistance { /* [XID] */ /* 0x00000001898C76E0-0x00000001898C7700 */ get => default; /* [XID] */ /* 0x00000001898CECF0-0x00000001898CED10 */ private set {} } // 0x0000000183D89370-0x0000000183D89450 0x0000000183D89450-0x0000000183D89530
	public float extractionAngleMax { /* [XID] */ /* 0x00000001898D66C0-0x00000001898D66E0 */ get => default; /* [XID] */ /* 0x00000001898DE360-0x00000001898DE380 */ private set {} } // 0x0000000183D88900-0x0000000183D889E0 0x0000000183D89530-0x0000000183D89610
	public float extractionAngleMin { /* [XID] */ /* 0x00000001898E5BA0-0x00000001898E5BC0 */ get => default; /* [XID] */ /* 0x00000001898ED4E0-0x00000001898ED500 */ private set {} } // 0x0000000183D88F90-0x0000000183D89070 0x0000000183D89E40-0x0000000183D89F20
	public float triggerDistance { /* [XID] */ /* 0x00000001898F4DC0-0x00000001898F4DE0 */ get => default; /* [XID] */ /* 0x00000001898FC490-0x00000001898FC4B0 */ private set {} } // 0x0000000183D89F20-0x0000000183D8A000 0x0000000183D89D60-0x0000000183D89E40
	public float killSelfTime { /* [XID] */ /* 0x0000000189903F10-0x0000000189903F30 */ get => default; /* [XID] */ /* 0x000000018990B470-0x000000018990B490 */ private set {} } // 0x0000000183D88D60-0x0000000183D88E40 0x0000000183D87D70-0x0000000183D87E50

	// Constructors
	public ConfigAIExtractionData() {} // 0x0000000183D8A0A0-0x0000000183D8A1C0

	// Methods
	// [XID] // 0x00000001899131A0-0x00000001899131C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D89AB0-0x0000000183D89C20
	// [XID] // 0x000000018991A910-0x000000018991A930
	public void InitEmpty() {} // 0x0000000183D88E40-0x0000000183D88F90
	[BlackList] // 0x00000001899221A0-0x00000001899221E0
	// [XID] // 0x00000001899221A0-0x00000001899221E0
	public bool FromJson(JSONNode node) => default; // 0x0000000183D889E0-0x0000000183D88D60
	// [XID] // 0x000000018992C640-0x000000018992C660
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183D87680-0x0000000183D87D70
	// [XID] // 0x0000000189933D60-0x0000000189933D80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7017 */, bool useObjectPool = false /* Metadata: 0x00AF701B */) => default; // 0x0000000183D89070-0x0000000183D89370
	// [XID] // 0x000000018993B8F0-0x000000018993B910
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF701C */, bool useObjectPool = false /* Metadata: 0x00AF7020 */) => default; // 0x0000000183D884C0-0x0000000183D88900
	[BlackList] // 0x00000001899429D0-0x0000000189942A10
	// [XID] // 0x00000001899429D0-0x0000000189942A10
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D87E50-0x0000000183D88120
	// [XID] // 0x000000018994D150-0x000000018994D170
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D89610-0x0000000183D89AB0
	[BlackList] // 0x00000001899548C0-0x0000000189954900
	// [XID] // 0x00000001899548C0-0x0000000189954900
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D88120-0x0000000183D881C0
	[BlackList] // 0x000000018995F270-0x000000018995F2B0
	// [XID] // 0x000000018995F270-0x000000018995F2B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D881C0-0x0000000183D88310
	[BlackList] // 0x00000001899699C0-0x0000000189969A00
	// [XID] // 0x00000001899699C0-0x0000000189969A00
	public virtual void ReturnToObjectPool() {} // 0x0000000183D8A000-0x0000000183D8A0A0
	[BlackList] // 0x0000000189974370-0x00000001899743B0
	// [XID] // 0x0000000189974370-0x00000001899743B0
	public virtual void OnPoolAllocated() {} // 0x0000000183D89CC0-0x0000000183D89D60
	[BlackList] // 0x000000018997E660-0x000000018997E6A0
	// [XID] // 0x000000018997E660-0x000000018997E6A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D89C20-0x0000000183D89CC0
}

