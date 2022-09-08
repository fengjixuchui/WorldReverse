/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetActivityShopSheetInfoRsp : MessageBase, IMessage<GetActivityShopSheetInfoRsp> // TypeDefIndex: 25441
{
	// Fields
	private static readonly MessageParser<GetActivityShopSheetInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08C4B
	private int retcode_; // 0x18
	public const int ShopTypeFieldNumber = 2; // Metadata: 0x00B08C4F
	private uint shopType_; // 0x1C
	public const int SheetInfoListFieldNumber = 3; // Metadata: 0x00B08C53
	private static readonly FieldCodec<ActivityShopSheetInfo> _repeated_sheetInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ActivityShopSheetInfo> sheetInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetActivityShopSheetInfoRsp> Parser { get => default; } // 0x0000000185212860-0x00000001852128F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185212550-0x00000001852125E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185212170-0x00000001852121F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001852118F0-0x0000000185211950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185212CC0-0x0000000185212DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185212AA0-0x0000000185212B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001852125E0-0x00000001852126D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185212C70-0x0000000185212CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185212330-0x0000000185212420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001852120D0-0x0000000185212170 0x0000000185211C20-0x0000000185211CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShopType { get => default; set {} } // 0x0000000185212290-0x0000000185212330 0x00000001852127C0-0x0000000185212860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ActivityShopSheetInfo> SheetInfoList { get => default; } // 0x0000000185212070-0x00000001852120D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25442
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25443
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 708
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityShopSheetInfoRsp() {} // 0x0000000185213130-0x00000001852131C0
	static GetActivityShopSheetInfoRsp() {} // 0x0000000185213020-0x0000000185213130

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityShopSheetInfoRsp Clone() => default; // 0x00000001852126D0-0x00000001852127C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityShopSheetInfoRsp ShallowCopy() => default; // 0x00000001852121F0-0x0000000185212290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185211AE0-0x0000000185211B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185212980-0x0000000185212A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185212A10-0x0000000185212AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185211B30-0x0000000185211C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185211CC0-0x0000000185211D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetActivityShopSheetInfoRsp other) => default; // 0x0000000185211D90-0x0000000185211EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185212420-0x0000000185212550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185212DB0-0x0000000185213020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185212B00-0x0000000185212C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185211EE0-0x0000000185212070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetActivityShopSheetInfoRsp other) {} // 0x0000000185211950-0x0000000185211AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185211770-0x00000001852118F0
}

