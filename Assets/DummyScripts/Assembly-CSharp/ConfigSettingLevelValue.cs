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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigSettingLevelValue : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18130
{
	// Fields
	private Dictionary<string, SimpleSafeInt32> _qualityResolutionPercentageMap; // 0x10
	private string[] _graphicsRecommendGrades; // 0x18

	// Properties
	public Dictionary<string, SimpleSafeInt32> qualityResolutionPercentageMap { /* [XID] */ /* 0x0000000189ADF330-0x0000000189ADF350 */ get => default; /* [XID] */ /* 0x0000000189AE6B70-0x0000000189AE6B90 */ private set {} } // 0x000000018391BAB0-0x000000018391BB50 0x000000018391BA00-0x000000018391BAB0
	public string[] graphicsRecommendGrades { /* [XID] */ /* 0x0000000189AEE680-0x0000000189AEE6A0 */ get => default; /* [XID] */ /* 0x0000000189AF5BD0-0x0000000189AF5BF0 */ private set {} } // 0x000000018391BC40-0x000000018391BCE0 0x000000018391BFE0-0x000000018391C090

	// Constructors
	public ConfigSettingLevelValue() {} // 0x000000018391C620-0x000000018391C680

	// Methods
	// [XID] // 0x0000000189AFD0F0-0x0000000189AFD110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018391C330-0x000000018391C440
	// [XID] // 0x0000000189B04940-0x0000000189B04960
	public void InitEmpty() {} // 0x000000018391BB50-0x000000018391BC40
	[BlackList] // 0x0000000189B0C150-0x0000000189B0C190
	// [XID] // 0x0000000189B0C150-0x0000000189B0C190
	public bool FromJson(JSONNode node) => default; // 0x000000018391B680-0x000000018391BA00
	// [XID] // 0x0000000189B16430-0x0000000189B16450
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018391ACD0-0x000000018391AFA0
	// [XID] // 0x0000000189B1DB30-0x0000000189B1DB50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C2B */, bool useObjectPool = false /* Metadata: 0x00AF8C2F */) => default; // 0x000000018391BCE0-0x000000018391BFE0
	// [XID] // 0x0000000189B25340-0x0000000189B25360
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C30 */, bool useObjectPool = false /* Metadata: 0x00AF8C34 */) => default; // 0x000000018391B3B0-0x000000018391B680
	[BlackList] // 0x0000000189B2C8B0-0x0000000189B2C8F0
	// [XID] // 0x0000000189B2C8B0-0x0000000189B2C8F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018391AFA0-0x000000018391B270
	// [XID] // 0x0000000189B36E50-0x0000000189B36E70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018391C090-0x000000018391C330
	[BlackList] // 0x0000000189B3E720-0x0000000189B3E760
	// [XID] // 0x0000000189B3E720-0x0000000189B3E760
	public virtual void AutoAllocTypeFields() {} // 0x000000018391B270-0x000000018391B310
	[BlackList] // 0x0000000189B49340-0x0000000189B49380
	// [XID] // 0x0000000189B49340-0x0000000189B49380
	public virtual void AutoRecycleTypeFields() {} // 0x000000018391B310-0x000000018391B3B0
	[BlackList] // 0x0000000189B537C0-0x0000000189B53800
	// [XID] // 0x0000000189B537C0-0x0000000189B53800
	public virtual void ReturnToObjectPool() {} // 0x000000018391C580-0x000000018391C620
	[BlackList] // 0x0000000189B5E200-0x0000000189B5E240
	// [XID] // 0x0000000189B5E200-0x0000000189B5E240
	public virtual void OnPoolAllocated() {} // 0x000000018391C4E0-0x000000018391C580
	[BlackList] // 0x0000000189B68880-0x0000000189B688C0
	// [XID] // 0x0000000189B68880-0x0000000189B688C0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018391C440-0x000000018391C4E0
}

