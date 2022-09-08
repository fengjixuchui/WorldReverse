/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SaveMainCoopReq : MessageBase, IMessage<SaveMainCoopReq> // TypeDefIndex: 22683
{
	// Fields
	private static readonly MessageParser<SaveMainCoopReq> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0223B
	private uint id_; // 0x18
	public const int SavePointIdFieldNumber = 2; // Metadata: 0x00B0223F
	private uint savePointId_; // 0x1C
	public const int SelfConfidenceFieldNumber = 3; // Metadata: 0x00B02243
	private uint selfConfidence_; // 0x20
	public const int NormalVarMapFieldNumber = 4; // Metadata: 0x00B02247
	private static readonly MapField<uint, int> _map_normalVarMap_codec; // 0x08
	private readonly MapField<uint, int> normalVarMap_; // 0x28
	public const int TempVarMapFieldNumber = 5; // Metadata: 0x00B0224B
	private static readonly MapField<uint, int> _map_tempVarMap_codec; // 0x10
	private readonly MapField<uint, int> tempVarMap_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SaveMainCoopReq> Parser { get => default; } // 0x0000000184E64A30-0x0000000184E64AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184E646C0-0x0000000184E64750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184E641C0-0x0000000184E64240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184E637B0-0x0000000184E63810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184E64F30-0x0000000184E65020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184E64C90-0x0000000184E64CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184E647F0-0x0000000184E648E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184E64EE0-0x0000000184E64F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184E642E0-0x0000000184E643D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000184E64120-0x0000000184E641C0 0x0000000184E64AC0-0x0000000184E64B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SavePointId { get => default; set {} } // 0x0000000184E64620-0x0000000184E646C0 0x0000000184E63BE0-0x0000000184E63C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SelfConfidence { get => default; set {} } // 0x0000000184E63B40-0x0000000184E63BE0 0x0000000184E64750-0x0000000184E647F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, int> NormalVarMap { get => default; } // 0x0000000184E648E0-0x0000000184E64940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, int> TempVarMap { get => default; } // 0x0000000184E645C0-0x0000000184E64620 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22684
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22685
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1953
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopReq() {} // 0x0000000184E65520-0x0000000184E655D0
	static SaveMainCoopReq() {} // 0x0000000184E65390-0x0000000184E65520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopReq Clone() => default; // 0x0000000184E64940-0x0000000184E64A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveMainCoopReq ShallowCopy() => default; // 0x0000000184E64240-0x0000000184E642E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184E639B0-0x0000000184E63A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E64BF0-0x0000000184E64C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184E64C40-0x0000000184E64C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184E63A00-0x0000000184E63B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184E63C80-0x0000000184E63D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SaveMainCoopReq other) => default; // 0x0000000184E63D50-0x0000000184E63F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184E643D0-0x0000000184E645C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184E65020-0x0000000184E65390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184E64CF0-0x0000000184E64EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184E63F10-0x0000000184E64120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SaveMainCoopReq other) {} // 0x0000000184E63810-0x0000000184E639B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184E635B0-0x0000000184E637B0
}

