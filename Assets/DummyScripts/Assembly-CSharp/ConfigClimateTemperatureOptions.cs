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
public class ConfigClimateTemperatureOptions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17652
{
	// Fields
	private SimpleSafeFloat speedRawNum; // 0x10

	// Properties
	public float speed { /* [XID] */ /* 0x00000001896ECBE0-0x00000001896ECC00 */ get => default; /* [XID] */ /* 0x00000001896F4360-0x00000001896F4380 */ private set {} } // 0x00000001848C9A30-0x00000001848C9B10 0x00000001848C9580-0x00000001848C9660

	// Constructors
	public ConfigClimateTemperatureOptions() {} // 0x00000001848C9F90-0x00000001848C9FF0

	// Methods
	// [XID] // 0x00000001896FBBB0-0x00000001896FBBD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001848C9CC0-0x00000001848C9DB0
	// [XID] // 0x0000000189703150-0x0000000189703170
	public void InitEmpty() {} // 0x00000001848C9660-0x00000001848C9730
	[BlackList] // 0x000000018970A840-0x000000018970A880
	// [XID] // 0x000000018970A840-0x000000018970A880
	public bool FromJson(JSONNode node) => default; // 0x00000001848C9200-0x00000001848C9580
	// [XID] // 0x0000000189714CF0-0x0000000189714D10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001848C8980-0x00000001848C8BB0
	// [XID] // 0x000000018971C7E0-0x000000018971C800
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7635 */, bool useObjectPool = false /* Metadata: 0x00AF7639 */) => default; // 0x00000001848C9730-0x00000001848C9A30
	// [XID] // 0x0000000189723BF0-0x0000000189723C10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF763A */, bool useObjectPool = false /* Metadata: 0x00AF763E */) => default; // 0x00000001848C8FF0-0x00000001848C9200
	[BlackList] // 0x000000018972B2D0-0x000000018972B310
	// [XID] // 0x000000018972B2D0-0x000000018972B310
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001848C8BB0-0x00000001848C8E80
	// [XID] // 0x0000000189735B00-0x0000000189735B20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001848C9B10-0x00000001848C9CC0
	[BlackList] // 0x000000018973D650-0x000000018973D690
	// [XID] // 0x000000018973D650-0x000000018973D690
	public virtual void AutoAllocTypeFields() {} // 0x00000001848C8E80-0x00000001848C8F20
	[BlackList] // 0x0000000189747D20-0x0000000189747D60
	// [XID] // 0x0000000189747D20-0x0000000189747D60
	public virtual void AutoRecycleTypeFields() {} // 0x00000001848C8F20-0x00000001848C8FF0
	[BlackList] // 0x00000001897521D0-0x0000000189752210
	// [XID] // 0x00000001897521D0-0x0000000189752210
	public virtual void ReturnToObjectPool() {} // 0x00000001848C9EF0-0x00000001848C9F90
	[BlackList] // 0x000000018975C7D0-0x000000018975C810
	// [XID] // 0x000000018975C7D0-0x000000018975C810
	public virtual void OnPoolAllocated() {} // 0x00000001848C9E50-0x00000001848C9EF0
	[BlackList] // 0x0000000189767120-0x0000000189767160
	// [XID] // 0x0000000189767120-0x0000000189767160
	public virtual void OnBeforePoolRecycled() {} // 0x00000001848C9DB0-0x00000001848C9E50
}

