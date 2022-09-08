/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetOpActivityInfoRsp : MessageBase, IMessage<GetOpActivityInfoRsp> // TypeDefIndex: 24244
{
	// Fields
	private static readonly MessageParser<GetOpActivityInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05EDF
	private int retcode_; // 0x18
	public const int OpActivityInfoListFieldNumber = 2; // Metadata: 0x00B05EE3
	private static readonly FieldCodec<OpActivityInfo> _repeated_opActivityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<OpActivityInfo> opActivityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetOpActivityInfoRsp> Parser { get => default; } // 0x00000001848DE090-0x00000001848DE120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848DDDC0-0x00000001848DDE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848DDAB0-0x00000001848DDB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848DD340-0x00000001848DD3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848DE4C0-0x00000001848DE5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848DE2D0-0x00000001848DE330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848DDE50-0x00000001848DDF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848DE470-0x00000001848DE4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848DDBD0-0x00000001848DDCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001848DDA10-0x00000001848DDAB0 0x00000001848DD630-0x00000001848DD6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OpActivityInfo> OpActivityInfoList { get => default; } // 0x00000001848DE030-0x00000001848DE090 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24245
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24246
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5102
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOpActivityInfoRsp() {} // 0x00000001848DE8A0-0x00000001848DE930
	static GetOpActivityInfoRsp() {} // 0x00000001848DE790-0x00000001848DE8A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOpActivityInfoRsp Clone() => default; // 0x00000001848DDF40-0x00000001848DE030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOpActivityInfoRsp ShallowCopy() => default; // 0x00000001848DDB30-0x00000001848DDBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848DD500-0x00000001848DD550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848DE1B0-0x00000001848DE240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848DE240-0x00000001848DE2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848DD550-0x00000001848DD630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848DD800-0x00000001848DD8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetOpActivityInfoRsp other) => default; // 0x00000001848DD6D0-0x00000001848DD800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848DDCC0-0x00000001848DDDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848DE5B0-0x00000001848DE790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848DE330-0x00000001848DE470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848DD8D0-0x00000001848DDA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetOpActivityInfoRsp other) {} // 0x00000001848DD3A0-0x00000001848DD500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848DD1E0-0x00000001848DD340
}

