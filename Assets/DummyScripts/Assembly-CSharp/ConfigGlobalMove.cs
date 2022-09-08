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
public class ConfigGlobalMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18100
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveSyncInterval _syncInterval; // 0x10
	private bool _noGroundStayInPlace; // 0x18

	// Properties
	public ConfigMoveSyncInterval syncInterval { /* [XID] */ /* 0x0000000189927E10-0x0000000189927E30 */ get => default; /* [XID] */ /* 0x000000018992F500-0x000000018992F520 */ private set {} } // 0x00000001829CDD80-0x00000001829CDE20 0x00000001829CD220-0x00000001829CD2D0
	public bool noGroundStayInPlace { /* [XID] */ /* 0x00000001896F01D0-0x00000001896F01F0 */ get => default; /* [XID] */ /* 0x000000018993E4D0-0x000000018993E4F0 */ private set {} } // 0x00000001829CD910-0x00000001829CD9B0 0x00000001829CCCD0-0x00000001829CCD80

	// Constructors
	public ConfigGlobalMove() {} // 0x00000001829CE370-0x00000001829CE3E0

	// Methods
	// [XID] // 0x0000000189945BA0-0x0000000189945BC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829CE080-0x00000001829CE190
	// [XID] // 0x000000018994CFD0-0x000000018994CFF0
	public void InitEmpty() {} // 0x00000001829CD9B0-0x00000001829CDA80
	[BlackList] // 0x0000000189954720-0x0000000189954760
	// [XID] // 0x0000000189954720-0x0000000189954760
	public bool FromJson(JSONNode node) => default; // 0x00000001829CD590-0x00000001829CD910
	// [XID] // 0x000000018995F190-0x000000018995F1B0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001829CCA10-0x00000001829CCCD0
	// [XID] // 0x0000000189966A30-0x0000000189966A50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AFF */, bool useObjectPool = false /* Metadata: 0x00AF8B03 */) => default; // 0x00000001829CDA80-0x00000001829CDD80
	// [XID] // 0x000000018996DE40-0x000000018996DE60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B04 */, bool useObjectPool = false /* Metadata: 0x00AF8B08 */) => default; // 0x00000001829CD2D0-0x00000001829CD590
	[BlackList] // 0x0000000189975990-0x00000001899759D0
	// [XID] // 0x0000000189975990-0x00000001899759D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001829CCD80-0x00000001829CD050
	// [XID] // 0x0000000189980060-0x0000000189980080
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829CDE20-0x00000001829CE080
	[BlackList] // 0x00000001899877F0-0x0000000189987830
	// [XID] // 0x00000001899877F0-0x0000000189987830
	public virtual void AutoAllocTypeFields() {} // 0x00000001829CD050-0x00000001829CD0F0
	[BlackList] // 0x0000000189992510-0x0000000189992550
	// [XID] // 0x0000000189992510-0x0000000189992550
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829CD0F0-0x00000001829CD220
	[BlackList] // 0x000000018999D090-0x000000018999D0D0
	// [XID] // 0x000000018999D090-0x000000018999D0D0
	public virtual void ReturnToObjectPool() {} // 0x00000001829CE2D0-0x00000001829CE370
	[BlackList] // 0x00000001899A7B80-0x00000001899A7BC0
	// [XID] // 0x00000001899A7B80-0x00000001899A7BC0
	public virtual void OnPoolAllocated() {} // 0x00000001829CE230-0x00000001829CE2D0
	[BlackList] // 0x00000001899B2470-0x00000001899B24B0
	// [XID] // 0x00000001899B2470-0x00000001899B24B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829CE190-0x00000001829CE230
}

