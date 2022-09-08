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
public class ConfigGlobalValues : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18129
{
	// Fields
	private Dictionary<NPCBodyType, FirstPersonCoopCamConfig> _firstPersonCoopCamConfigs; // 0x10

	// Properties
	public Dictionary<NPCBodyType, FirstPersonCoopCamConfig> firstPersonCoopCamConfigs { /* [XID] */ /* 0x0000000189A51630-0x0000000189A51650 */ get => default; /* [XID] */ /* 0x0000000189A58CC0-0x0000000189A58CE0 */ private set {} } // 0x0000000182AF7ED0-0x0000000182AF7F70 0x0000000182AF8EC0-0x0000000182AF8F70

	// Constructors
	public ConfigGlobalValues() {} // 0x0000000182AF9420-0x0000000182AF9480

	// Methods
	// [XID] // 0x0000000189A60620-0x0000000189A60640
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AF9160-0x0000000182AF9240
	// [XID] // 0x0000000189A68310-0x0000000189A68330
	public void InitEmpty() {} // 0x0000000182AF8AF0-0x0000000182AF8BC0
	[BlackList] // 0x0000000189A6F6C0-0x0000000189A6F700
	// [XID] // 0x0000000189A6F6C0-0x0000000189A6F700
	public bool FromJson(JSONNode node) => default; // 0x0000000182AF8770-0x0000000182AF8AF0
	// [XID] // 0x0000000189A7A450-0x0000000189A7A470
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AF7F70-0x0000000182AF8150
	// [XID] // 0x0000000189A81910-0x0000000189A81930
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C21 */, bool useObjectPool = false /* Metadata: 0x00AF8C25 */) => default; // 0x0000000182AF8BC0-0x0000000182AF8EC0
	// [XID] // 0x0000000189A89450-0x0000000189A89470
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8C26 */, bool useObjectPool = false /* Metadata: 0x00AF8C2A */) => default; // 0x0000000182AF8560-0x0000000182AF8770
	[BlackList] // 0x0000000189A90CB0-0x0000000189A90CF0
	// [XID] // 0x0000000189A90CB0-0x0000000189A90CF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AF8150-0x0000000182AF8420
	// [XID] // 0x0000000189A9B3A0-0x0000000189A9B3C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AF8F70-0x0000000182AF9160
	[BlackList] // 0x0000000189AA2700-0x0000000189AA2740
	// [XID] // 0x0000000189AA2700-0x0000000189AA2740
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AF8420-0x0000000182AF84C0
	[BlackList] // 0x0000000189AACEE0-0x0000000189AACF20
	// [XID] // 0x0000000189AACEE0-0x0000000189AACF20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AF84C0-0x0000000182AF8560
	[BlackList] // 0x0000000189AB77D0-0x0000000189AB7810
	// [XID] // 0x0000000189AB77D0-0x0000000189AB7810
	public virtual void ReturnToObjectPool() {} // 0x0000000182AF9380-0x0000000182AF9420
	[BlackList] // 0x0000000189AC2480-0x0000000189AC24C0
	// [XID] // 0x0000000189AC2480-0x0000000189AC24C0
	public virtual void OnPoolAllocated() {} // 0x0000000182AF92E0-0x0000000182AF9380
	[BlackList] // 0x0000000189ACCA20-0x0000000189ACCA60
	// [XID] // 0x0000000189ACCA20-0x0000000189ACCA60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AF9240-0x0000000182AF92E0
}

