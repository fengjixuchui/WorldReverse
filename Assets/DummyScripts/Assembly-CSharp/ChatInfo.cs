/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatInfo : MessageBase, IMessage<ChatInfo> // TypeDefIndex: 25245
{
	// Fields
	private static readonly MessageParser<ChatInfo> _parser; // 0x00
	public const int TimeFieldNumber = 1; // Metadata: 0x00B084AB
	private uint time_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B084AF
	private uint uid_; // 0x1C
	public const int SequenceFieldNumber = 3; // Metadata: 0x00B084B3
	private uint sequence_; // 0x20
	public const int TextFieldNumber = 100; // Metadata: 0x00B084B7
	public const int IconFieldNumber = 101; // Metadata: 0x00B084BB
	public const int SystemHintFieldNumber = 102; // Metadata: 0x00B084BF
	public const int ToUidFieldNumber = 4; // Metadata: 0x00B084C3
	private uint toUid_; // 0x24
	public const int IsReadFieldNumber = 5; // Metadata: 0x00B084C7
	private bool isRead_; // 0x28
	private object content_; // 0x30
	private ContentOneofCase contentCase_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChatInfo> Parser { get => default; } // 0x000000018327A530-0x000000018327A5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018327A0C0-0x000000018327A150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832799E0-0x0000000183279A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183278B00-0x0000000183278B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018327AC50-0x000000018327AD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018327A7D0-0x000000018327A830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018327A1F0-0x000000018327A2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018327AC00-0x000000018327AC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183279C40-0x0000000183279D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Time { get => default; set {} } // 0x000000018327A490-0x000000018327A530 0x0000000183278B60-0x0000000183278C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001832798A0-0x0000000183279940 0x000000018327A150-0x000000018327A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Sequence { get => default; set {} } // 0x00000001832790E0-0x0000000183279180 0x0000000183279F50-0x0000000183279FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Text { get => default; set {} } // 0x0000000183279FF0-0x000000018327A0C0 0x000000018327A3D0-0x000000018327A490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Icon { get => default; set {} } // 0x0000000183279180-0x0000000183279250 0x0000000183278C00-0x0000000183278CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.SystemHint SystemHint { get => default; set {} } // 0x0000000183278A30-0x0000000183278B00 0x0000000183278990-0x0000000183278A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ToUid { get => default; set {} } // 0x0000000183279940-0x00000001832799E0 0x000000018327AB60-0x000000018327AC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRead { get => default; set {} } // 0x000000018327AAC0-0x000000018327AB60 0x0000000183278CB0-0x0000000183278D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ContentOneofCase ContentCase { get => default; } // 0x000000018327AD40-0x000000018327ADA0 

	// Nested types
	public enum ContentOneofCase // TypeDefIndex: 25246
	{
		None = 0,
		Text = 100,
		Icon = 101,
		SystemHint = 102
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25247
	{
		// Nested types
		public enum SystemHintType // TypeDefIndex: 25248
		{
			ChatNone = 0,
			ChatEnterWorld = 1,
			ChatLeaveWorld = 2
		}

		public sealed class SystemHint : MessageBase, IMessage<SystemHint> // TypeDefIndex: 25249
		{
			// Fields
			private static readonly MessageParser<SystemHint> _parser; // 0x00
			public const int TypeFieldNumber = 1; // Metadata: 0x00B084E7
			private uint type_; // 0x18

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<SystemHint> Parser { get => default; } // 0x000000018326FEE0-0x000000018326FF70 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018326FC70-0x000000018326FD00 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x000000018326F980-0x000000018326FA00 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x000000018326F490-0x000000018326F4F0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001832702D0-0x00000001832703C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001832700A0-0x0000000183270100 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x000000018326FD00-0x000000018326FDF0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x00000001832701E0-0x0000000183270230 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x000000018326FAA0-0x000000018326FB90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint Type { get => default; set {} } // 0x000000018326F310-0x000000018326F3B0 0x0000000183270230-0x00000001832702D0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public SystemHint() {} // 0x00000001832705F0-0x0000000183270650
			static SystemHint() {} // 0x0000000183270530-0x00000001832705F0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public SystemHint Clone() => default; // 0x000000018326FDF0-0x000000018326FEE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public SystemHint ShallowCopy() => default; // 0x000000018326FA00-0x000000018326FAA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x000000018326F600-0x000000018326F650
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183270000-0x0000000183270050
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183270050-0x00000001832700A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x000000018326F650-0x000000018326F6C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x000000018326F6C0-0x000000018326F790
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(SystemHint other) => default; // 0x000000018326F790-0x000000018326F890
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x000000018326FB90-0x000000018326FC70
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001832703C0-0x0000000183270530
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000183270100-0x00000001832701E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x000000018326F890-0x000000018326F980
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(SystemHint other) {} // 0x000000018326F4F0-0x000000018326F600
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x000000018326F3B0-0x000000018326F490
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo() {} // 0x000000018327B440-0x000000018327B4B0
	static ChatInfo() {} // 0x000000018327B380-0x000000018327B440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo Clone() => default; // 0x000000018327A2E0-0x000000018327A3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChatInfo ShallowCopy() => default; // 0x0000000183279A60-0x0000000183279B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183279020-0x00000001832790E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018327A650-0x000000018327A710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018327A710-0x000000018327A7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183279250-0x0000000183279300
	public void resetContent() {} // 0x0000000183279B00-0x0000000183279C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearContent() {} // 0x0000000183278D50-0x0000000183278DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183279530-0x0000000183279600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChatInfo other) => default; // 0x0000000183279300-0x0000000183279530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183279D30-0x0000000183279F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018327ADA0-0x000000018327B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018327A830-0x000000018327AAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183279600-0x00000001832798A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChatInfo other) {} // 0x0000000183278DB0-0x0000000183279020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183278740-0x0000000183278990
}

