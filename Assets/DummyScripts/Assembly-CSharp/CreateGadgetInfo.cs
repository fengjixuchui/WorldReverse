/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CreateGadgetInfo : MessageBase, IMessage<CreateGadgetInfo> // TypeDefIndex: 26055
{
	// Fields
	private static readonly MessageParser<CreateGadgetInfo> _parser; // 0x00
	public const int BornTypeFieldNumber = 1; // Metadata: 0x00B0AEB3
	private GadgetBornType bornType_; // 0x18
	public const int ChestFieldNumber = 2; // Metadata: 0x00B0AEB7
	private Types.Chest chest_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CreateGadgetInfo> Parser { get => default; } // 0x000000018165A740-0x000000018165A7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018165A390-0x000000018165A420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181659FC0-0x000000018165A040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181659890-0x00000001816598F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018165AC70-0x000000018165AD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018165AAA0-0x000000018165AB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018165A560-0x000000018165A650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018165AC20-0x000000018165AC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018165A0E0-0x000000018165A1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetBornType BornType { get => default; set {} } // 0x000000018165A4C0-0x000000018165A560 0x000000018165AA00-0x000000018165AAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Chest Chest { get => default; set {} } // 0x000000018165A420-0x000000018165A4C0 0x000000018165A8E0-0x000000018165A980

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26056
	{
		// Nested types
		public sealed class Chest : MessageBase, IMessage<Chest> // TypeDefIndex: 26057
		{
			// Fields
			private static readonly MessageParser<Chest> _parser; // 0x00
			public const int ChestDropIdFieldNumber = 1; // Metadata: 0x00B0AEBB
			private uint chestDropId_; // 0x18
			public const int IsShowCutsceneFieldNumber = 2; // Metadata: 0x00B0AEBF
			private bool isShowCutscene_; // 0x1C

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<Chest> Parser { get => default; } // 0x00000001816581D0-0x0000000181658260 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181657F60-0x0000000181657FF0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000181657C40-0x0000000181657CC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000181657520-0x0000000181657580 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000181658560-0x0000000181658650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000181658390-0x00000001816583F0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000181657FF0-0x00000001816580E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000181658510-0x0000000181658560 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000181657D60-0x0000000181657E50 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ChestDropId { get => default; set {} } // 0x0000000181657BA0-0x0000000181657C40 0x0000000181657620-0x00000001816576C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool IsShowCutscene { get => default; set {} } // 0x0000000181657580-0x0000000181657620 0x0000000181657480-0x0000000181657520

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Chest() {} // 0x0000000181658910-0x00000001816589F0
			static Chest() {} // 0x0000000181658850-0x0000000181658910

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Chest Clone() => default; // 0x00000001816580E0-0x00000001816581D0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Chest ShallowCopy() => default; // 0x0000000181657CC0-0x0000000181657D60
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001816577F0-0x0000000181657840
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816582F0-0x0000000181658340
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181658340-0x0000000181658390
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000181657840-0x00000001816578B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001816579D0-0x0000000181657AA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(Chest other) => default; // 0x00000001816578B0-0x00000001816579D0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000181657E50-0x0000000181657F60
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000181658650-0x0000000181658850
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001816583F0-0x0000000181658510
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000181657AA0-0x0000000181657BA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(Chest other) {} // 0x00000001816576C0-0x00000001816577F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000181657380-0x0000000181657480
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateGadgetInfo() {} // 0x000000018165B000-0x000000018165B070
	static CreateGadgetInfo() {} // 0x000000018165AF40-0x000000018165B000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateGadgetInfo Clone() => default; // 0x000000018165A650-0x000000018165A740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateGadgetInfo ShallowCopy() => default; // 0x000000018165A040-0x000000018165A0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181659A70-0x0000000181659AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018165A860-0x000000018165A8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018165A980-0x000000018165AA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181659AF0-0x0000000181659C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181659D50-0x0000000181659E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CreateGadgetInfo other) => default; // 0x0000000181659C20-0x0000000181659D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018165A1D0-0x000000018165A390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018165AD60-0x000000018165AF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018165AB00-0x000000018165AC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181659E20-0x0000000181659FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CreateGadgetInfo other) {} // 0x00000001816598F0-0x0000000181659A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181659760-0x0000000181659890
}

