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
public class ConfigMarkGlobal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18568
{
	// Fields
	private Dictionary<MarkType, ConfigMark> _markConfig; // 0x10
	private Dictionary<MarkIconType, ConfigMarkIcon> _markIconConfig; // 0x18
	private MarkIconType[] _pinMarkIcons; // 0x20
	private MarkIconType[] _customMarkIcons; // 0x28
	private Dictionary<SceneBuildingType, MarkIconType> _sceneBuildingMarks; // 0x30
	private Dictionary<MarkOrder, SimpleSafeInt32> _markOrderToLayerMap; // 0x38

	// Properties
	public Dictionary<MarkType, ConfigMark> markConfig { /* [XID] */ /* 0x00000001899B9710-0x00000001899B9730 */ get => default; /* [XID] */ /* 0x00000001899C11B0-0x00000001899C11D0 */ private set {} } // 0x0000000183277C30-0x0000000183277CD0 0x0000000183277740-0x00000001832777F0
	public Dictionary<MarkIconType, ConfigMarkIcon> markIconConfig { /* [XID] */ /* 0x00000001899C87A0-0x00000001899C87C0 */ get => default; /* [XID] */ /* 0x00000001899D01B0-0x00000001899D01D0 */ private set {} } // 0x00000001832777F0-0x0000000183277890 0x0000000183278240-0x00000001832782F0
	public MarkIconType[] pinMarkIcons { /* [XID] */ /* 0x00000001899D7610-0x00000001899D7630 */ get => default; /* [XID] */ /* 0x00000001899DEA70-0x00000001899DEA90 */ private set {} } // 0x0000000183276B50-0x0000000183276BF0 0x0000000183276BF0-0x0000000183276CA0
	public MarkIconType[] customMarkIcons { /* [XID] */ /* 0x00000001899E66D0-0x00000001899E66F0 */ get => default; /* [XID] */ /* 0x00000001899EDD20-0x00000001899EDD40 */ private set {} } // 0x00000001832785A0-0x0000000183278640 0x0000000183275EE0-0x0000000183275F90
	public Dictionary<SceneBuildingType, MarkIconType> sceneBuildingMarks { /* [XID] */ /* 0x00000001898C6680-0x00000001898C66A0 */ get => default; /* [XID] */ /* 0x00000001899FCCD0-0x00000001899FCCF0 */ private set {} } // 0x0000000183277570-0x0000000183277610 0x00000001832768A0-0x0000000183276950
	public Dictionary<MarkOrder, SimpleSafeInt32> markOrderToLayerMap { /* [XID] */ /* 0x0000000189A04110-0x0000000189A04130 */ get => default; /* [XID] */ /* 0x0000000189A0B850-0x0000000189A0B870 */ private set {} } // 0x0000000183277B90-0x0000000183277C30 0x0000000183276AA0-0x0000000183276B50

	// Constructors
	public ConfigMarkGlobal() {} // 0x00000001832786E0-0x0000000183278740

	// Methods
	// [XID] // 0x0000000189A13040-0x0000000189A13060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832782F0-0x0000000183278460
	// [XID] // 0x0000000189A1A370-0x0000000189A1A390
	public void InitEmpty() {} // 0x0000000183277610-0x0000000183277740
	[BlackList] // 0x0000000189A219F0-0x0000000189A21A30
	// [XID] // 0x0000000189A219F0-0x0000000189A21A30
	public bool FromJson(JSONNode node) => default; // 0x00000001832771F0-0x0000000183277570
	// [XID] // 0x0000000189A2BE30-0x0000000189A2BE50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183275F90-0x00000001832765D0
	// [XID] // 0x0000000189A33480-0x0000000189A334A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA435 */, bool useObjectPool = false /* Metadata: 0x00AFA439 */) => default; // 0x0000000183277890-0x0000000183277B90
	// [XID] // 0x0000000189A3AD00-0x0000000189A3AD20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA43A */, bool useObjectPool = false /* Metadata: 0x00AFA43E */) => default; // 0x0000000183276CA0-0x00000001832771F0
	[BlackList] // 0x0000000189A42550-0x0000000189A42590
	// [XID] // 0x0000000189A42550-0x0000000189A42590
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832765D0-0x00000001832768A0
	// [XID] // 0x0000000189A4CBA0-0x0000000189A4CBC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183277CD0-0x0000000183278240
	[BlackList] // 0x0000000189A54410-0x0000000189A54450
	// [XID] // 0x0000000189A54410-0x0000000189A54450
	public virtual void AutoAllocTypeFields() {} // 0x0000000183276950-0x00000001832769F0
	[BlackList] // 0x0000000189A5EE70-0x0000000189A5EEB0
	// [XID] // 0x0000000189A5EE70-0x0000000189A5EEB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832769F0-0x0000000183276AA0
	[BlackList] // 0x0000000189A69B70-0x0000000189A69BB0
	// [XID] // 0x0000000189A69B70-0x0000000189A69BB0
	public virtual void ReturnToObjectPool() {} // 0x0000000183278640-0x00000001832786E0
	[BlackList] // 0x0000000189A73EF0-0x0000000189A73F30
	// [XID] // 0x0000000189A73EF0-0x0000000189A73F30
	public virtual void OnPoolAllocated() {} // 0x0000000183278500-0x00000001832785A0
	[BlackList] // 0x0000000189A7E8B0-0x0000000189A7E8F0
	// [XID] // 0x0000000189A7E8B0-0x0000000189A7E8F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183278460-0x0000000183278500
}

