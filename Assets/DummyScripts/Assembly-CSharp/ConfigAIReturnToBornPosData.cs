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
public class ConfigAIReturnToBornPosData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17416
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat fadeoutBeginTimeRawNum; // 0x14
	private SimpleSafeFloat fadeoutEndTimeRawNum; // 0x18
	private bool _spacial; // 0x1C

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001898321F0-0x0000000189832210 */ get => default; /* [XID] */ /* 0x00000001898398E0-0x0000000189839900 */ private set {} } // 0x00000001832B9E80-0x00000001832B9F50 0x00000001832BA030-0x00000001832BA110
	public float fadeoutBeginTime { /* [XID] */ /* 0x0000000189840D80-0x0000000189840DA0 */ get => default; /* [XID] */ /* 0x0000000189848240-0x0000000189848260 */ private set {} } // 0x00000001832BA540-0x00000001832BA620 0x00000001832BA620-0x00000001832BA700
	public float fadeoutEndTime { /* [XID] */ /* 0x000000018984F960-0x000000018984F980 */ get => default; /* [XID] */ /* 0x0000000189856C80-0x0000000189856CA0 */ private set {} } // 0x00000001832BA110-0x00000001832BA1F0 0x00000001832B9F50-0x00000001832BA030
	public bool spacial { /* [XID] */ /* 0x000000018985DDF0-0x000000018985DE10 */ get => default; /* [XID] */ /* 0x00000001898657F0-0x0000000189865810 */ private set {} } // 0x00000001832BAB30-0x00000001832BABD0 0x00000001832BA700-0x00000001832BA7B0

	// Constructors
	public ConfigAIReturnToBornPosData() {} // 0x00000001832BB680-0x00000001832BB760

	// Methods
	// [XID] // 0x000000018986CD30-0x000000018986CD50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832BB360-0x00000001832BB4A0
	// [XID] // 0x00000001898741A0-0x00000001898741C0
	public void InitEmpty() {} // 0x00000001832BABD0-0x00000001832BACE0
	[BlackList] // 0x000000018987BC80-0x000000018987BCC0
	// [XID] // 0x000000018987BC80-0x000000018987BCC0
	public bool FromJson(JSONNode node) => default; // 0x00000001832BA7B0-0x00000001832BAB30
	// [XID] // 0x0000000189886160-0x0000000189886180
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832B9540-0x00000001832B9A00
	// [XID] // 0x000000018988D400-0x000000018988D420
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DE1 */, bool useObjectPool = false /* Metadata: 0x00AF6DE5 */) => default; // 0x00000001832BACE0-0x00000001832BAFE0
	// [XID] // 0x0000000189894B10-0x0000000189894B30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DE6 */, bool useObjectPool = false /* Metadata: 0x00AF6DEA */) => default; // 0x00000001832BA1F0-0x00000001832BA540
	[BlackList] // 0x000000018989C0E0-0x000000018989C120
	// [XID] // 0x000000018989C0E0-0x000000018989C120
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832B9A00-0x00000001832B9CD0
	// [XID] // 0x00000001898A6880-0x00000001898A68A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832BAFE0-0x00000001832BB360
	[BlackList] // 0x00000001898ADF90-0x00000001898ADFD0
	// [XID] // 0x00000001898ADF90-0x00000001898ADFD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001832B9CD0-0x00000001832B9D70
	[BlackList] // 0x00000001898B8660-0x00000001898B86A0
	// [XID] // 0x00000001898B8660-0x00000001898B86A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832B9D70-0x00000001832B9E80
	[BlackList] // 0x00000001898C2C20-0x00000001898C2C60
	// [XID] // 0x00000001898C2C20-0x00000001898C2C60
	public virtual void ReturnToObjectPool() {} // 0x00000001832BB5E0-0x00000001832BB680
	[BlackList] // 0x00000001898CD480-0x00000001898CD4C0
	// [XID] // 0x00000001898CD480-0x00000001898CD4C0
	public virtual void OnPoolAllocated() {} // 0x00000001832BB540-0x00000001832BB5E0
	[BlackList] // 0x00000001898D7DA0-0x00000001898D7DE0
	// [XID] // 0x00000001898D7DA0-0x00000001898D7DE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832BB4A0-0x00000001832BB540
}

