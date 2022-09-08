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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicMultiValueParameterizedStimulusHandler : ConfigMusicParameterizedStimulusHandler, IAutoAllocRecycle // TypeDefIndex: 18758
{
	// Fields
	protected const int BIN_SEARCH_THRESHOLD = 4; // Metadata: 0x00AFAB3D

	// Properties
	protected bool hasSortedParms { get; /* [XID] */ /* 0x0000000189710870-0x00000001897108B0 */ set; } // 0x0000000182613C60-0x0000000182613CC0 0x00000001826131F0-0x0000000182613250

	// Constructors
	public ConfigMusicMultiValueParameterizedStimulusHandler() {} // 0x0000000182613F00-0x0000000182613F60

	// Methods
	// [XID] // 0x0000000189696010-0x0000000189696030
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182613DB0-0x0000000182613E60
	// [XID] // 0x000000018969D710-0x000000018969D730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182613BB0-0x0000000182613C60
	// [XID] // 0x00000001896A47E0-0x00000001896A4800
	public override ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAB2D */) => default; // 0x00000001826137C0-0x00000001826138A0
	// [XID] // 0x00000001896ABF50-0x00000001896ABF70
	public override int GetHashNum() => default; // 0x0000000182612800-0x00000001826128D0
	// [XID] // 0x00000001896B31B0-0x00000001896B31D0
	public override void InitEmpty() {} // 0x0000000182613250-0x00000001826132F0
	[BlackList] // 0x00000001896BA930-0x00000001896BA970
	// [XID] // 0x00000001896BA930-0x00000001896BA970
	public override bool FromJson(JSONNode node) => default; // 0x0000000182612BE0-0x0000000182612F60
	// [XID] // 0x00000001896C4CD0-0x00000001896C4CF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001826121A0-0x0000000182612290
	[BlackList] // 0x00000001896CC090-0x00000001896CC0D0
	// [XID] // 0x00000001896CC090-0x00000001896CC0D0
	public static new ConfigMusicMultiValueParameterizedStimulusHandler ParseFromJson(JSONNode node) => default; // 0x0000000182613900-0x0000000182613B50
	// [XID] // 0x00000001896D6760-0x00000001896D6780
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB2E */, bool useObjectPool = false /* Metadata: 0x00AFAB32 */) => default; // 0x00000001826134C0-0x00000001826137C0
	// [XID] // 0x00000001896DDDA0-0x00000001896DDDC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB33 */, bool useObjectPool = false /* Metadata: 0x00AFAB37 */) => default; // 0x00000001826129B0-0x0000000182612AE0
	// [XID] // 0x00000001896E53D0-0x00000001896E53F0
	public static new ConfigMusicMultiValueParameterizedStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB38 */, bool useObjectPool = false /* Metadata: 0x00AFAB3C */) => default; // 0x0000000182612F60-0x0000000182613180
	[BlackList] // 0x00000001896EC9C0-0x00000001896ECA00
	// [XID] // 0x00000001896EC9C0-0x00000001896ECA00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182612290-0x0000000182612560
	// [XID] // 0x00000001896F71F0-0x00000001896F7210
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182613CC0-0x0000000182613DB0
	[BlackList] // 0x00000001896FEB70-0x00000001896FEBB0
	// [XID] // 0x00000001896FEB70-0x00000001896FEBB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001826133D0-0x00000001826134C0
	protected bool CheckPresence<T>(IStimulusParameter needle, T[] hay, IComparer<T> comparer) => default;
	protected bool CheckAbsence<T>(IStimulusParameter needle, T[] hay, IComparer<T> comparer) => default;
	[BlackList] // 0x000000018971AF80-0x000000018971AFC0
	// [XID] // 0x000000018971AF80-0x000000018971AFC0
	public override void AutoAllocTypeFields() {} // 0x0000000182612560-0x0000000182612600
	[BlackList] // 0x0000000189725420-0x0000000189725460
	// [XID] // 0x0000000189725420-0x0000000189725460
	public override void AutoRecycleTypeFields() {} // 0x0000000182612600-0x00000001826126E0
	[BlackList] // 0x000000018972FB10-0x000000018972FB50
	// [XID] // 0x000000018972FB10-0x000000018972FB50
	public override void ReturnToObjectPool() {} // 0x0000000182613E60-0x0000000182613F00
}

