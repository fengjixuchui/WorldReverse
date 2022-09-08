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
public class MapTagDataConfig : IAutoAllocRecycle // TypeDefIndex: 16307
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected MapTagType _type; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected string _icon; // 0x20
	protected bool _unlockByDefault; // 0x28
	protected bool _hideBeforeUnlock; // 0x29
	protected SimpleSafeUInt32[] _sceneIdList; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018969DB10-0x000000018969DB30 */ get => default; /* [XID] */ /* 0x00000001896A4B80-0x00000001896A4BA0 */ protected set {} } // 0x00000001839D1D90-0x00000001839D1E60 0x00000001839D1170-0x00000001839D1250
	public MapTagType type { /* [XID] */ /* 0x00000001896AC3B0-0x00000001896AC3D0 */ get => default; /* [XID] */ /* 0x00000001896B3690-0x00000001896B36B0 */ protected set {} } // 0x00000001839D1E60-0x00000001839D1F00 0x00000001839D1B00-0x00000001839D1BB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001896BAE10-0x00000001896BAE30 */ get => default; /* [XID] */ /* 0x00000001896C1F40-0x00000001896C1F60 */ protected set {} } // 0x00000001839D01D0-0x00000001839D0270 0x00000001839D19A0-0x00000001839D1A50
	public string name { /* [XID] */ /* 0x00000001896C9530-0x00000001896C9550 */ get => default; } // 0x00000001839D1F00-0x00000001839D2080 
	public string icon { /* [XID] */ /* 0x00000001896D0D00-0x00000001896D0D20 */ get => default; /* [XID] */ /* 0x00000001896D82F0-0x00000001896D8310 */ protected set {} } // 0x00000001839CFF10-0x00000001839CFFB0 0x00000001839D1A50-0x00000001839D1B00
	public bool unlockByDefault { /* [XID] */ /* 0x00000001896DFC80-0x00000001896DFCA0 */ get => default; /* [XID] */ /* 0x00000001896E7020-0x00000001896E7040 */ protected set {} } // 0x00000001839CFFB0-0x00000001839D0050 0x00000001839D10C0-0x00000001839D1170
	public bool hideBeforeUnlock { /* [XID] */ /* 0x00000001896EE5D0-0x00000001896EE5F0 */ get => default; /* [XID] */ /* 0x00000001896F5EE0-0x00000001896F5F00 */ protected set {} } // 0x00000001839D0320-0x00000001839D03C0 0x00000001839D18F0-0x00000001839D19A0
	public SimpleSafeUInt32[] sceneIdList { /* [XID] */ /* 0x00000001896FD6B0-0x00000001896FD6D0 */ get => default; /* [XID] */ /* 0x0000000189704B50-0x0000000189704B70 */ protected set {} } // 0x00000001839D1BB0-0x00000001839D1C50 0x00000001839D0270-0x00000001839D0320

	// Constructors
	public MapTagDataConfig() {} // 0x00000001839D2120-0x00000001839D2180

	// Methods
	// [IDTag] // 0x000000018970C330-0x000000018970C370
	// [XID] // 0x000000018970C330-0x000000018970C370
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839D0A30-0x00000001839D10C0
	// [IDTag] // 0x00000001897168A0-0x00000001897168E0
	// [XID] // 0x00000001897168A0-0x00000001897168E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839D03C0-0x00000001839D0A30
	// [XID] // 0x0000000189721230-0x0000000189721250
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3729 */, bool useObjectPool = false /* Metadata: 0x00AF372D */) => default; // 0x00000001839D1250-0x00000001839D18F0
	[BlackList] // 0x0000000189728850-0x0000000189728890
	// [XID] // 0x0000000189728850-0x0000000189728890
	public virtual void AutoAllocTypeFields() {} // 0x00000001839D0050-0x00000001839D00F0
	[BlackList] // 0x0000000189732EA0-0x0000000189732EE0
	// [XID] // 0x0000000189732EA0-0x0000000189732EE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839D00F0-0x00000001839D01D0
	[BlackList] // 0x000000018973DAF0-0x000000018973DB30
	// [XID] // 0x000000018973DAF0-0x000000018973DB30
	public virtual void ReturnToObjectPool() {} // 0x00000001839D2080-0x00000001839D2120
	[BlackList] // 0x00000001897480E0-0x0000000189748120
	// [XID] // 0x00000001897480E0-0x0000000189748120
	public virtual void OnPoolAllocated() {} // 0x00000001839D1CF0-0x00000001839D1D90
	[BlackList] // 0x0000000189752490-0x00000001897524D0
	// [XID] // 0x0000000189752490-0x00000001897524D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839D1C50-0x00000001839D1CF0
}

