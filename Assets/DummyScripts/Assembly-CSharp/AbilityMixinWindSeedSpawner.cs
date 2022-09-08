/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinWindSeedSpawner : MessageBase, IMessage<AbilityMixinWindSeedSpawner> // TypeDefIndex: 21783
{
	// Fields
	private static readonly MessageParser<AbilityMixinWindSeedSpawner> _parser; // 0x00
	public const int AddSignalFieldNumber = 1; // Metadata: 0x00AFFFE3
	public const int RefreshSeedFieldNumber = 2; // Metadata: 0x00AFFFE7
	public const int CatchSeedFieldNumber = 3; // Metadata: 0x00AFFFEB
	private object cmd_; // 0x18
	private CmdOneofCase cmdCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinWindSeedSpawner> Parser { get => default; } // 0x000000018450A5E0-0x000000018450A670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018450A0D0-0x000000018450A160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184509CB0-0x0000000184509D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184509100-0x0000000184509160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018450AC40-0x000000018450AD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018450A9E0-0x000000018450AA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018450A230-0x000000018450A320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018450ABF0-0x000000018450AC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184509DD0-0x0000000184509EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.AddSignal AddSignal { get => default; set {} } // 0x000000018450A410-0x000000018450A4E0 0x00000001845095C0-0x0000000184509660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.RefreshSeed RefreshSeed { get => default; set {} } // 0x000000018450A000-0x000000018450A0D0 0x000000018450A540-0x000000018450A5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.CatchSeed CatchSeed { get => default; set {} } // 0x000000018450A160-0x000000018450A230 0x0000000184509160-0x0000000184509200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CmdOneofCase CmdCase { get => default; } // 0x000000018450A4E0-0x000000018450A540 

	// Nested types
	public enum CmdOneofCase // TypeDefIndex: 21784
	{
		None = 0,
		AddSignal = 1,
		RefreshSeed = 2,
		CatchSeed = 3
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21785
	{
		// Nested types
		public sealed class AddSignal : MessageBase, IMessage<AddSignal> // TypeDefIndex: 21786
		{
			// Fields
			private static readonly MessageParser<AddSignal> _parser; // 0x00

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<AddSignal> Parser { get => default; } // 0x0000000184520070-0x0000000184520100 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018451FE00-0x000000018451FE90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x000000018451FB50-0x000000018451FBD0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x000000018451F730-0x000000018451F790 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000184520370-0x0000000184520460 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000184520230-0x0000000184520290 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x000000018451FE90-0x000000018451FF80 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000184520320-0x0000000184520370 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x000000018451FC70-0x000000018451FD60 

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddSignal() {} // 0x00000001845205F0-0x0000000184520650
			static AddSignal() {} // 0x0000000184520530-0x00000001845205F0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddSignal Clone() => default; // 0x000000018451FF80-0x0000000184520070
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddSignal ShallowCopy() => default; // 0x000000018451FBD0-0x000000018451FC70
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x000000018451F870-0x000000018451F8C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184520190-0x00000001845201E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845201E0-0x0000000184520230
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x000000018451F8C0-0x000000018451F910
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x000000018451F9E0-0x000000018451FAB0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(AddSignal other) => default; // 0x000000018451F910-0x000000018451F9E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x000000018451FD60-0x000000018451FE00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000184520460-0x0000000184520530
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000184520290-0x0000000184520320
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x000000018451FAB0-0x000000018451FB50
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(AddSignal other) {} // 0x000000018451F790-0x000000018451F870
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x000000018451F660-0x000000018451F730
		}

		public sealed class RefreshSeed : MessageBase, IMessage<RefreshSeed> // TypeDefIndex: 21787
		{
			// Fields
			private static readonly MessageParser<RefreshSeed> _parser; // 0x00
			public const int PosListFieldNumber = 1; // Metadata: 0x00AFFFFF
			private static readonly FieldCodec<Vector> _repeated_posList_codec; // 0x08
			private readonly RepeatedMessageField<Vector> posList_; // 0x18

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<RefreshSeed> Parser { get => default; } // 0x00000001845212A0-0x0000000184521330 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184520FD0-0x0000000184521060 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000184520D00-0x0000000184520D80 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000184520780-0x00000001845207E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000184521690-0x0000000184521780 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001845214E0-0x0000000184521540 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001845210C0-0x00000001845211B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000184521640-0x0000000184521690 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000184520E20-0x0000000184520F10 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedMessageField<Vector> PosList { get => default; } // 0x0000000184521060-0x00000001845210C0 

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshSeed() {} // 0x00000001845219E0-0x0000000184521A70
			static RefreshSeed() {} // 0x00000001845218D0-0x00000001845219E0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshSeed Clone() => default; // 0x00000001845211B0-0x00000001845212A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshSeed ShallowCopy() => default; // 0x0000000184520D80-0x0000000184520E20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000184520910-0x0000000184520960
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845213C0-0x0000000184521450
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184521450-0x00000001845214E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000184520960-0x0000000184520A30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000184520B40-0x0000000184520C10
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(RefreshSeed other) => default; // 0x0000000184520A30-0x0000000184520B40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000184520F10-0x0000000184520FD0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000184521780-0x00000001845218D0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000184521540-0x0000000184521640
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000184520C10-0x0000000184520D00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(RefreshSeed other) {} // 0x00000001845207E0-0x0000000184520910
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000184520650-0x0000000184520780
		}

		public sealed class CatchSeed : MessageBase, IMessage<CatchSeed> // TypeDefIndex: 21788
		{
			// Fields
			private static readonly MessageParser<CatchSeed> _parser; // 0x00
			public const int EntityIdFieldNumber = 1; // Metadata: 0x00B00003
			private uint entityId_; // 0x18

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<CatchSeed> Parser { get => default; } // 0x0000000184502170-0x0000000184502200 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184501F00-0x0000000184501F90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000184501C10-0x0000000184501C90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000184501720-0x0000000184501780 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000184502560-0x0000000184502650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001845023D0-0x0000000184502430 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000184501F90-0x0000000184502080 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000184502510-0x0000000184502560 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000184501D30-0x0000000184501E20 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint EntityId { get => default; set {} } // 0x0000000184502330-0x00000001845023D0 0x0000000184502650-0x00000001845026F0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CatchSeed() {} // 0x0000000184502920-0x0000000184502980
			static CatchSeed() {} // 0x0000000184502860-0x0000000184502920

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CatchSeed Clone() => default; // 0x0000000184502080-0x0000000184502170
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CatchSeed ShallowCopy() => default; // 0x0000000184501C90-0x0000000184501D30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000184501890-0x00000001845018E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184502290-0x00000001845022E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845022E0-0x0000000184502330
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001845018E0-0x0000000184501950
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000184501950-0x0000000184501A20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(CatchSeed other) => default; // 0x0000000184501A20-0x0000000184501B20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000184501E20-0x0000000184501F00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001845026F0-0x0000000184502860
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000184502430-0x0000000184502510
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000184501B20-0x0000000184501C10
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(CatchSeed other) {} // 0x0000000184501780-0x0000000184501890
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000184501640-0x0000000184501720
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindSeedSpawner() {} // 0x000000018450B0A0-0x000000018450B110
	static AbilityMixinWindSeedSpawner() {} // 0x000000018450AFE0-0x000000018450B0A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindSeedSpawner Clone() => default; // 0x000000018450A320-0x000000018450A410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinWindSeedSpawner ShallowCopy() => default; // 0x0000000184509D30-0x0000000184509DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845093E0-0x0000000184509560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018450A700-0x000000018450A870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018450A870-0x000000018450A9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184509560-0x00000001845095C0
	public void resetCmd() {} // 0x0000000184509A30-0x0000000184509CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearCmd() {} // 0x000000018450AA40-0x000000018450AAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184509660-0x0000000184509730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinWindSeedSpawner other) => default; // 0x0000000184509730-0x00000001845098C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184509EC0-0x000000018450A000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018450AD30-0x000000018450AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018450AAA0-0x000000018450ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845098C0-0x0000000184509A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinWindSeedSpawner other) {} // 0x0000000184509200-0x00000001845093E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184508E90-0x0000000184509100
}

