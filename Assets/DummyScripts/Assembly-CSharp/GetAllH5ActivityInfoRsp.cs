/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAllH5ActivityInfoRsp : MessageBase, IMessage<GetAllH5ActivityInfoRsp> // TypeDefIndex: 23300
{
	// Fields
	private static readonly MessageParser<GetAllH5ActivityInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03B7B
	private int retcode_; // 0x18
	public const int H5ActivityInfoListFieldNumber = 2; // Metadata: 0x00B03B7F
	private static readonly FieldCodec<H5ActivityInfo> _repeated_h5ActivityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<H5ActivityInfo> h5ActivityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAllH5ActivityInfoRsp> Parser { get => default; } // 0x00000001832F9610-0x00000001832F96A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832F93A0-0x00000001832F9430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832F9090-0x00000001832F9110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832F88C0-0x00000001832F8920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832F9A40-0x00000001832F9B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832F9850-0x00000001832F98B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832F9430-0x00000001832F9520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832F99F0-0x00000001832F9A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832F91B0-0x00000001832F92A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001832F8FF0-0x00000001832F9090 0x00000001832F8C10-0x00000001832F8CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<H5ActivityInfo> H5ActivityInfoList { get => default; } // 0x00000001832F8920-0x00000001832F8980 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23301
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23302
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5651
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllH5ActivityInfoRsp() {} // 0x00000001832F9E20-0x00000001832F9EB0
	static GetAllH5ActivityInfoRsp() {} // 0x00000001832F9D10-0x00000001832F9E20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllH5ActivityInfoRsp Clone() => default; // 0x00000001832F9520-0x00000001832F9610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllH5ActivityInfoRsp ShallowCopy() => default; // 0x00000001832F9110-0x00000001832F91B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832F8AE0-0x00000001832F8B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832F9730-0x00000001832F97C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832F97C0-0x00000001832F9850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832F8B30-0x00000001832F8C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832F8CB0-0x00000001832F8D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAllH5ActivityInfoRsp other) => default; // 0x00000001832F8D80-0x00000001832F8EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832F92A0-0x00000001832F93A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832F9B30-0x00000001832F9D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832F98B0-0x00000001832F99F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832F8EB0-0x00000001832F8FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAllH5ActivityInfoRsp other) {} // 0x00000001832F8980-0x00000001832F8AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832F8760-0x00000001832F88C0
}

