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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ExpeditionPathExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15083
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 difficultyIdRawNum; // 0x14
	protected string _superElement; // 0x18
	protected SimpleSafeUInt32 basicRewardIdRawNum; // 0x20
	protected SimpleSafeUInt32 bonusRewardIdRawNum; // 0x24
	protected uint _pathNameTextMapHash; // 0x28
	protected uint _pathDescTextMapHash; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189983870-0x0000000189983890 */ get => default; /* [XID] */ /* 0x000000018998B0E0-0x000000018998B100 */ protected set {} } // 0x000000018209E6E0-0x000000018209E7B0 0x000000018209DA90-0x000000018209DB70
	public uint difficultyId { /* [XID] */ /* 0x0000000189992BF0-0x0000000189992C10 */ get => default; /* [XID] */ /* 0x000000018999A7D0-0x000000018999A7F0 */ protected set {} } // 0x000000018209E7B0-0x000000018209E880 0x000000018209E880-0x000000018209E960
	public string superElement { /* [XID] */ /* 0x00000001899A1F10-0x00000001899A1F30 */ get => default; /* [XID] */ /* 0x00000001899A97E0-0x00000001899A9800 */ protected set {} } // 0x000000018209D6F0-0x000000018209D790 0x000000018209CC30-0x000000018209CCE0
	public uint basicRewardId { /* [XID] */ /* 0x00000001899B11F0-0x00000001899B1210 */ get => default; /* [XID] */ /* 0x00000001899B8450-0x00000001899B8470 */ protected set {} } // 0x000000018209D840-0x000000018209D910 0x000000018209CCE0-0x000000018209CDC0
	public uint bonusRewardId { /* [XID] */ /* 0x00000001899BFFB0-0x00000001899BFFD0 */ get => default; /* [XID] */ /* 0x00000001899C77B0-0x00000001899C77D0 */ protected set {} } // 0x000000018209E960-0x000000018209EA30 0x000000018209E380-0x000000018209E460
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint pathNameTextMapHash { /* [XID] */ /* 0x00000001899CEEC0-0x00000001899CEEE0 */ get => default; /* [XID] */ /* 0x00000001899D64F0-0x00000001899D6510 */ protected set {} } // 0x000000018209E460-0x000000018209E500 0x000000018209C9D0-0x000000018209CA80
	public string pathName { /* [XID] */ /* 0x00000001899DDA80-0x00000001899DDAA0 */ get => default; } // 0x000000018209E200-0x000000018209E380 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint pathDescTextMapHash { /* [XID] */ /* 0x00000001899E5800-0x00000001899E5820 */ get => default; /* [XID] */ /* 0x00000001899EC950-0x00000001899EC970 */ protected set {} } // 0x000000018209E500-0x000000018209E5A0 0x000000018209D790-0x000000018209D840
	public string pathDesc { /* [XID] */ /* 0x00000001899F4730-0x00000001899F4750 */ get => default; } // 0x000000018209D910-0x000000018209DA90 

	// Constructors
	public ExpeditionPathExcelConfig() {} // 0x000000018209EAD0-0x000000018209EB30

	// Methods
	// [IDTag] // 0x00000001899FBD10-0x00000001899FBD50
	// [XID] // 0x00000001899FBD10-0x00000001899FBD50
	public virtual bool ParseFromLine(string line) => default; // 0x000000018209CDC0-0x000000018209D260
	// [IDTag] // 0x0000000189A06270-0x0000000189A062B0
	// [XID] // 0x0000000189A06270-0x0000000189A062B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018209D260-0x000000018209D6F0
	// [XID] // 0x0000000189A10530-0x0000000189A10550
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0058 */, bool useObjectPool = false /* Metadata: 0x00AF005C */) => default; // 0x000000018209DB70-0x000000018209E200
	[BlackList] // 0x0000000189A17AF0-0x0000000189A17B30
	// [XID] // 0x0000000189A17AF0-0x0000000189A17B30
	public virtual void AutoAllocTypeFields() {} // 0x000000018209CA80-0x000000018209CB20
	[BlackList] // 0x0000000189A22210-0x0000000189A22250
	// [XID] // 0x0000000189A22210-0x0000000189A22250
	public virtual void AutoRecycleTypeFields() {} // 0x000000018209CB20-0x000000018209CC30
	[BlackList] // 0x0000000189A2C490-0x0000000189A2C4D0
	// [XID] // 0x0000000189A2C490-0x0000000189A2C4D0
	public virtual void ReturnToObjectPool() {} // 0x000000018209EA30-0x000000018209EAD0
	[BlackList] // 0x0000000189A36F30-0x0000000189A36F70
	// [XID] // 0x0000000189A36F30-0x0000000189A36F70
	public virtual void OnPoolAllocated() {} // 0x000000018209E640-0x000000018209E6E0
	[BlackList] // 0x0000000189A41530-0x0000000189A41570
	// [XID] // 0x0000000189A41530-0x0000000189A41570
	public virtual void OnBeforePoolRecycled() {} // 0x000000018209E5A0-0x000000018209E640
}

