/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerLoginRsp : MessageBase, IMessage<PlayerLoginRsp> // TypeDefIndex: 24308
{
	// Fields
	private static readonly MessageParser<PlayerLoginRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06233
	private int retcode_; // 0x18
	public const int PlayerDataFieldNumber = 2; // Metadata: 0x00B06237
	private ByteString playerData_; // 0x20
	public const int IsNewPlayerFieldNumber = 3; // Metadata: 0x00B0623B
	private bool isNewPlayer_; // 0x28
	public const int TargetUidFieldNumber = 4; // Metadata: 0x00B0623F
	private uint targetUid_; // 0x2C
	public const int LoginRandFieldNumber = 5; // Metadata: 0x00B06243
	private ulong loginRand_; // 0x30
	public const int IsUseAbilityHashFieldNumber = 6; // Metadata: 0x00B06247
	private bool isUseAbilityHash_; // 0x38
	public const int AbilityHashCodeFieldNumber = 7; // Metadata: 0x00B0624B
	private int abilityHashCode_; // 0x3C
	public const int AbilityHashMapFieldNumber = 8; // Metadata: 0x00B0624F
	private static readonly MapField<string, int> _map_abilityHashMap_codec; // 0x08
	private readonly MapField<string, int> abilityHashMap_; // 0x40
	public const int ClientDataVersionFieldNumber = 9; // Metadata: 0x00B06253
	private uint clientDataVersion_; // 0x48
	public const int IsReloginFieldNumber = 11; // Metadata: 0x00B06257
	private bool isRelogin_; // 0x4C
	public const int ClientSilenceDataVersionFieldNumber = 13; // Metadata: 0x00B0625B
	private uint clientSilenceDataVersion_; // 0x50
	public const int GameBizFieldNumber = 14; // Metadata: 0x00B0625F
	private string gameBiz_; // 0x58
	public const int PlayerDataVersionFieldNumber = 15; // Metadata: 0x00B06263
	private uint playerDataVersion_; // 0x60
	public const int ClientMd5FieldNumber = 16; // Metadata: 0x00B06267
	private string clientMd5_; // 0x68
	public const int ClientSilenceMd5FieldNumber = 17; // Metadata: 0x00B0626B
	private string clientSilenceMd5_; // 0x70
	public const int ResVersionConfigFieldNumber = 20; // Metadata: 0x00B0626F
	private ResVersionConfig resVersionConfig_; // 0x78
	public const int BlockInfoMapFieldNumber = 21; // Metadata: 0x00B06273
	private static readonly MapField<uint, BlockInfo> _map_blockInfoMap_codec; // 0x10
	private readonly MapField<uint, BlockInfo> blockInfoMap_; // 0x80
	public const int ClientVersionSuffixFieldNumber = 24; // Metadata: 0x00B06277
	private string clientVersionSuffix_; // 0x88
	public const int ClientSilenceVersionSuffixFieldNumber = 25; // Metadata: 0x00B0627B
	private string clientSilenceVersionSuffix_; // 0x90
	public const int ShortAbilityHashMapFieldNumber = 27; // Metadata: 0x00B0627F
	private static readonly FieldCodec<ShortAbilityHashPair> _repeated_shortAbilityHashMap_codec; // 0x18
	private readonly RepeatedMessageField<ShortAbilityHashPair> shortAbilityHashMap_; // 0x98
	public const int ScInfoFieldNumber = 28; // Metadata: 0x00B06283
	private ByteString scInfo_; // 0xA0
	public const int IsAuditFieldNumber = 29; // Metadata: 0x00B06287
	private bool isAudit_; // 0xA8
	public const int IsScOpenFieldNumber = 30; // Metadata: 0x00B0628B
	private bool isScOpen_; // 0xA9
	public const int RegisterCpsFieldNumber = 31; // Metadata: 0x00B0628F
	private string registerCps_; // 0xB0
	public const int FeatureBlockInfoListFieldNumber = 32; // Metadata: 0x00B06293
	private static readonly FieldCodec<FeatureBlockInfo> _repeated_featureBlockInfoList_codec; // 0x20
	private readonly RepeatedMessageField<FeatureBlockInfo> featureBlockInfoList_; // 0xB8
	public const int IsDataNeedReloginFieldNumber = 33; // Metadata: 0x00B06297
	private bool isDataNeedRelogin_; // 0xC0
	public const int CountryCodeFieldNumber = 34; // Metadata: 0x00B0629B
	private string countryCode_; // 0xC8
	public const int NextResVersionConfigFieldNumber = 35; // Metadata: 0x00B0629F
	private ResVersionConfig nextResVersionConfig_; // 0xD0
	public const int NextResourceUrlFieldNumber = 36; // Metadata: 0x00B062A3
	private string nextResourceUrl_; // 0xD8
	public const int TargetHomeOwnerUidFieldNumber = 37; // Metadata: 0x00B062A7
	private uint targetHomeOwnerUid_; // 0xE0

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerLoginRsp> Parser { get => default; } // 0x00000001838BA0A0-0x00000001838BA130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838B9580-0x00000001838B9610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838B87C0-0x00000001838B8840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838B5D10-0x00000001838B5D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838BB650-0x00000001838BB740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838BA650-0x00000001838BA6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838B9BC0-0x00000001838B9CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838BB420-0x00000001838BB470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838B8940-0x00000001838B8A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001838B8530-0x00000001838B85D0 0x00000001838B7020-0x00000001838B70C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString PlayerData { get => default; set {} } // 0x00000001838B8720-0x00000001838B87C0 0x00000001838B9390-0x00000001838B9440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewPlayer { get => default; set {} } // 0x00000001838BB990-0x00000001838BBA30 0x00000001838B6930-0x00000001838B69D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001838B92F0-0x00000001838B9390 0x00000001838B8490-0x00000001838B8530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong LoginRand { get => default; set {} } // 0x00000001838BB2E0-0x00000001838BB380 0x00000001838B70C0-0x00000001838B7160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUseAbilityHash { get => default; set {} } // 0x00000001838B67E0-0x00000001838B6880 0x00000001838BA6B0-0x00000001838BA750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AbilityHashCode { get => default; set {} } // 0x00000001838B9930-0x00000001838B99D0 0x00000001838B9750-0x00000001838B97F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<string, int> AbilityHashMap { get => default; } // 0x00000001838BA550-0x00000001838BA5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientDataVersion { get => default; set {} } // 0x00000001838BB740-0x00000001838BB7E0 0x00000001838B99D0-0x00000001838B9A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRelogin { get => default; set {} } // 0x00000001838B5FF0-0x00000001838B6090 0x00000001838B5D70-0x00000001838B5E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientSilenceDataVersion { get => default; set {} } // 0x00000001838BA750-0x00000001838BA7F0 0x00000001838B94E0-0x00000001838B9580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GameBiz { get => default; set {} } // 0x00000001838B5E10-0x00000001838B5EB0 0x00000001838B9E50-0x00000001838B9F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerDataVersion { get => default; set {} } // 0x00000001838BA7F0-0x00000001838BA890 0x00000001838B5F50-0x00000001838B5FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientMd5 { get => default; set {} } // 0x00000001838B9F00-0x00000001838B9FA0 0x00000001838B6880-0x00000001838B6930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceMd5 { get => default; set {} } // 0x00000001838B97F0-0x00000001838B9890 0x00000001838B6F70-0x00000001838B7020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig ResVersionConfig { get => default; set {} } // 0x00000001838B9440-0x00000001838B94E0 0x00000001838BB240-0x00000001838BB2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, BlockInfo> BlockInfoMap { get => default; } // 0x00000001838BB930-0x00000001838BB990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientVersionSuffix { get => default; set {} } // 0x00000001838BA340-0x00000001838BA3E0 0x00000001838B9B10-0x00000001838B9BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceVersionSuffix { get => default; set {} } // 0x00000001838BB510-0x00000001838BB5B0 0x00000001838B85D0-0x00000001838B8680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShortAbilityHashPair> ShortAbilityHashMap { get => default; } // 0x00000001838B88E0-0x00000001838B8940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ScInfo { get => default; set {} } // 0x00000001838B9890-0x00000001838B9930 0x00000001838B9DA0-0x00000001838B9E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAudit { get => default; set {} } // 0x00000001838B5EB0-0x00000001838B5F50 0x00000001838B9610-0x00000001838B96B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsScOpen { get => default; set {} } // 0x00000001838B96B0-0x00000001838B9750 0x00000001838BB470-0x00000001838BB510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RegisterCps { get => default; set {} } // 0x00000001838BB380-0x00000001838BB420 0x00000001838BA1C0-0x00000001838BA270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FeatureBlockInfo> FeatureBlockInfoList { get => default; } // 0x00000001838BA040-0x00000001838BA0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDataNeedRelogin { get => default; set {} } // 0x00000001838B9A70-0x00000001838B9B10 0x00000001838BB890-0x00000001838BB930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CountryCode { get => default; set {} } // 0x00000001838BA5B0-0x00000001838BA650 0x00000001838B83E0-0x00000001838B8490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig NextResVersionConfig { get => default; set {} } // 0x00000001838BB5B0-0x00000001838BB650 0x00000001838B8680-0x00000001838B8720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NextResourceUrl { get => default; set {} } // 0x00000001838BA3E0-0x00000001838BA480 0x00000001838BB7E0-0x00000001838BB890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetHomeOwnerUid { get => default; set {} } // 0x00000001838B7160-0x00000001838B7200 0x00000001838B9FA0-0x00000001838BA040

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24309
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24310
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 104
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginRsp() {} // 0x00000001838BCC60-0x00000001838BCE00
	static PlayerLoginRsp() {} // 0x00000001838BCA00-0x00000001838BCC60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginRsp Clone() => default; // 0x00000001838B9CB0-0x00000001838B9DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginRsp ShallowCopy() => default; // 0x00000001838B8840-0x00000001838B88E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838B69D0-0x00000001838B6A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838BA270-0x00000001838BA340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838BA480-0x00000001838BA550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838B6A60-0x00000001838B6F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838B7200-0x00000001838B72D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerLoginRsp other) => default; // 0x00000001838B72D0-0x00000001838B79D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838B8A30-0x00000001838B92F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838BBA30-0x00000001838BCA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838BA890-0x00000001838BB240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838B79D0-0x00000001838B83E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerLoginRsp other) {} // 0x00000001838B6090-0x00000001838B67E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838B56B0-0x00000001838B5D10
}

