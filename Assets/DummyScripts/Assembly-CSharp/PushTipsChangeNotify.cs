/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PushTipsChangeNotify : MessageBase, IMessage<PushTipsChangeNotify> // TypeDefIndex: 25783
{
	// Fields
	private static readonly MessageParser<PushTipsChangeNotify> _parser; // 0x00
	public const int PushTipsListFieldNumber = 1; // Metadata: 0x00B0990B
	private static readonly FieldCodec<PushTipsData> _repeated_pushTipsList_codec; // 0x08
	private readonly RepeatedMessageField<PushTipsData> pushTipsList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PushTipsChangeNotify> Parser { get => default; } // 0x0000000182E1F180-0x0000000182E1F210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E1EF10-0x0000000182E1EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E1EC40-0x0000000182E1ECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E1E660-0x0000000182E1E6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E1F570-0x0000000182E1F660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E1F3C0-0x0000000182E1F420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E1EFA0-0x0000000182E1F090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E1F520-0x0000000182E1F570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E1ED60-0x0000000182E1EE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PushTipsData> PushTipsList { get => default; } // 0x0000000182E1E6C0-0x0000000182E1E720 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25784
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25785
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2222
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsChangeNotify() {} // 0x0000000182E1F8C0-0x0000000182E1F950
	static PushTipsChangeNotify() {} // 0x0000000182E1F7B0-0x0000000182E1F8C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsChangeNotify Clone() => default; // 0x0000000182E1F090-0x0000000182E1F180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsChangeNotify ShallowCopy() => default; // 0x0000000182E1ECC0-0x0000000182E1ED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E1E850-0x0000000182E1E8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E1F2A0-0x0000000182E1F330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E1F330-0x0000000182E1F3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E1E8A0-0x0000000182E1E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E1EA80-0x0000000182E1EB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PushTipsChangeNotify other) => default; // 0x0000000182E1E970-0x0000000182E1EA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E1EE50-0x0000000182E1EF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E1F660-0x0000000182E1F7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E1F420-0x0000000182E1F520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E1EB50-0x0000000182E1EC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PushTipsChangeNotify other) {} // 0x0000000182E1E720-0x0000000182E1E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E1E530-0x0000000182E1E660
}

