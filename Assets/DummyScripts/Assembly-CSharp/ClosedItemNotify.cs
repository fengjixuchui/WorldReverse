/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClosedItemNotify : MessageBase, IMessage<ClosedItemNotify> // TypeDefIndex: 23785
{
	// Fields
	private static readonly MessageParser<ClosedItemNotify> _parser; // 0x00
	public const int ItemIdListFieldNumber = 1; // Metadata: 0x00B04D23
	private static readonly FieldCodec<uint> _repeated_itemIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> itemIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClosedItemNotify> Parser { get => default; } // 0x00000001834E51E0-0x00000001834E5270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001834E4F10-0x00000001834E4FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001834E4C40-0x00000001834E4CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834E4700-0x00000001834E4760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001834E5550-0x00000001834E5640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834E53A0-0x00000001834E5400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001834E4FA0-0x00000001834E5090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834E5500-0x00000001834E5550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001834E4D60-0x00000001834E4E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemIdList { get => default; } // 0x00000001834E5180-0x00000001834E51E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23786
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23787
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 668
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClosedItemNotify() {} // 0x00000001834E5870-0x00000001834E5900
	static ClosedItemNotify() {} // 0x00000001834E5790-0x00000001834E5870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClosedItemNotify Clone() => default; // 0x00000001834E5090-0x00000001834E5180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClosedItemNotify ShallowCopy() => default; // 0x00000001834E4CC0-0x00000001834E4D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834E4870-0x00000001834E48C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834E5300-0x00000001834E5350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834E5350-0x00000001834E53A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001834E48C0-0x00000001834E4980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001834E4A80-0x00000001834E4B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClosedItemNotify other) => default; // 0x00000001834E4980-0x00000001834E4A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001834E4E50-0x00000001834E4F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834E5640-0x00000001834E5790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834E5400-0x00000001834E5500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001834E4B50-0x00000001834E4C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClosedItemNotify other) {} // 0x00000001834E4760-0x00000001834E4870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834E45C0-0x00000001834E4700
}

