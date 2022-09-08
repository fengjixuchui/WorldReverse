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
public class ConfigCrowdGroupInfos : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17772
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdGroupInfo[] _crowdGroupInfos; // 0x10

	// Properties
	public ConfigCrowdGroupInfo[] crowdGroupInfos { /* [XID] */ /* 0x0000000189AFA660-0x0000000189AFA680 */ get => default; /* [XID] */ /* 0x0000000189B01BB0-0x0000000189B01BD0 */ private set {} } // 0x0000000184D1E710-0x0000000184D1E7B0 0x0000000184D1DF50-0x0000000184D1E000

	// Constructors
	public ConfigCrowdGroupInfos() {} // 0x0000000184D1E850-0x0000000184D1E8B0

	// Methods
	// [XID] // 0x0000000189B09190-0x0000000189B091B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D1E4F0-0x0000000184D1E5D0
	// [XID] // 0x0000000189B10B90-0x0000000189B10BB0
	public void InitEmpty() {} // 0x0000000184D1DE80-0x0000000184D1DF50
	[BlackList] // 0x0000000189B17D40-0x0000000189B17D80
	// [XID] // 0x0000000189B17D40-0x0000000189B17D80
	public bool FromJson(JSONNode node) => default; // 0x0000000184D1DB00-0x0000000184D1DE80
	// [XID] // 0x0000000189B22490-0x0000000189B224B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184D1D300-0x0000000184D1D4E0
	// [XID] // 0x0000000189B29980-0x0000000189B299A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BA5 */, bool useObjectPool = false /* Metadata: 0x00AF7BA9 */) => default; // 0x0000000184D1E000-0x0000000184D1E300
	// [XID] // 0x0000000189B30FD0-0x0000000189B30FF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BAA */, bool useObjectPool = false /* Metadata: 0x00AF7BAE */) => default; // 0x0000000184D1D8F0-0x0000000184D1DB00
	[BlackList] // 0x0000000189B38610-0x0000000189B38650
	// [XID] // 0x0000000189B38610-0x0000000189B38650
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D1D4E0-0x0000000184D1D7B0
	// [XID] // 0x0000000189B430B0-0x0000000189B430D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D1E300-0x0000000184D1E4F0
	[BlackList] // 0x0000000189B4A8B0-0x0000000189B4A8F0
	// [XID] // 0x0000000189B4A8B0-0x0000000189B4A8F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D1D7B0-0x0000000184D1D850
	[BlackList] // 0x0000000189B54FF0-0x0000000189B55030
	// [XID] // 0x0000000189B54FF0-0x0000000189B55030
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D1D850-0x0000000184D1D8F0
	[BlackList] // 0x0000000189B5FBE0-0x0000000189B5FC20
	// [XID] // 0x0000000189B5FBE0-0x0000000189B5FC20
	public virtual void ReturnToObjectPool() {} // 0x0000000184D1E7B0-0x0000000184D1E850
	[BlackList] // 0x0000000189B6A190-0x0000000189B6A1D0
	// [XID] // 0x0000000189B6A190-0x0000000189B6A1D0
	public virtual void OnPoolAllocated() {} // 0x0000000184D1E670-0x0000000184D1E710
	[BlackList] // 0x0000000189B745B0-0x0000000189B745F0
	// [XID] // 0x0000000189B745B0-0x0000000189B745F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D1E5D0-0x0000000184D1E670
}

