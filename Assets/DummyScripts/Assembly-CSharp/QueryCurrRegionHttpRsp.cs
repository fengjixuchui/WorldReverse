/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryCurrRegionHttpRsp : MessageBase, IMessage<QueryCurrRegionHttpRsp> // TypeDefIndex: 25969
{
	// Fields
	private static readonly MessageParser<QueryCurrRegionHttpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0A84B
	private int retcode_; // 0x18
	public const int MsgFieldNumber = 2; // Metadata: 0x00B0A84F
	private string msg_; // 0x20
	public const int RegionInfoFieldNumber = 3; // Metadata: 0x00B0A853
	private RegionInfo regionInfo_; // 0x28
	public const int ForceUdpateFieldNumber = 4; // Metadata: 0x00B0A857
	public const int StopServerFieldNumber = 5; // Metadata: 0x00B0A85B
	public const int ClientSecretKeyFieldNumber = 11; // Metadata: 0x00B0A85F
	private ByteString clientSecretKey_; // 0x30
	public const int RegionCustomConfigEncryptedFieldNumber = 12; // Metadata: 0x00B0A863
	private ByteString regionCustomConfigEncrypted_; // 0x38
	public const int ClientRegionCustomConfigEncryptedFieldNumber = 13; // Metadata: 0x00B0A867
	private ByteString clientRegionCustomConfigEncrypted_; // 0x40
	private object detail_; // 0x48
	private DetailOneofCase detailCase_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryCurrRegionHttpRsp> Parser { get => default; } // 0x0000000184C3D540-0x0000000184C3D5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C3CFA0-0x0000000184C3D030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C3C8E0-0x0000000184C3C960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C3B480-0x0000000184C3B4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C3DDE0-0x0000000184C3DED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C3D8C0-0x0000000184C3D920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C3D170-0x0000000184C3D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C3DD90-0x0000000184C3DDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C3CA00-0x0000000184C3CAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184C3C520-0x0000000184C3C5C0 0x0000000184C3BD10-0x0000000184C3BDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Msg { get => default; set {} } // 0x0000000184C3CE30-0x0000000184C3CED0 0x0000000184C3DED0-0x0000000184C3DF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionInfo RegionInfo { get => default; set {} } // 0x0000000184C3D4A0-0x0000000184C3D540 0x0000000184C3D260-0x0000000184C3D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceUpdateInfo ForceUdpate { get => default; set {} } // 0x0000000184C3D9D0-0x0000000184C3DAA0 0x0000000184C3D030-0x0000000184C3D0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StopServerInfo StopServer { get => default; set {} } // 0x0000000184C3CED0-0x0000000184C3CFA0 0x0000000184C3BAC0-0x0000000184C3BB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ClientSecretKey { get => default; set {} } // 0x0000000184C3BA20-0x0000000184C3BAC0 0x0000000184C3C790-0x0000000184C3C840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString RegionCustomConfigEncrypted { get => default; set {} } // 0x0000000184C3C840-0x0000000184C3C8E0 0x0000000184C3D920-0x0000000184C3D9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ClientRegionCustomConfigEncrypted { get => default; set {} } // 0x0000000184C3D0D0-0x0000000184C3D170 0x0000000184C3D3F0-0x0000000184C3D4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x0000000184C3B9C0-0x0000000184C3BA20 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 25970
	{
		None = 0,
		ForceUdpate = 4,
		StopServer = 5
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCurrRegionHttpRsp() {} // 0x0000000184C3E5B0-0x0000000184C3E670
	static QueryCurrRegionHttpRsp() {} // 0x0000000184C3E4F0-0x0000000184C3E5B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCurrRegionHttpRsp Clone() => default; // 0x0000000184C3D300-0x0000000184C3D3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryCurrRegionHttpRsp ShallowCopy() => default; // 0x0000000184C3C960-0x0000000184C3CA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C3B880-0x0000000184C3B9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C3D660-0x0000000184C3D790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C3D790-0x0000000184C3D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C3BB60-0x0000000184C3BD10
	public void resetDetail() {} // 0x0000000184C3C5C0-0x0000000184C3C790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x0000000184C3B4E0-0x0000000184C3B540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C3C0A0-0x0000000184C3C170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryCurrRegionHttpRsp other) => default; // 0x0000000184C3BDB0-0x0000000184C3C0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C3CAF0-0x0000000184C3CE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C3DF80-0x0000000184C3E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C3DAA0-0x0000000184C3DD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C3C170-0x0000000184C3C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryCurrRegionHttpRsp other) {} // 0x0000000184C3B540-0x0000000184C3B880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C3B1B0-0x0000000184C3B480
}

