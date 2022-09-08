/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryPathRsp : MessageBase, IMessage<QueryPathRsp> // TypeDefIndex: 24258
{
	// Fields
	private static readonly MessageParser<QueryPathRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05F67
	private int retcode_; // 0x18
	public const int QueryIdFieldNumber = 2; // Metadata: 0x00B05F6B
	private int queryId_; // 0x1C
	public const int QueryStatusFieldNumber = 3; // Metadata: 0x00B05F6F
	private Types.PathStatusType queryStatus_; // 0x20
	public const int CornersFieldNumber = 4; // Metadata: 0x00B05F73
	private static readonly FieldCodec<Vector> _repeated_corners_codec; // 0x08
	private readonly RepeatedMessageField<Vector> corners_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryPathRsp> Parser { get => default; } // 0x00000001828EB9B0-0x00000001828EBA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828EB6A0-0x00000001828EB730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828EB2F0-0x00000001828EB370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828EA930-0x00000001828EA990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828EBEF0-0x00000001828EBFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828EBBF0-0x00000001828EBC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828EB730-0x00000001828EB820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828EBEA0-0x00000001828EBEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828EB410-0x00000001828EB500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001828EB1B0-0x00000001828EB250 0x00000001828EACF0-0x00000001828EAD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int QueryId { get => default; set {} } // 0x00000001828EBFE0-0x00000001828EC080 0x00000001828EB250-0x00000001828EB2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.PathStatusType QueryStatus { get => default; set {} } // 0x00000001828EB910-0x00000001828EB9B0 0x00000001828EBE00-0x00000001828EBEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Vector> Corners { get => default; } // 0x00000001828EA990-0x00000001828EA9F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24259
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24260
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2302
		}

		public enum PathStatusType // TypeDefIndex: 24261
		{
			StatusFail = 0,
			StatusSucc = 1,
			StatusPartial = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathRsp() {} // 0x00000001828EC490-0x00000001828EC530
	static QueryPathRsp() {} // 0x00000001828EC380-0x00000001828EC490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathRsp Clone() => default; // 0x00000001828EB820-0x00000001828EB910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryPathRsp ShallowCopy() => default; // 0x00000001828EB370-0x00000001828EB410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828EABA0-0x00000001828EABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828EBAD0-0x00000001828EBB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828EBB60-0x00000001828EBBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828EABF0-0x00000001828EACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828EAF00-0x00000001828EAFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryPathRsp other) => default; // 0x00000001828EAD90-0x00000001828EAF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828EB500-0x00000001828EB6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828EC080-0x00000001828EC380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828EBC50-0x00000001828EBE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828EAFD0-0x00000001828EB1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryPathRsp other) {} // 0x00000001828EA9F0-0x00000001828EABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828EA7A0-0x00000001828EA930
}

