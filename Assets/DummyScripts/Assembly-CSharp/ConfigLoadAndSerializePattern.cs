/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConfigLoadAndSerializePattern : ISimplePoolObject, AsyncJobProxy // TypeDefIndex: 26581
{
	// Fields
	private const int MAX_PATTERN_NUM = 50000; // Metadata: 0x00B0C58A
	private static int _currPatternId; // 0x00
	private static SimpleObjectPool<ConfigLoadAndSerializePattern> _pool; // 0x08
	private List<ulong> _paths; // 0x10
	private int _index; // 0x18
	private SerializationUtils.PackedBinCategory _category; // 0x1C
	private Action _onFinished; // 0x20
	private List<uint> _dataHandlers; // 0x28
	private int _cnt; // 0x30
	private SerializeJsonHandler _onJsonSerialize; // 0x40
	private bool _isAbort; // 0x50
	private int _serializeCnt; // 0x54
	private bool _loadFromBin; // 0x58

	// Properties
	public static int currPatternId { /* [XID] */ /* 0x0000000189B64D20-0x0000000189B64D40 */ get => default; } // 0x000000018351A6B0-0x000000018351A7C0 
	public List<ulong> paths { /* [XID] */ /* 0x0000000189988E20-0x0000000189988E40 */ get => default; } // 0x000000018351A130-0x000000018351A1D0 
	public int index { /* [XID] */ /* 0x00000001899906D0-0x00000001899906F0 */ get => default; } // 0x000000018351A610-0x000000018351A6B0 
	public SerializationUtils.PackedBinCategory category { /* [XID] */ /* 0x0000000189998190-0x00000001899981B0 */ get => default; } // 0x000000018351A090-0x000000018351A130 
	public SerializeBinHandler _onBinSerialize { /* [XID] */ /* 0x000000018999F910-0x000000018999F950 */ get; /* [XID] */ /* 0x00000001899AA4B0-0x00000001899AA4F0 */ private set; } // 0x0000000183519990-0x00000001835199F0 0x000000018351A4C0-0x000000018351A520
	public Action<object, ulong> _onReaded { /* [XID] */ /* 0x00000001899B4D30-0x00000001899B4D70 */ get; /* [XID] */ /* 0x00000001899BF520-0x00000001899BF560 */ private set; } // 0x000000018351A8A0-0x000000018351A900 0x000000018351A1D0-0x000000018351A230
	public bool loadFromBin { /* [XID] */ /* 0x00000001899C9B40-0x00000001899C9B60 */ get => default; } // 0x000000018351A900-0x000000018351A9A0 
	public bool isAbort { /* [XID] */ /* 0x00000001899D1430-0x00000001899D1450 */ get => default; } // 0x00000001835198F0-0x0000000183519990 

	// Constructors
	public ConfigLoadAndSerializePattern() {} // 0x000000018351AF30-0x000000018351B010
	static ConfigLoadAndSerializePattern() {} // 0x000000018351AEA0-0x000000018351AF30

	// Methods
	// [XID] // 0x0000000189979E80-0x0000000189979EA0
	public static ConfigLoadAndSerializePattern Get(int patternId, Action onFinished, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded, SerializationUtils.PackedBinCategory category = SerializationUtils.PackedBinCategory.NONEXCEL /* Metadata: 0x00B0C581 */) => default; // 0x000000018351A330-0x000000018351A4C0
	// [XID] // 0x00000001899815F0-0x0000000189981610
	public static void Relese(ConfigLoadAndSerializePattern pattern) {} // 0x00000001835199F0-0x0000000183519AE0
	// [XID] // 0x00000001899D8880-0x00000001899D88A0
	public bool CheckVoucher(object voucher) => default; // 0x0000000183519AE0-0x0000000183519BF0
	// [XID] // 0x0000000189A8FF90-0x0000000189A8FFB0
	public void Init(int index, Action onFinished, SerializeBinHandler onBinSerialize, SerializeJsonHandler onJsonSerialize, Action<object, ulong> onReaded, SerializationUtils.PackedBinCategory category = SerializationUtils.PackedBinCategory.NONEXCEL /* Metadata: 0x00B0C585 */) {} // 0x0000000183519E90-0x000000018351A090
	// [IDTag] // 0x00000001899E7B00-0x00000001899E7B40
	// [XID] // 0x00000001899E7B00-0x00000001899E7B40
	public ConfigSerializePattern CreateSerializePattern(ulong path, ByteArray byteArray) => default; // 0x000000018351AB60-0x000000018351AD20
	// [IDTag] // 0x00000001899F2180-0x00000001899F21C0
	// [XID] // 0x00000001899F2180-0x00000001899F21C0
	public ConfigSerializePattern CreateSerializePattern(ulong path, JSONNode node) => default; // 0x000000018351A9A0-0x000000018351AB60
	// [XID] // 0x0000000189A9EAB0-0x0000000189A9EAD0
	public void AddPath(ulong path) {} // 0x000000018351A230-0x000000018351A330
	// [XID] // 0x0000000189A03D80-0x0000000189A03DA0
	public bool FinishLoad(uint dataHandle, bool forceFinish = false /* Metadata: 0x00B0C589 */) => default; // 0x0000000183519D00-0x0000000183519E90
	// [XID] // 0x0000000189A0B2B0-0x0000000189A0B2D0
	public bool FinishSerialize() => default; // 0x000000018351A520-0x000000018351A610
	// [XID] // 0x0000000189A12BC0-0x0000000189A12BE0
	public void ResetObject() {} // 0x000000018351AD20-0x000000018351AEA0
	// [XID] // 0x0000000189A19EF0-0x0000000189A19F10
	public void Abort() {} // 0x000000018351A7C0-0x000000018351A8A0
	// [XID] // 0x0000000189A21460-0x0000000189A21480
	public void Dismiss(object voucher) {} // 0x0000000183519BF0-0x0000000183519D00
}

