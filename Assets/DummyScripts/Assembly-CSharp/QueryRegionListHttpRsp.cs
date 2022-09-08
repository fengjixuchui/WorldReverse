/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryRegionListHttpRsp : MessageBase, IMessage<QueryRegionListHttpRsp> // TypeDefIndex: 25964
{
	// Fields
	private static readonly MessageParser<QueryRegionListHttpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0A797
	private int retcode_; // 0x18
	public const int RegionListFieldNumber = 2; // Metadata: 0x00B0A79B
	private static readonly FieldCodec<RegionSimpleInfo> _repeated_regionList_codec; // 0x08
	private readonly RepeatedMessageField<RegionSimpleInfo> regionList_; // 0x20
	public const int ClientSecretKeyFieldNumber = 5; // Metadata: 0x00B0A79F
	private ByteString clientSecretKey_; // 0x28
	public const int ClientCustomConfigEncryptedFieldNumber = 6; // Metadata: 0x00B0A7A3
	private ByteString clientCustomConfigEncrypted_; // 0x30
	public const int EnableLoginPcFieldNumber = 7; // Metadata: 0x00B0A7A7
	private bool enableLoginPc_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryRegionListHttpRsp> Parser { get => default; } // 0x00000001841B1E30-0x00000001841B1EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841B1BC0-0x00000001841B1C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841B16A0-0x00000001841B1720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841B0A90-0x00000001841B0AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841B2460-0x00000001841B2550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841B20D0-0x00000001841B2130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841B1C50-0x00000001841B1D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841B2410-0x00000001841B2460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841B17C0-0x00000001841B18B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001841B14B0-0x00000001841B1550 0x00000001841B0F30-0x00000001841B0FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RegionSimpleInfo> RegionList { get => default; } // 0x00000001841B2070-0x00000001841B20D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ClientSecretKey { get => default; set {} } // 0x00000001841B0D50-0x00000001841B0DF0 0x00000001841B1550-0x00000001841B1600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ClientCustomConfigEncrypted { get => default; set {} } // 0x00000001841B1A80-0x00000001841B1B20 0x00000001841B2130-0x00000001841B21E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool EnableLoginPc { get => default; set {} } // 0x00000001841B1B20-0x00000001841B1BC0 0x00000001841B1600-0x00000001841B16A0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryRegionListHttpRsp() {} // 0x00000001841B29B0-0x00000001841B2A80
	static QueryRegionListHttpRsp() {} // 0x00000001841B28A0-0x00000001841B29B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryRegionListHttpRsp Clone() => default; // 0x00000001841B1D40-0x00000001841B1E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryRegionListHttpRsp ShallowCopy() => default; // 0x00000001841B1720-0x00000001841B17C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841B0D00-0x00000001841B0D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841B1F50-0x00000001841B1FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841B1FE0-0x00000001841B2070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841B0DF0-0x00000001841B0F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841B0FD0-0x00000001841B10A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryRegionListHttpRsp other) => default; // 0x00000001841B10A0-0x00000001841B1290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841B18B0-0x00000001841B1A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841B2550-0x00000001841B28A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841B21E0-0x00000001841B2410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841B1290-0x00000001841B14B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryRegionListHttpRsp other) {} // 0x00000001841B0AF0-0x00000001841B0D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841B08D0-0x00000001841B0A90
}

