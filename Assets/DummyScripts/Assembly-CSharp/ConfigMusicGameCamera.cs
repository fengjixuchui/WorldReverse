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
public class ConfigMusicGameCamera : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18779
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMusicCamera[] _cameraConfigList; // 0x10

	// Properties
	public ConfigMusicCamera[] cameraConfigList { /* [XID] */ /* 0x0000000189B08FB0-0x0000000189B08FD0 */ get => default; /* [XID] */ /* 0x0000000189B109F0-0x0000000189B10A10 */ private set {} } // 0x0000000182AD62D0-0x0000000182AD6370 0x0000000182AD5DD0-0x0000000182AD5E80

	// Constructors
	public ConfigMusicGameCamera() {} // 0x0000000182AD6B20-0x0000000182AD6B80

	// Methods
	// [XID] // 0x0000000189B17AC0-0x0000000189B17AE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AD6860-0x0000000182AD6940
	// [XID] // 0x0000000189B1F460-0x0000000189B1F480
	public void InitEmpty() {} // 0x0000000182AD6200-0x0000000182AD62D0
	[BlackList] // 0x0000000189B26CA0-0x0000000189B26CE0
	// [XID] // 0x0000000189B26CA0-0x0000000189B26CE0
	public bool FromJson(JSONNode node) => default; // 0x0000000182AD5E80-0x0000000182AD6200
	// [XID] // 0x0000000189B30DF0-0x0000000189B30E10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AD55D0-0x0000000182AD57B0
	// [XID] // 0x0000000189B384B0-0x0000000189B384D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABFD */, bool useObjectPool = false /* Metadata: 0x00AFAC01 */) => default; // 0x0000000182AD6370-0x0000000182AD6670
	// [XID] // 0x0000000189B3FF00-0x0000000189B3FF20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAC02 */, bool useObjectPool = false /* Metadata: 0x00AFAC06 */) => default; // 0x0000000182AD5BC0-0x0000000182AD5DD0
	[BlackList] // 0x0000000189B47720-0x0000000189B47760
	// [XID] // 0x0000000189B47720-0x0000000189B47760
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AD57B0-0x0000000182AD5A80
	// [XID] // 0x0000000189B51FA0-0x0000000189B51FC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AD6670-0x0000000182AD6860
	[BlackList] // 0x0000000189B597E0-0x0000000189B59820
	// [XID] // 0x0000000189B597E0-0x0000000189B59820
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AD5A80-0x0000000182AD5B20
	[BlackList] // 0x0000000189B63EB0-0x0000000189B63EF0
	// [XID] // 0x0000000189B63EB0-0x0000000189B63EF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AD5B20-0x0000000182AD5BC0
	[BlackList] // 0x0000000189B6E3E0-0x0000000189B6E420
	// [XID] // 0x0000000189B6E3E0-0x0000000189B6E420
	public virtual void ReturnToObjectPool() {} // 0x0000000182AD6A80-0x0000000182AD6B20
	[BlackList] // 0x0000000189B78C00-0x0000000189B78C40
	// [XID] // 0x0000000189B78C00-0x0000000189B78C40
	public virtual void OnPoolAllocated() {} // 0x0000000182AD69E0-0x0000000182AD6A80
	[BlackList] // 0x0000000189B832E0-0x0000000189B83320
	// [XID] // 0x0000000189B832E0-0x0000000189B83320
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AD6940-0x0000000182AD69E0
}

