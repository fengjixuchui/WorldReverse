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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class NpcExcelConfig : EntityExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15911
{
	// Fields
	protected string _jsonName; // 0x48
	protected byte _jsonPathHashPre; // 0x50
	protected uint _jsonPathHashSuffix; // 0x54
	protected string _alias; // 0x58
	protected string _scriptDataPath; // 0x60
	protected string _luaDataPath; // 0x68
	protected SimpleSafeUInt32 luaDataIndexRawNum; // 0x70
	protected bool _hasCombat; // 0x74
	protected bool _hasMove; // 0x75
	protected bool _hasAudio; // 0x76
	protected bool _isDaily; // 0x77
	protected string _dyePart; // 0x78
	protected BillboardType _billboardType; // 0x80
	protected string _billboardIcon; // 0x88
	protected bool _invisiable; // 0x90
	protected bool _disableShowName; // 0x91
	protected string _templateEmotionPath; // 0x98
	protected byte _animatorConfigPathHashPre; // 0xA0
	protected uint _animatorConfigPathHashSuffix; // 0xA4
	protected NPCBodyType _bodyType; // 0xA8
	protected SimpleSafeUInt32 firstMetIdRawNum; // 0xAC
	protected bool _isRelease; // 0xB0

	// Properties
	public string jsonName { /* [XID] */ /* 0x0000000189667310-0x0000000189667330 */ get => default; /* [XID] */ /* 0x000000018966EBA0-0x000000018966EBC0 */ protected set {} } // 0x0000000181C40CB0-0x0000000181C40D50 0x0000000181C3EE00-0x0000000181C3EEB0
	public byte jsonPathHashPre { /* [XID] */ /* 0x0000000189676580-0x00000001896765A0 */ get => default; /* [XID] */ /* 0x000000018967DD80-0x000000018967DDA0 */ protected set {} } // 0x0000000181C3C2C0-0x0000000181C3C360 0x0000000181C3C160-0x0000000181C3C210
	public uint jsonPathHashSuffix { /* [XID] */ /* 0x0000000189685440-0x0000000189685460 */ get => default; /* [XID] */ /* 0x000000018968CF80-0x000000018968CFA0 */ protected set {} } // 0x0000000181C40EF0-0x0000000181C40F90 0x0000000181C3ED50-0x0000000181C3EE00
	public ulong jsonPathHash { /* [XID] */ /* 0x0000000189694AA0-0x0000000189694AC0 */ get => default; } // 0x0000000181C40B40-0x0000000181C40C10 
	public string alias { /* [XID] */ /* 0x000000018969C260-0x000000018969C280 */ get => default; /* [XID] */ /* 0x00000001896A3780-0x00000001896A37A0 */ protected set {} } // 0x0000000181C3E880-0x0000000181C3E920 0x0000000181C407D0-0x0000000181C40880
	public string scriptDataPath { /* [XID] */ /* 0x0000000189794300-0x0000000189794320 */ get => default; /* [XID] */ /* 0x00000001896B1B70-0x00000001896B1B90 */ protected set {} } // 0x0000000181C41560-0x0000000181C41600 0x0000000181C3C000-0x0000000181C3C0B0
	public string luaDataPath { /* [XID] */ /* 0x00000001898E4B20-0x00000001898E4B40 */ get => default; /* [XID] */ /* 0x00000001896C0940-0x00000001896C0960 */ protected set {} } // 0x0000000181C40D50-0x0000000181C40DF0 0x0000000181C3C0B0-0x0000000181C3C160
	public uint luaDataIndex { /* [XID] */ /* 0x00000001898EC580-0x00000001898EC5A0 */ get => default; /* [XID] */ /* 0x00000001896CF9F0-0x00000001896CFA10 */ protected set {} } // 0x0000000181C3EF10-0x0000000181C3EFE0 0x0000000181C41480-0x0000000181C41560
	public bool hasCombat { /* [XID] */ /* 0x00000001896D6C60-0x00000001896D6C80 */ get => default; /* [XID] */ /* 0x00000001896DE400-0x00000001896DE420 */ protected set {} } // 0x0000000181C40E50-0x0000000181C40EF0 0x0000000181C3EC10-0x0000000181C3ECC0
	public bool hasMove { /* [XID] */ /* 0x00000001896E5810-0x00000001896E5830 */ get => default; /* [XID] */ /* 0x00000001896ECEE0-0x00000001896ECF00 */ protected set {} } // 0x0000000181C413E0-0x0000000181C41480 0x0000000181C3C690-0x0000000181C3C740
	public bool hasAudio { /* [XID] */ /* 0x00000001897E7D30-0x00000001897E7D50 */ get => default; /* [XID] */ /* 0x00000001896FBF90-0x00000001896FBFB0 */ protected set {} } // 0x0000000181C3E7E0-0x0000000181C3E880 0x0000000181C3EFE0-0x0000000181C3F090
	public bool isDaily { /* [XID] */ /* 0x0000000189703590-0x00000001897035B0 */ get => default; /* [XID] */ /* 0x000000018970AC20-0x000000018970AC40 */ protected set {} } // 0x0000000181C3C850-0x0000000181C3C8F0 0x0000000181C3E730-0x0000000181C3E7E0
	public string dyePart { /* [XID] */ /* 0x0000000189712550-0x0000000189712570 */ get => default; /* [XID] */ /* 0x0000000189719D90-0x0000000189719DB0 */ protected set {} } // 0x0000000181C3E9F0-0x0000000181C3EA90 0x0000000181C40930-0x0000000181C409E0
	public BillboardType billboardType { /* [XID] */ /* 0x00000001897212B0-0x00000001897212D0 */ get => default; /* [XID] */ /* 0x00000001897288F0-0x0000000189728910 */ protected set {} } // 0x0000000181C40730-0x0000000181C407D0 0x0000000181C3EA90-0x0000000181C3EB40
	public string billboardIcon { /* [XID] */ /* 0x0000000189ABE740-0x0000000189ABE760 */ get => default; /* [XID] */ /* 0x00000001897379C0-0x00000001897379E0 */ protected set {} } // 0x0000000181C41280-0x0000000181C41330 0x0000000181C40F90-0x0000000181C41040
	public bool invisiable { /* [XID] */ /* 0x00000001897A3BD0-0x00000001897A3BF0 */ get => default; /* [XID] */ /* 0x0000000189746840-0x0000000189746860 */ protected set {} } // 0x0000000181C409E0-0x0000000181C40A90 0x0000000181C3C740-0x0000000181C3C7F0
	public bool disableShowName { /* [XID] */ /* 0x000000018974E1D0-0x000000018974E1F0 */ get => default; /* [XID] */ /* 0x0000000189755890-0x00000001897558B0 */ protected set {} } // 0x0000000181C411D0-0x0000000181C41280 0x0000000181C3C210-0x0000000181C3C2C0
	public string templateEmotionPath { /* [XID] */ /* 0x000000018975CB70-0x000000018975CB90 */ get => default; /* [XID] */ /* 0x0000000189764380-0x00000001897643A0 */ protected set {} } // 0x0000000181C41600-0x0000000181C416B0 0x0000000181C40880-0x0000000181C40930
	public byte animatorConfigPathHashPre { /* [XID] */ /* 0x000000018976BCC0-0x000000018976BCE0 */ get => default; /* [XID] */ /* 0x0000000189773280-0x00000001897732A0 */ protected set {} } // 0x0000000181C40680-0x0000000181C40730 0x0000000181C3C8F0-0x0000000181C3C9A0
	public uint animatorConfigPathHashSuffix { /* [XID] */ /* 0x000000018977A840-0x000000018977A860 */ get => default; /* [XID] */ /* 0x0000000189782480-0x00000001897824A0 */ protected set {} } // 0x0000000181C3C5F0-0x0000000181C3C690 0x0000000181C41040-0x0000000181C410F0
	public ulong animatorConfigPathHash { /* [XID] */ /* 0x0000000189789760-0x0000000189789780 */ get => default; } // 0x0000000181C3E920-0x0000000181C3E9F0 
	public NPCBodyType bodyType { /* [XID] */ /* 0x0000000189790ED0-0x0000000189790EF0 */ get => default; /* [XID] */ /* 0x00000001897986A0-0x00000001897986C0 */ protected set {} } // 0x0000000181C40C10-0x0000000181C40CB0 0x0000000181C41330-0x0000000181C413E0
	public uint firstMetId { /* [XID] */ /* 0x00000001897A0570-0x00000001897A0590 */ get => default; /* [XID] */ /* 0x00000001897A7B20-0x00000001897A7B40 */ protected set {} } // 0x0000000181C3EB40-0x0000000181C3EC10 0x0000000181C410F0-0x0000000181C411D0
	public bool isRelease { /* [XID] */ /* 0x00000001897AF570-0x00000001897AF590 */ get => default; /* [XID] */ /* 0x00000001897B7470-0x00000001897B7490 */ protected set {} } // 0x0000000181C3E680-0x0000000181C3E730 0x0000000181C40A90-0x0000000181C40B40

	// Constructors
	public NpcExcelConfig() {} // 0x0000000181C41750-0x0000000181C417B0

	// Methods
	// [IDTag] // 0x00000001897BF2F0-0x00000001897BF330
	// [XID] // 0x00000001897BF2F0-0x00000001897BF330
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C3D850-0x0000000181C3E680
	// [IDTag] // 0x00000001897C9860-0x00000001897C98A0
	// [XID] // 0x00000001897C9860-0x00000001897C98A0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C3C9A0-0x0000000181C3D850
	// [XID] // 0x00000001897D3F80-0x00000001897D3FA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AF2 */, bool useObjectPool = false /* Metadata: 0x00AF2AF6 */) => default; // 0x0000000181C3F090-0x0000000181C40680
	[BlackList] // 0x00000001897DB7F0-0x00000001897DB830
	// [XID] // 0x00000001897DB7F0-0x00000001897DB830
	public override void AutoAllocTypeFields() {} // 0x0000000181C3C360-0x0000000181C3C400
	[BlackList] // 0x00000001897E6130-0x00000001897E6170
	// [XID] // 0x00000001897E6130-0x00000001897E6170
	public override void AutoRecycleTypeFields() {} // 0x0000000181C3C400-0x0000000181C3C550
	[BlackList] // 0x00000001897F0CA0-0x00000001897F0CE0
	// [XID] // 0x00000001897F0CA0-0x00000001897F0CE0
	public override void ReturnToObjectPool() {} // 0x0000000181C416B0-0x0000000181C41750
}

