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
public class ConfigLogoPageSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18515
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLogoPage _defaultConfig; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigLogoPage> _logoConfigMap; // 0x18
	private string _logoFolderPath; // 0x20
	private string _tipImgAWFolderPath; // 0x28

	// Properties
	public ConfigLogoPage defaultConfig { /* [XID] */ /* 0x0000000189A849C0-0x0000000189A849E0 */ get => default; /* [XID] */ /* 0x0000000189A8C290-0x0000000189A8C2B0 */ private set {} } // 0x00000001847842B0-0x0000000184784350 0x00000001847833B0-0x0000000184783460
	public Dictionary<string, ConfigLogoPage> logoConfigMap { /* [XID] */ /* 0x0000000189A93750-0x0000000189A93770 */ get => default; /* [XID] */ /* 0x0000000189A9B360-0x0000000189A9B380 */ private set {} } // 0x0000000184784210-0x00000001847842B0 0x00000001847843F0-0x00000001847844A0
	public string logoFolderPath { /* [XID] */ /* 0x0000000189AA2620-0x0000000189AA2640 */ get => default; /* [XID] */ /* 0x0000000189AA9BA0-0x0000000189AA9BC0 */ private set {} } // 0x0000000184784350-0x00000001847843F0 0x0000000184783460-0x0000000184783510
	public string tipImgAWFolderPath { /* [XID] */ /* 0x0000000189AB1B00-0x0000000189AB1B20 */ get => default; /* [XID] */ /* 0x0000000189AB8DF0-0x0000000189AB8E10 */ private set {} } // 0x0000000184783D70-0x0000000184783E10 0x0000000184783CC0-0x0000000184783D70

	// Constructors
	public ConfigLogoPageSetting() {} // 0x0000000184784B80-0x0000000184784BE0

	// Methods
	// [XID] // 0x0000000189AC08F0-0x0000000189AC0910
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184784840-0x00000001847849A0
	// [XID] // 0x0000000189AC8310-0x0000000189AC8330
	public void InitEmpty() {} // 0x0000000184783E10-0x0000000184783F10
	[BlackList] // 0x0000000189ACFA90-0x0000000189ACFAD0
	// [XID] // 0x0000000189ACFA90-0x0000000189ACFAD0
	public bool FromJson(JSONNode node) => default; // 0x0000000184783940-0x0000000184783CC0
	// [XID] // 0x0000000189ADA800-0x0000000189ADA820
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184782A70-0x0000000184782F00
	// [XID] // 0x0000000189AE2020-0x0000000189AE2040
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA00B */, bool useObjectPool = false /* Metadata: 0x00AFA00F */) => default; // 0x0000000184783F10-0x0000000184784210
	// [XID] // 0x0000000189AE9890-0x0000000189AE98B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA010 */, bool useObjectPool = false /* Metadata: 0x00AFA014 */) => default; // 0x0000000184783510-0x0000000184783940
	[BlackList] // 0x0000000189AF1630-0x0000000189AF1670
	// [XID] // 0x0000000189AF1630-0x0000000189AF1670
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184782F00-0x00000001847831D0
	// [XID] // 0x0000000189AFBB40-0x0000000189AFBB60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847844A0-0x0000000184784840
	[BlackList] // 0x0000000189B03230-0x0000000189B03270
	// [XID] // 0x0000000189B03230-0x0000000189B03270
	public virtual void AutoAllocTypeFields() {} // 0x00000001847831D0-0x0000000184783270
	[BlackList] // 0x0000000189B0D970-0x0000000189B0D9B0
	// [XID] // 0x0000000189B0D970-0x0000000189B0D9B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184783270-0x00000001847833B0
	[BlackList] // 0x0000000189B17B00-0x0000000189B17B40
	// [XID] // 0x0000000189B17B00-0x0000000189B17B40
	public virtual void ReturnToObjectPool() {} // 0x0000000184784AE0-0x0000000184784B80
	[BlackList] // 0x0000000189B222D0-0x0000000189B22310
	// [XID] // 0x0000000189B222D0-0x0000000189B22310
	public virtual void OnPoolAllocated() {} // 0x0000000184784A40-0x0000000184784AE0
	[BlackList] // 0x0000000189B2C7F0-0x0000000189B2C830
	// [XID] // 0x0000000189B2C7F0-0x0000000189B2C830
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847849A0-0x0000000184784A40
}

