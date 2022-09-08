/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetMapMarkTipsRsp : MessageBase, IMessage<GetMapMarkTipsRsp> // TypeDefIndex: 25318
{
	// Fields
	private static readonly MessageParser<GetMapMarkTipsRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08727
	private int retcode_; // 0x18
	public const int MarkTipsListFieldNumber = 2; // Metadata: 0x00B0872B
	private static readonly FieldCodec<MapMarkTipsInfo> _repeated_markTipsList_codec; // 0x08
	private readonly RepeatedMessageField<MapMarkTipsInfo> markTipsList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetMapMarkTipsRsp> Parser { get => default; } // 0x00000001810BDC10-0x00000001810BDCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001810BD940-0x00000001810BD9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001810BD630-0x00000001810BD6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001810BCEC0-0x00000001810BCF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001810BE040-0x00000001810BE130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001810BDE50-0x00000001810BDEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001810BD9D0-0x00000001810BDAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001810BDFF0-0x00000001810BE040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001810BD750-0x00000001810BD840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001810BD590-0x00000001810BD630 0x00000001810BD1B0-0x00000001810BD250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MapMarkTipsInfo> MarkTipsList { get => default; } // 0x00000001810BDBB0-0x00000001810BDC10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25319
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25320
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3054
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMapMarkTipsRsp() {} // 0x00000001810BE420-0x00000001810BE4B0
	static GetMapMarkTipsRsp() {} // 0x00000001810BE310-0x00000001810BE420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMapMarkTipsRsp Clone() => default; // 0x00000001810BDAC0-0x00000001810BDBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMapMarkTipsRsp ShallowCopy() => default; // 0x00000001810BD6B0-0x00000001810BD750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001810BD080-0x00000001810BD0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810BDD30-0x00000001810BDDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810BDDC0-0x00000001810BDE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001810BD0D0-0x00000001810BD1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001810BD250-0x00000001810BD320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetMapMarkTipsRsp other) => default; // 0x00000001810BD320-0x00000001810BD450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001810BD840-0x00000001810BD940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001810BE130-0x00000001810BE310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001810BDEB0-0x00000001810BDFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001810BD450-0x00000001810BD590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetMapMarkTipsRsp other) {} // 0x00000001810BCF20-0x00000001810BD080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001810BCD60-0x00000001810BCEC0
}

