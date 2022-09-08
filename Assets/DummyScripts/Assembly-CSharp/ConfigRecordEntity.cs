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
public class ConfigRecordEntity : ConfigRecordActorBase, IAutoAllocRecycle // TypeDefIndex: 18882
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordAnimatorInfo _animatorInfo; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordRendererParameters _rendererParams; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordMaterialParameters _materialParams; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordRagdollParameters _ragdollParams; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigRecordEmoParameters _emoParams; // 0x58

	// Properties
	public ConfigRecordAnimatorInfo animatorInfo { /* [XID] */ /* 0x00000001897E4350-0x00000001897E4370 */ get => default; /* [XID] */ /* 0x00000001897EBE40-0x00000001897EBE60 */ private set {} } // 0x0000000183BCDAF0-0x0000000183BCDB90 0x0000000183BCD450-0x0000000183BCD500
	public ConfigRecordRendererParameters rendererParams { /* [XID] */ /* 0x00000001897F3790-0x00000001897F37B0 */ get => default; /* [XID] */ /* 0x00000001897FB150-0x00000001897FB170 */ private set {} } // 0x0000000183BCC930-0x0000000183BCC9D0 0x0000000183BCD340-0x0000000183BCD3F0
	public ConfigRecordMaterialParameters materialParams { /* [XID] */ /* 0x0000000189802560-0x0000000189802580 */ get => default; /* [XID] */ /* 0x0000000189809A50-0x0000000189809A70 */ private set {} } // 0x0000000183BCD750-0x0000000183BCD7F0 0x0000000183BCC330-0x0000000183BCC3E0
	public ConfigRecordRagdollParameters ragdollParams { /* [XID] */ /* 0x0000000189811200-0x0000000189811220 */ get => default; /* [XID] */ /* 0x0000000189818CD0-0x0000000189818CF0 */ private set {} } // 0x0000000183BCC890-0x0000000183BCC930 0x0000000183BCD9A0-0x0000000183BCDA50
	public ConfigRecordEmoParameters emoParams { /* [XID] */ /* 0x0000000189820590-0x00000001898205B0 */ get => default; /* [XID] */ /* 0x0000000189827BE0-0x0000000189827C00 */ private set {} } // 0x0000000183BCDA50-0x0000000183BCDAF0 0x0000000183BCC460-0x0000000183BCC510

	// Constructors
	public ConfigRecordEntity() {} // 0x0000000183BCE290-0x0000000183BCE2F0

	// Methods
	// [XID] // 0x000000018982EEA0-0x000000018982EEC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183BCE050-0x0000000183BCE1F0
	// [XID] // 0x0000000189836770-0x0000000189836790
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183BCD850-0x0000000183BCD9A0
	// [XID] // 0x000000018983DB40-0x000000018983DB60
	public override ConfigRecordActorBase Clone(bool useObjectPool = false /* Metadata: 0x00AFB251 */) => default; // 0x0000000183BCD260-0x0000000183BCD340
	// [XID] // 0x0000000189845350-0x0000000189845370
	public override int GetHashNum() => default; // 0x0000000183BCBB20-0x0000000183BCBBF0
	// [XID] // 0x000000018984C820-0x000000018984C840
	public override void InitEmpty() {} // 0x0000000183BCCC60-0x0000000183BCCD90
	[BlackList] // 0x0000000189853940-0x0000000189853980
	// [XID] // 0x0000000189853940-0x0000000189853980
	public override bool FromJson(JSONNode node) => default; // 0x0000000183BCC510-0x0000000183BCC890
	// [XID] // 0x000000018985DB70-0x000000018985DB90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183BCAD90-0x0000000183BCB3A0
	[BlackList] // 0x0000000189865630-0x0000000189865670
	// [XID] // 0x0000000189865630-0x0000000189865670
	public static new ConfigRecordEntity ParseFromJson(JSONNode node) => default; // 0x0000000183BCD500-0x0000000183BCD750
	// [XID] // 0x000000018986FA20-0x000000018986FA40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB252 */, bool useObjectPool = false /* Metadata: 0x00AFB256 */) => default; // 0x0000000183BCCF60-0x0000000183BCD260
	// [XID] // 0x0000000189877110-0x0000000189877130
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB257 */, bool useObjectPool = false /* Metadata: 0x00AFB25B */) => default; // 0x0000000183BCBCD0-0x0000000183BCC2B0
	// [XID] // 0x000000018987EB20-0x000000018987EB40
	public static new ConfigRecordEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB25C */, bool useObjectPool = false /* Metadata: 0x00AFB260 */) => default; // 0x0000000183BCC9D0-0x0000000183BCCBF0
	[BlackList] // 0x0000000189886020-0x0000000189886060
	// [XID] // 0x0000000189886020-0x0000000189886060
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183BCB3A0-0x0000000183BCB670
	// [XID] // 0x0000000189890140-0x0000000189890160
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183BCDB90-0x0000000183BCE050
	[BlackList] // 0x00000001898976A0-0x00000001898976E0
	// [XID] // 0x00000001898976A0-0x00000001898976E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183BCCE70-0x0000000183BCCF60
	[BlackList] // 0x00000001898A1C80-0x00000001898A1CC0
	// [XID] // 0x00000001898A1C80-0x00000001898A1CC0
	public override void AutoAllocTypeFields() {} // 0x0000000183BCB670-0x0000000183BCB710
	[BlackList] // 0x00000001898AC300-0x00000001898AC340
	// [XID] // 0x00000001898AC300-0x00000001898AC340
	public override void AutoRecycleTypeFields() {} // 0x0000000183BCB710-0x0000000183BCBA00
	[BlackList] // 0x00000001898B6A90-0x00000001898B6AD0
	// [XID] // 0x00000001898B6A90-0x00000001898B6AD0
	public override void ReturnToObjectPool() {} // 0x0000000183BCE1F0-0x0000000183BCE290
}

