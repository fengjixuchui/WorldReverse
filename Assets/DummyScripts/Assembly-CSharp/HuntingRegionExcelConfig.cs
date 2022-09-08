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
public class HuntingRegionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15746
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeFloat[] _centerPosList; // 0x18
	protected SimpleSafeUInt32 centerRadiusRawNum; // 0x20
	protected SimpleSafeUInt32[] _safeClueGroup; // 0x28
	protected SimpleSafeUInt32[] _clueGroup; // 0x30
	protected SimpleSafeUInt32[] _safeDestinationGroup; // 0x38
	protected SimpleSafeUInt32[] _destinationGroup; // 0x40
	protected uint _regionInfoTextMapHash; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189872EF0-0x0000000189872F10 */ get => default; /* [XID] */ /* 0x000000018987AC50-0x000000018987AC70 */ protected set {} } // 0x0000000183FBDDA0-0x0000000183FBDE70 0x0000000183FBD250-0x0000000183FBD330
	public SimpleSafeFloat[] centerPosList { /* [XID] */ /* 0x0000000189881BE0-0x0000000189881C00 */ get => default; /* [XID] */ /* 0x00000001898892E0-0x0000000189889300 */ protected set {} } // 0x0000000183FBDA80-0x0000000183FBDB20 0x0000000183FBCE30-0x0000000183FBCEE0
	public uint centerRadius { /* [XID] */ /* 0x0000000189890740-0x0000000189890760 */ get => default; /* [XID] */ /* 0x0000000189897D20-0x0000000189897D40 */ protected set {} } // 0x0000000183FBD030-0x0000000183FBD100 0x0000000183FBAC90-0x0000000183FBAD70
	public SimpleSafeUInt32[] safeClueGroup { /* [XID] */ /* 0x000000018989F0C0-0x000000018989F0E0 */ get => default; /* [XID] */ /* 0x00000001898A6C20-0x00000001898A6C40 */ protected set {} } // 0x0000000183FBDBC0-0x0000000183FBDC60 0x0000000183FBD100-0x0000000183FBD1B0
	public SimpleSafeUInt32[] clueGroup { /* [XID] */ /* 0x00000001898AE350-0x00000001898AE370 */ get => default; /* [XID] */ /* 0x00000001898B58F0-0x00000001898B5910 */ protected set {} } // 0x0000000183FBD1B0-0x0000000183FBD250 0x0000000183FBB110-0x0000000183FBB1C0
	public SimpleSafeUInt32[] safeDestinationGroup { /* [XID] */ /* 0x00000001898BD380-0x00000001898BD3A0 */ get => default; /* [XID] */ /* 0x00000001898C4AC0-0x00000001898C4AE0 */ protected set {} } // 0x0000000183FBCEE0-0x0000000183FBCF80 0x0000000183FBAFC0-0x0000000183FBB070
	public SimpleSafeUInt32[] destinationGroup { /* [XID] */ /* 0x00000001898CBF50-0x00000001898CBF70 */ get => default; /* [XID] */ /* 0x00000001898D3790-0x00000001898D37B0 */ protected set {} } // 0x0000000183FBB070-0x0000000183FBB110 0x0000000183FBAD70-0x0000000183FBAE20
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint regionInfoTextMapHash { /* [XID] */ /* 0x00000001898DAFE0-0x00000001898DB000 */ get => default; /* [XID] */ /* 0x00000001898E2CC0-0x00000001898E2CE0 */ protected set {} } // 0x0000000183FBDB20-0x0000000183FBDBC0 0x0000000183FBCF80-0x0000000183FBD030
	public string regionInfo { /* [XID] */ /* 0x00000001898EA9F0-0x00000001898EAA10 */ get => default; } // 0x0000000183FBAB10-0x0000000183FBAC90 

	// Constructors
	public HuntingRegionExcelConfig() {} // 0x0000000183FBDF10-0x0000000183FBDF70

	// Methods
	// [IDTag] // 0x00000001898F2130-0x00000001898F2170
	// [XID] // 0x00000001898F2130-0x00000001898F2170
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183FBB1C0-0x0000000183FBBFF0
	// [IDTag] // 0x00000001898FC7D0-0x00000001898FC810
	// [XID] // 0x00000001898FC7D0-0x00000001898FC810
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183FBBFF0-0x0000000183FBCE30
	// [XID] // 0x0000000189907190-0x00000001899071B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF24E5 */, bool useObjectPool = false /* Metadata: 0x00AF24E9 */) => default; // 0x0000000183FBD330-0x0000000183FBDA80
	[BlackList] // 0x000000018990EA90-0x000000018990EAD0
	// [XID] // 0x000000018990EA90-0x000000018990EAD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183FBAE20-0x0000000183FBAEC0
	[BlackList] // 0x00000001899193C0-0x0000000189919400
	// [XID] // 0x00000001899193C0-0x0000000189919400
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183FBAEC0-0x0000000183FBAFC0
	[BlackList] // 0x0000000189923D40-0x0000000189923D80
	// [XID] // 0x0000000189923D40-0x0000000189923D80
	public virtual void ReturnToObjectPool() {} // 0x0000000183FBDE70-0x0000000183FBDF10
	[BlackList] // 0x000000018992E2F0-0x000000018992E330
	// [XID] // 0x000000018992E2F0-0x000000018992E330
	public virtual void OnPoolAllocated() {} // 0x0000000183FBDD00-0x0000000183FBDDA0
	[BlackList] // 0x0000000189938630-0x0000000189938670
	// [XID] // 0x0000000189938630-0x0000000189938670
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183FBDC60-0x0000000183FBDD00
}

