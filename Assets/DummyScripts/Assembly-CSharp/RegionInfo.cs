/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionInfo : MessageBase, IMessage<RegionInfo> // TypeDefIndex: 25968
{
	// Fields
	private static readonly MessageParser<RegionInfo> _parser; // 0x00
	public const int GateserverIpFieldNumber = 1; // Metadata: 0x00B0A7DB
	private string gateserverIp_; // 0x18
	public const int GateserverPortFieldNumber = 2; // Metadata: 0x00B0A7DF
	private uint gateserverPort_; // 0x20
	public const int PayCallbackUrlFieldNumber = 3; // Metadata: 0x00B0A7E3
	private string payCallbackUrl_; // 0x28
	public const int AreaTypeFieldNumber = 7; // Metadata: 0x00B0A7E7
	private string areaType_; // 0x30
	public const int ResourceUrlFieldNumber = 8; // Metadata: 0x00B0A7EB
	private string resourceUrl_; // 0x38
	public const int DataUrlFieldNumber = 9; // Metadata: 0x00B0A7EF
	private string dataUrl_; // 0x40
	public const int FeedbackUrlFieldNumber = 10; // Metadata: 0x00B0A7F3
	private string feedbackUrl_; // 0x48
	public const int BulletinUrlFieldNumber = 11; // Metadata: 0x00B0A7F7
	private string bulletinUrl_; // 0x50
	public const int ResourceUrlBakFieldNumber = 12; // Metadata: 0x00B0A7FB
	private string resourceUrlBak_; // 0x58
	public const int DataUrlBakFieldNumber = 13; // Metadata: 0x00B0A7FF
	private string dataUrlBak_; // 0x60
	public const int ClientDataVersionFieldNumber = 14; // Metadata: 0x00B0A803
	private uint clientDataVersion_; // 0x68
	public const int HandbookUrlFieldNumber = 16; // Metadata: 0x00B0A807
	private string handbookUrl_; // 0x70
	public const int ClientSilenceDataVersionFieldNumber = 18; // Metadata: 0x00B0A80B
	private uint clientSilenceDataVersion_; // 0x78
	public const int ClientDataMd5FieldNumber = 19; // Metadata: 0x00B0A80F
	private string clientDataMd5_; // 0x80
	public const int ClientSilenceDataMd5FieldNumber = 20; // Metadata: 0x00B0A813
	private string clientSilenceDataMd5_; // 0x88
	public const int ResVersionConfigFieldNumber = 22; // Metadata: 0x00B0A817
	private ResVersionConfig resVersionConfig_; // 0x90
	public const int SecretKeyFieldNumber = 23; // Metadata: 0x00B0A81B
	private ByteString secretKey_; // 0x98
	public const int OfficialCommunityUrlFieldNumber = 24; // Metadata: 0x00B0A81F
	private string officialCommunityUrl_; // 0xA0
	public const int ClientVersionSuffixFieldNumber = 26; // Metadata: 0x00B0A823
	private string clientVersionSuffix_; // 0xA8
	public const int ClientSilenceVersionSuffixFieldNumber = 27; // Metadata: 0x00B0A827
	private string clientSilenceVersionSuffix_; // 0xB0
	public const int UseGateserverDomainNameFieldNumber = 28; // Metadata: 0x00B0A82B
	private bool useGateserverDomainName_; // 0xB8
	public const int GateserverDomainNameFieldNumber = 29; // Metadata: 0x00B0A82F
	private string gateserverDomainName_; // 0xC0
	public const int UserCenterUrlFieldNumber = 30; // Metadata: 0x00B0A833
	private string userCenterUrl_; // 0xC8
	public const int AccountBindUrlFieldNumber = 31; // Metadata: 0x00B0A837
	private string accountBindUrl_; // 0xD0
	public const int CdkeyUrlFieldNumber = 32; // Metadata: 0x00B0A83B
	private string cdkeyUrl_; // 0xD8
	public const int PrivacyPolicyUrlFieldNumber = 33; // Metadata: 0x00B0A83F
	private string privacyPolicyUrl_; // 0xE0
	public const int NextResourceUrlFieldNumber = 34; // Metadata: 0x00B0A843
	private string nextResourceUrl_; // 0xE8
	public const int NextResVersionConfigFieldNumber = 35; // Metadata: 0x00B0A847
	private ResVersionConfig nextResVersionConfig_; // 0xF0

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionInfo> Parser { get => default; } // 0x000000018494EC70-0x000000018494ED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018494E230-0x000000018494E2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018494D2F0-0x000000018494D370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018494A510-0x000000018494A570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184950190-0x0000000184950280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018494F290-0x000000018494F2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018494E7F0-0x000000018494E8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184950000-0x0000000184950050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018494D4B0-0x000000018494D5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GateserverIp { get => default; set {} } // 0x000000018494E600-0x000000018494E6A0 0x000000018494B940-0x000000018494B9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GateserverPort { get => default; set {} } // 0x000000018494EBD0-0x000000018494EC70 0x000000018494E6A0-0x000000018494E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PayCallbackUrl { get => default; set {} } // 0x0000000184950280-0x0000000184950320 0x000000018494B9F0-0x000000018494BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AreaType { get => default; set {} } // 0x0000000184950470-0x0000000184950510 0x000000018494EF60-0x000000018494F010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ResourceUrl { get => default; set {} } // 0x000000018494FF60-0x0000000184950000 0x000000018494B210-0x000000018494B2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DataUrl { get => default; set {} } // 0x000000018494A470-0x000000018494A510 0x000000018494D050-0x000000018494D100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string FeedbackUrl { get => default; set {} } // 0x000000018494E420-0x000000018494E4C0 0x000000018494A6D0-0x000000018494A780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string BulletinUrl { get => default; set {} } // 0x000000018494EB30-0x000000018494EBD0 0x000000018494E370-0x000000018494E420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ResourceUrlBak { get => default; set {} } // 0x000000018494F390-0x000000018494F430 0x000000018494A620-0x000000018494A6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DataUrlBak { get => default; set {} } // 0x0000000184949E20-0x0000000184949EC0 0x000000018494E8E0-0x000000018494E990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientDataVersion { get => default; set {} } // 0x0000000184950320-0x00000001849503C0 0x000000018494E560-0x000000018494E600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string HandbookUrl { get => default; set {} } // 0x000000018494E4C0-0x000000018494E560 0x000000018494E2C0-0x000000018494E370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientSilenceDataVersion { get => default; set {} } // 0x000000018494F2F0-0x000000018494F390 0x000000018494E0F0-0x000000018494E190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientDataMd5 { get => default; set {} } // 0x000000018494E190-0x000000018494E230 0x000000018494B890-0x000000018494B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceDataMd5 { get => default; set {} } // 0x000000018494FEC0-0x000000018494FF60 0x000000018494B160-0x000000018494B210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig ResVersionConfig { get => default; set {} } // 0x000000018494E050-0x000000018494E0F0 0x000000018494FE20-0x000000018494FEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString SecretKey { get => default; set {} } // 0x000000018494A3D0-0x000000018494A470 0x000000018494DFA0-0x000000018494E050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OfficialCommunityUrl { get => default; set {} } // 0x0000000184950510-0x00000001849505B0 0x000000018494A570-0x000000018494A620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientVersionSuffix { get => default; set {} } // 0x000000018494F010-0x000000018494F0B0 0x000000018494E740-0x000000018494E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientSilenceVersionSuffix { get => default; set {} } // 0x0000000184950050-0x00000001849500F0 0x000000018494D1A0-0x000000018494D250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool UseGateserverDomainName { get => default; set {} } // 0x000000018494BAA0-0x000000018494BB40 0x000000018494ED00-0x000000018494EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GateserverDomainName { get => default; set {} } // 0x000000018494D100-0x000000018494D1A0 0x000000018494B2C0-0x000000018494B370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string UserCenterUrl { get => default; set {} } // 0x000000018494D370-0x000000018494D410 0x000000018494F150-0x000000018494F200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountBindUrl { get => default; set {} } // 0x000000018494A830-0x000000018494A8D0 0x000000018494EA80-0x000000018494EB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CdkeyUrl { get => default; set {} } // 0x000000018494B0C0-0x000000018494B160 0x000000018494A780-0x000000018494A830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PrivacyPolicyUrl { get => default; set {} } // 0x000000018494EE30-0x000000018494EED0 0x000000018494B410-0x000000018494B4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NextResourceUrl { get => default; set {} } // 0x000000018494F0B0-0x000000018494F150 0x00000001849503C0-0x0000000184950470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig NextResVersionConfig { get => default; set {} } // 0x00000001849500F0-0x0000000184950190 0x000000018494D250-0x000000018494D2F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionInfo() {} // 0x0000000184951470-0x0000000184951610
	static RegionInfo() {} // 0x00000001849513B0-0x0000000184951470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionInfo Clone() => default; // 0x000000018494E990-0x000000018494EA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionInfo ShallowCopy() => default; // 0x000000018494D410-0x000000018494D4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018494B370-0x000000018494B410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018494EED0-0x000000018494EF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018494F200-0x000000018494F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018494B4C0-0x000000018494B890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018494C3E0-0x000000018494C4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionInfo other) => default; // 0x000000018494BB40-0x000000018494C3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018494D5A0-0x000000018494DFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849505B0-0x00000001849513B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018494F430-0x000000018494FE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018494C4B0-0x000000018494D050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionInfo other) {} // 0x000000018494A8D0-0x000000018494B0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184949EC0-0x000000018494A3D0
}

