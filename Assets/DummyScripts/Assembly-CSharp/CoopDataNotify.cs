/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopDataNotify : MessageBase, IMessage<CoopDataNotify> // TypeDefIndex: 22705
{
	// Fields
	private static readonly MessageParser<CoopDataNotify> _parser; // 0x00
	public const int ChapterListFieldNumber = 1; // Metadata: 0x00B02323
	private static readonly FieldCodec<CoopChapter> _repeated_chapterList_codec; // 0x08
	private readonly RepeatedMessageField<CoopChapter> chapterList_; // 0x18
	public const int IsHaveProgressFieldNumber = 2; // Metadata: 0x00B02327
	private bool isHaveProgress_; // 0x20
	public const int CurCoopPointFieldNumber = 3; // Metadata: 0x00B0232B
	private uint curCoopPoint_; // 0x24
	public const int ViewedChapterListFieldNumber = 4; // Metadata: 0x00B0232F
	private static readonly FieldCodec<uint> _repeated_viewedChapterList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> viewedChapterList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopDataNotify> Parser { get => default; } // 0x00000001849C72C0-0x00000001849C7350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849C6F50-0x00000001849C6FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849C6B50-0x00000001849C6BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849C62B0-0x00000001849C6310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849C7830-0x00000001849C7920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849C7500-0x00000001849C7560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849C6FE0-0x00000001849C70D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849C77E0-0x00000001849C7830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849C6C70-0x00000001849C6D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CoopChapter> ChapterList { get => default; } // 0x00000001849C63B0-0x00000001849C6410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsHaveProgress { get => default; set {} } // 0x00000001849C71C0-0x00000001849C7260 0x00000001849C7740-0x00000001849C77E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurCoopPoint { get => default; set {} } // 0x00000001849C6310-0x00000001849C63B0 0x00000001849C6EB0-0x00000001849C6F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ViewedChapterList { get => default; } // 0x00000001849C7260-0x00000001849C72C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22706
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22707
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1957
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopDataNotify() {} // 0x00000001849C7D30-0x00000001849C7DE0
	static CoopDataNotify() {} // 0x00000001849C7C00-0x00000001849C7D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopDataNotify Clone() => default; // 0x00000001849C70D0-0x00000001849C71C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopDataNotify ShallowCopy() => default; // 0x00000001849C6BD0-0x00000001849C6C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849C65C0-0x00000001849C6610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C73E0-0x00000001849C7470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849C7470-0x00000001849C7500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849C6610-0x00000001849C6760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849C68D0-0x00000001849C69A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopDataNotify other) => default; // 0x00000001849C6760-0x00000001849C68D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849C6D60-0x00000001849C6EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849C7920-0x00000001849C7C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849C7560-0x00000001849C7740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849C69A0-0x00000001849C6B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopDataNotify other) {} // 0x00000001849C6410-0x00000001849C65C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849C60C0-0x00000001849C62B0
}

