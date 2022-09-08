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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigHomeFurnitureSuite : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18942
{
	// Fields
	private SimpleSafeUInt32 suiteIdRawNum; // 0x10
	private MoleMole.Config.Vector _spawnPos; // 0x14
	private SimpleSafeInt32[] _includedFurnitureIndexList; // 0x20

	// Properties
	public uint suiteId { /* [XID] */ /* 0x00000001899BFA90-0x00000001899BFAB0 */ get => default; /* [XID] */ /* 0x00000001899C7250-0x00000001899C7270 */ private set {} } // 0x00000001839E52B0-0x00000001839E5380 0x00000001839E5FE0-0x00000001839E60C0
	public MoleMole.Config.Vector spawnPos { /* [XID] */ /* 0x00000001899CE7C0-0x00000001899CE7E0 */ get => default; /* [XID] */ /* 0x00000001899D5EB0-0x00000001899D5ED0 */ private set {} } // 0x00000001839E51D0-0x00000001839E52B0 0x00000001839E5F10-0x00000001839E5FE0
	public SimpleSafeInt32[] includedFurnitureIndexList { /* [XID] */ /* 0x00000001899DD340-0x00000001899DD360 */ get => default; /* [XID] */ /* 0x00000001899E4FE0-0x00000001899E5000 */ private set {} } // 0x00000001839E4CE0-0x00000001839E4D80 0x00000001839E5A50-0x00000001839E5B00

	// Constructors
	public ConfigHomeFurnitureSuite() {} // 0x00000001839E6770-0x00000001839E67D0

	// Methods
	// [XID] // 0x00000001899EC390-0x00000001899EC3B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839E6440-0x00000001839E6590
	// [XID] // 0x00000001899F3ED0-0x00000001899F3EF0
	public void InitEmpty() {} // 0x00000001839E5B00-0x00000001839E5C10
	[BlackList] // 0x00000001899FB670-0x00000001899FB6B0
	// [XID] // 0x00000001899FB670-0x00000001899FB6B0
	public bool FromJson(JSONNode node) => default; // 0x00000001839E56D0-0x00000001839E5A50
	// [XID] // 0x0000000189A05C30-0x0000000189A05C50
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839E4900-0x00000001839E4CE0
	// [XID] // 0x0000000189A0CF40-0x0000000189A0CF60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB46D */, bool useObjectPool = false /* Metadata: 0x00AFB471 */) => default; // 0x00000001839E5C10-0x00000001839E5F10
	// [XID] // 0x0000000189A147A0-0x0000000189A147C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB472 */, bool useObjectPool = false /* Metadata: 0x00AFB476 */) => default; // 0x00000001839E5380-0x00000001839E56D0
	[BlackList] // 0x0000000189A1BB30-0x0000000189A1BB70
	// [XID] // 0x0000000189A1BB30-0x0000000189A1BB70
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839E4D80-0x00000001839E5050
	// [XID] // 0x0000000189A26120-0x0000000189A26140
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001839E60C0-0x00000001839E6440
	[BlackList] // 0x0000000189A2D450-0x0000000189A2D490
	// [XID] // 0x0000000189A2D450-0x0000000189A2D490
	public virtual void AutoAllocTypeFields() {} // 0x00000001839E5050-0x00000001839E50F0
	[BlackList] // 0x0000000189A37F30-0x0000000189A37F70
	// [XID] // 0x0000000189A37F30-0x0000000189A37F70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839E50F0-0x00000001839E51D0
	[BlackList] // 0x0000000189A424D0-0x0000000189A42510
	// [XID] // 0x0000000189A424D0-0x0000000189A42510
	public virtual void ReturnToObjectPool() {} // 0x00000001839E66D0-0x00000001839E6770
	[BlackList] // 0x0000000189A4CB40-0x0000000189A4CB80
	// [XID] // 0x0000000189A4CB40-0x0000000189A4CB80
	public virtual void OnPoolAllocated() {} // 0x00000001839E6630-0x00000001839E66D0
	[BlackList] // 0x0000000189A572D0-0x0000000189A57310
	// [XID] // 0x0000000189A572D0-0x0000000189A57310
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839E6590-0x00000001839E6630
}

