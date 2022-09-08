/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PushTipsAllDataNotify : MessageBase, IMessage<PushTipsAllDataNotify> // TypeDefIndex: 25780
{
	// Fields
	private static readonly MessageParser<PushTipsAllDataNotify> _parser; // 0x00
	public const int PushTipsListFieldNumber = 1; // Metadata: 0x00B098F7
	private static readonly FieldCodec<PushTipsData> _repeated_pushTipsList_codec; // 0x08
	private readonly RepeatedMessageField<PushTipsData> pushTipsList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PushTipsAllDataNotify> Parser { get => default; } // 0x00000001849B4380-0x00000001849B4410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849B4110-0x00000001849B41A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849B3E40-0x00000001849B3EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849B3860-0x00000001849B38C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849B4770-0x00000001849B4860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849B45C0-0x00000001849B4620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849B41A0-0x00000001849B4290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849B4720-0x00000001849B4770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849B3F60-0x00000001849B4050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PushTipsData> PushTipsList { get => default; } // 0x00000001849B38C0-0x00000001849B3920 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25781
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25782
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2221
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsAllDataNotify() {} // 0x00000001849B4AC0-0x00000001849B4B50
	static PushTipsAllDataNotify() {} // 0x00000001849B49B0-0x00000001849B4AC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsAllDataNotify Clone() => default; // 0x00000001849B4290-0x00000001849B4380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsAllDataNotify ShallowCopy() => default; // 0x00000001849B3EC0-0x00000001849B3F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849B3A50-0x00000001849B3AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849B44A0-0x00000001849B4530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849B4530-0x00000001849B45C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849B3AA0-0x00000001849B3B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849B3B70-0x00000001849B3C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PushTipsAllDataNotify other) => default; // 0x00000001849B3C40-0x00000001849B3D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849B4050-0x00000001849B4110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849B4860-0x00000001849B49B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849B4620-0x00000001849B4720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849B3D50-0x00000001849B3E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PushTipsAllDataNotify other) {} // 0x00000001849B3920-0x00000001849B3A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849B3730-0x00000001849B3860
}

