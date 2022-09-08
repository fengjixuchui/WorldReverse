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
public class ConfigNpc : ConfigCharacter, IAutoAllocRecycle // TypeDefIndex: 18030
{
	// Fields
	private SimpleSafeFloat defaultDitherRawNum; // 0x98
	private SimpleSafeFloat disappearDurationRawNum; // 0x9C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBeta _aibeta; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMove _move; // 0xA8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigIntee _intee; // 0xB0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetAudio _audio; // 0xB8
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEmojiBubble _emojiBubble; // 0xC0

	// Properties
	public float defaultDither { /* [XID] */ /* 0x00000001897D9330-0x00000001897D9350 */ get => default; /* [XID] */ /* 0x00000001895EF1E0-0x00000001895EF200 */ private set {} } // 0x00000001820CBA30-0x00000001820CBB10 0x00000001820C9890-0x00000001820C9970
	public float disappearDuration { /* [XID] */ /* 0x00000001895F6C00-0x00000001895F6C20 */ get => default; /* [XID] */ /* 0x00000001895FDFA0-0x00000001895FDFC0 */ private set {} } // 0x00000001820CB680-0x00000001820CB760 0x00000001820CBC30-0x00000001820CBD10
	public ConfigAIBeta aibeta { /* [XID] */ /* 0x0000000189919B60-0x0000000189919B80 */ get => default; /* [XID] */ /* 0x000000018960D160-0x000000018960D180 */ private set {} } // 0x00000001820CCC20-0x00000001820CCCD0 0x00000001820CBB80-0x00000001820CBC30
	public ConfigMove move { /* [XID] */ /* 0x0000000189614800-0x0000000189614820 */ get => default; /* [XID] */ /* 0x000000018961C160-0x000000018961C180 */ private set {} } // 0x00000001820CC860-0x00000001820CC910 0x00000001820CBF80-0x00000001820CC030
	public ConfigIntee intee { /* [XID] */ /* 0x00000001897B2D00-0x00000001897B2D20 */ get => default; /* [XID] */ /* 0x000000018962AEE0-0x000000018962AF00 */ private set {} } // 0x00000001820CD570-0x00000001820CD620 0x00000001820CCB70-0x00000001820CCC20
	public ConfigGadgetAudio audio { /* [XID] */ /* 0x0000000189636540-0x0000000189636560 */ get => default; /* [XID] */ /* 0x000000018963A0F0-0x000000018963A110 */ private set {} } // 0x00000001820CC120-0x00000001820CC1D0 0x00000001820CB980-0x00000001820CBA30
	public ConfigEmojiBubble emojiBubble { /* [XID] */ /* 0x00000001897FE730-0x00000001897FE750 */ get => default; /* [XID] */ /* 0x0000000189649020-0x0000000189649040 */ private set {} } // 0x00000001820CCAC0-0x00000001820CCB70 0x00000001820CD4C0-0x00000001820CD570

	// Constructors
	public ConfigNpc() {} // 0x00000001820CD6C0-0x00000001820CD770

	// Methods
	// [XID] // 0x0000000189650650-0x0000000189650670
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820CD2C0-0x00000001820CD4C0
	// [XID] // 0x0000000189657FB0-0x0000000189657FD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820CC970-0x00000001820CCAC0
	// [XID] // 0x000000018965F560-0x000000018965F580
	public override ConfigEntity Clone(bool useObjectPool = false /* Metadata: 0x00AF8737 */) => default; // 0x00000001820CC4D0-0x00000001820CC5B0
	// [XID] // 0x0000000189666E50-0x0000000189666E70
	public override int GetHashNum() => default; // 0x00000001820CA980-0x00000001820CAA50
	// [XID] // 0x000000018966E5E0-0x000000018966E600
	public override void InitEmpty() {} // 0x00000001820CBD10-0x00000001820CBEA0
	[BlackList] // 0x0000000189676220-0x0000000189676260
	// [XID] // 0x0000000189676220-0x0000000189676260
	public override bool FromJson(JSONNode node) => default; // 0x00000001820CB300-0x00000001820CB680
	// [XID] // 0x0000000189680BA0-0x0000000189680BC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001820C9970-0x00000001820CA190
	[BlackList] // 0x0000000189688600-0x0000000189688640
	// [XID] // 0x0000000189688600-0x0000000189688640
	public static new ConfigNpc ParseFromJson(JSONNode node) => default; // 0x00000001820CC610-0x00000001820CC860
	// [XID] // 0x0000000189693260-0x0000000189693280
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8738 */, bool useObjectPool = false /* Metadata: 0x00AF873C */) => default; // 0x00000001820CC1D0-0x00000001820CC4D0
	// [XID] // 0x000000018969A4B0-0x000000018969A4D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF873D */, bool useObjectPool = false /* Metadata: 0x00AF8741 */) => default; // 0x00000001820CAB30-0x00000001820CB200
	// [XID] // 0x00000001896A1DA0-0x00000001896A1DC0
	public static new ConfigNpc ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8742 */, bool useObjectPool = false /* Metadata: 0x00AF8746 */) => default; // 0x00000001820CB760-0x00000001820CB980
	[BlackList] // 0x00000001896A9180-0x00000001896A91C0
	// [XID] // 0x00000001896A9180-0x00000001896A91C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820CA190-0x00000001820CA460
	// [XID] // 0x00000001896B32D0-0x00000001896B32F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820CCCD0-0x00000001820CD2C0
	[BlackList] // 0x00000001896BAAD0-0x00000001896BAB10
	// [XID] // 0x00000001896BAAD0-0x00000001896BAB10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820CC030-0x00000001820CC120
	[BlackList] // 0x00000001896C4E30-0x00000001896C4E70
	// [XID] // 0x00000001896C4E30-0x00000001896C4E70
	public override void AutoAllocTypeFields() {} // 0x00000001820CA460-0x00000001820CA500
	[BlackList] // 0x00000001896CF6D0-0x00000001896CF710
	// [XID] // 0x00000001896CF6D0-0x00000001896CF710
	public override void AutoRecycleTypeFields() {} // 0x00000001820CA500-0x00000001820CA860
	[BlackList] // 0x00000001896D9A10-0x00000001896D9A50
	// [XID] // 0x00000001896D9A10-0x00000001896D9A50
	public override void ReturnToObjectPool() {} // 0x00000001820CD620-0x00000001820CD6C0
}

