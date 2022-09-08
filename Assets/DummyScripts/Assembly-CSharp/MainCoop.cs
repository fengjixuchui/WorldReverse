/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MainCoop : MessageBase, IMessage<MainCoop> // TypeDefIndex: 22674
{
	// Fields
	private static readonly MessageParser<MainCoop> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B021EB
	private uint id_; // 0x18
	public const int StatusFieldNumber = 2; // Metadata: 0x00B021EF
	private Types.Status status_; // 0x1C
	public const int SavePointIdListFieldNumber = 3; // Metadata: 0x00B021F3
	private static readonly FieldCodec<uint> _repeated_savePointIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> savePointIdList_; // 0x20
	public const int SelfConfidenceFieldNumber = 4; // Metadata: 0x00B021F7
	private uint selfConfidence_; // 0x28
	public const int NormalVarMapFieldNumber = 5; // Metadata: 0x00B021FB
	private static readonly MapField<uint, int> _map_normalVarMap_codec; // 0x10
	private readonly MapField<uint, int> normalVarMap_; // 0x30
	public const int TempVarMapFieldNumber = 6; // Metadata: 0x00B021FF
	private static readonly MapField<uint, int> _map_tempVarMap_codec; // 0x18
	private readonly MapField<uint, int> tempVarMap_; // 0x38
	public const int SeenEndingMapFieldNumber = 7; // Metadata: 0x00B02203
	private static readonly MapField<uint, uint> _map_seenEndingMap_codec; // 0x20
	private readonly MapField<uint, uint> seenEndingMap_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MainCoop> Parser { get => default; } // 0x00000001846C91C0-0x00000001846C9250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846C8DF0-0x00000001846C8E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001846C8770-0x00000001846C87F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846C7C20-0x00000001846C7C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846C97B0-0x00000001846C98A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846C9480-0x00000001846C94E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846C8F20-0x00000001846C9010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846C9760-0x00000001846C97B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846C8930-0x00000001846C8A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001846C86D0-0x00000001846C8770 0x00000001846C9250-0x00000001846C92F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Status Status { get => default; set {} } // 0x00000001846C8890-0x00000001846C8930 0x00000001846C8CF0-0x00000001846C8D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SavePointIdList { get => default; } // 0x00000001846C9420-0x00000001846C9480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SelfConfidence { get => default; set {} } // 0x00000001846C80A0-0x00000001846C8140 0x00000001846C8E80-0x00000001846C8F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, int> NormalVarMap { get => default; } // 0x00000001846C9010-0x00000001846C9070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, int> TempVarMap { get => default; } // 0x00000001846C8D90-0x00000001846C8DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SeenEndingMap { get => default; } // 0x00000001846C9160-0x00000001846C91C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22675
	{
		// Nested types
		public enum Status // TypeDefIndex: 22676
		{
			Invalid = 0,
			Running = 1,
			Finished = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MainCoop() {} // 0x00000001846C9F00-0x00000001846CA000
	static MainCoop() {} // 0x00000001846C9CF0-0x00000001846C9F00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MainCoop Clone() => default; // 0x00000001846C9070-0x00000001846C9160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MainCoop ShallowCopy() => default; // 0x00000001846C87F0-0x00000001846C8890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001846C7E60-0x00000001846C7EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846C9380-0x00000001846C93D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846C93D0-0x00000001846C9420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846C7EB0-0x00000001846C80A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846C8140-0x00000001846C8210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MainCoop other) => default; // 0x00000001846C8210-0x00000001846C8440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846C8A20-0x00000001846C8CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846C98A0-0x00000001846C9CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846C94E0-0x00000001846C9760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001846C8440-0x00000001846C86D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MainCoop other) {} // 0x00000001846C7C80-0x00000001846C7E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846C7950-0x00000001846C7C20
}

