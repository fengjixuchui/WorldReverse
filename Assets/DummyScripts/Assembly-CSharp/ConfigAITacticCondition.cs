/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAITacticCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17414
{
	// Fields
	private SimpleSafeInt32[] _pose; // 0x10
	public static Action<ConfigAITacticCondition, bool> postProcessData; // 0x00
	public static Action<ConfigAITacticCondition> postInitEmpty; // 0x08
	[BlackList] // 0x0000000189BBCB10-0x0000000189BBCB60
	[JsonIgnore] // 0x0000000189BBCB10-0x0000000189BBCB60
	// [PooledField] // 0x0000000189BBCB10-0x0000000189BBCB60
	public List<int> poseList; // 0x18

	// Properties
	public SimpleSafeInt32[] pose { /* [XID] */ /* 0x00000001896B4E30-0x00000001896B4E50 */ get => default; /* [XID] */ /* 0x00000001896BC160-0x00000001896BC180 */ private set {} } // 0x0000000184877E70-0x0000000184877F10 0x00000001848778F0-0x00000001848779A0

	// Constructors
	public ConfigAITacticCondition() {} // 0x0000000184878C90-0x0000000184878CF0
	static ConfigAITacticCondition() {} // 0x0000000184878AB0-0x0000000184878C90

	// Methods
	// [XID] // 0x00000001897FBE90-0x00000001897FBEB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184878790-0x0000000184878870
	// [XID] // 0x00000001896CAB90-0x00000001896CABB0
	public void InitEmpty() {} // 0x0000000184877F10-0x0000000184878060
	[BlackList] // 0x00000001896D2220-0x00000001896D2260
	// [XID] // 0x00000001896D2220-0x00000001896D2260
	public bool FromJson(JSONNode node) => default; // 0x00000001848779A0-0x0000000184877DA0
	// [XID] // 0x00000001896DC820-0x00000001896DC840
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001848770E0-0x00000001848772C0
	// [XID] // 0x00000001896E4170-0x00000001896E4190
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DC7 */, bool useObjectPool = false /* Metadata: 0x00AF6DCB */) => default; // 0x0000000184878060-0x00000001848783E0
	// [XID] // 0x00000001896EB620-0x00000001896EB640
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DCC */, bool useObjectPool = false /* Metadata: 0x00AF6DD0 */) => default; // 0x00000001848776E0-0x00000001848778F0
	[BlackList] // 0x00000001896F29F0-0x00000001896F2A30
	// [XID] // 0x00000001896F29F0-0x00000001896F2A30
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001848772C0-0x0000000184877590
	// [XID] // 0x00000001896FD4F0-0x00000001896FD510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848785A0-0x0000000184878790
	[BlackList] // 0x0000000189704930-0x0000000189704970
	// [XID] // 0x0000000189704930-0x0000000189704970
	public virtual void OnPoolAllocated() {} // 0x0000000184878970-0x0000000184878A10
	[BlackList] // 0x000000018970F320-0x000000018970F360
	// [XID] // 0x000000018970F320-0x000000018970F360
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184878870-0x0000000184878970
	// [XID] // 0x0000000189719A50-0x0000000189719A70
	private static void OnPostInitEmpty(ConfigAITacticCondition data) {} // 0x0000000184877DA0-0x0000000184877E70
	// [XID] // 0x0000000189720F70-0x0000000189720F90
	private static void OnPostProcessDataCallback(ConfigAITacticCondition data, bool useObjectPool) {} // 0x00000001848783E0-0x00000001848785A0
	[BlackList] // 0x0000000189728630-0x0000000189728670
	// [XID] // 0x0000000189728630-0x0000000189728670
	public virtual void AutoAllocTypeFields() {} // 0x0000000184877590-0x0000000184877630
	[BlackList] // 0x0000000189732C40-0x0000000189732C80
	// [XID] // 0x0000000189732C40-0x0000000189732C80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184877630-0x00000001848776E0
	[BlackList] // 0x000000018973D770-0x000000018973D7B0
	// [XID] // 0x000000018973D770-0x000000018973D7B0
	public virtual void ReturnToObjectPool() {} // 0x0000000184878A10-0x0000000184878AB0
}

