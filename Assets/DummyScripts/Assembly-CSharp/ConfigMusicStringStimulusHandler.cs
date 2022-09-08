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
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicStringStimulusHandler : ConfigMusicParameterizedStimulusHandler, IAutoAllocRecycle // TypeDefIndex: 18756
{
	// Fields
	private string _stringParam; // 0x20

	// Properties
	public string stringParam { /* [XID] */ /* 0x0000000189BD3430-0x0000000189BD3450 */ get => default; /* [XID] */ /* 0x0000000189BDAD40-0x0000000189BDAD60 */ private set {} } // 0x000000018210A650-0x000000018210A6F0 0x000000018210BEC0-0x000000018210BF70

	// Constructors
	public ConfigMusicStringStimulusHandler() {} // 0x000000018210C690-0x000000018210C6F0

	// Methods
	// [XID] // 0x00000001895E76F0-0x00000001895E7710
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018210C500-0x000000018210C5F0
	// [XID] // 0x00000001895EF040-0x00000001895EF060
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018210C220-0x000000018210C300
	// [XID] // 0x00000001895F69C0-0x00000001895F69E0
	public override ConfigMusicStimulusHandler Clone(bool useObjectPool = false /* Metadata: 0x00AFAB1D */) => default; // 0x000000018210BD80-0x000000018210BE60
	// [XID] // 0x00000001895FDE20-0x00000001895FDE40
	public override int GetHashNum() => default; // 0x000000018210AC30-0x000000018210AD00
	// [XID] // 0x0000000189605610-0x0000000189605630
	public override void InitEmpty() {} // 0x000000018210B7E0-0x000000018210B8B0
	[BlackList] // 0x000000018960D000-0x000000018960D040
	// [XID] // 0x000000018960D000-0x000000018960D040
	public override bool FromJson(JSONNode node) => default; // 0x000000018210B150-0x000000018210B4D0
	// [XID] // 0x0000000189617450-0x0000000189617470
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018210A420-0x000000018210A650
	[BlackList] // 0x000000018961F040-0x000000018961F080
	// [XID] // 0x000000018961F040-0x000000018961F080
	public static new ConfigMusicStringStimulusHandler ParseFromJson(JSONNode node) => default; // 0x000000018210BF70-0x000000018210C1C0
	// [XID] // 0x0000000189629650-0x0000000189629670
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB1E */, bool useObjectPool = false /* Metadata: 0x00AFAB22 */) => default; // 0x000000018210BA80-0x000000018210BD80
	// [XID] // 0x0000000189630F80-0x0000000189630FA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB23 */, bool useObjectPool = false /* Metadata: 0x00AFAB27 */) => default; // 0x000000018210ADE0-0x000000018210B050
	// [XID] // 0x00000001896389F0-0x0000000189638A10
	public static new ConfigMusicStringStimulusHandler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAB28 */, bool useObjectPool = false /* Metadata: 0x00AFAB2C */) => default; // 0x000000018210B4D0-0x000000018210B6F0
	[BlackList] // 0x000000018963FDB0-0x000000018963FDF0
	// [XID] // 0x000000018963FDB0-0x000000018963FDF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018210A6F0-0x000000018210A9C0
	// [XID] // 0x000000018964A620-0x000000018964A640
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018210C300-0x000000018210C500
	[BlackList] // 0x0000000189651E60-0x0000000189651EA0
	// [XID] // 0x0000000189651E60-0x0000000189651EA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018210B990-0x000000018210BA80
	// [XID] // 0x000000018965C640-0x000000018965C660
	protected override bool MatchParameter(IStimulusParameter parameter) => default; // 0x000000018210A260-0x000000018210A3A0
	[BlackList] // 0x0000000189663C40-0x0000000189663C80
	// [XID] // 0x0000000189663C40-0x0000000189663C80
	public override void AutoAllocTypeFields() {} // 0x000000018210A9C0-0x000000018210AA60
	[BlackList] // 0x000000018966E3E0-0x000000018966E420
	// [XID] // 0x000000018966E3E0-0x000000018966E420
	public override void AutoRecycleTypeFields() {} // 0x000000018210AA60-0x000000018210AB10
	[BlackList] // 0x0000000189679310-0x0000000189679350
	// [XID] // 0x0000000189679310-0x0000000189679350
	public override void ReturnToObjectPool() {} // 0x000000018210C5F0-0x000000018210C690
}

