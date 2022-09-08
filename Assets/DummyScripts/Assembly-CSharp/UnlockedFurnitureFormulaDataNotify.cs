/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockedFurnitureFormulaDataNotify : MessageBase, IMessage<UnlockedFurnitureFormulaDataNotify> // TypeDefIndex: 23414
{
	// Fields
	private static readonly MessageParser<UnlockedFurnitureFormulaDataNotify> _parser; // 0x00
	public const int IsAllFieldNumber = 1; // Metadata: 0x00B03F9B
	private bool isAll_; // 0x18
	public const int FurnitureIdListFieldNumber = 2; // Metadata: 0x00B03F9F
	private static readonly FieldCodec<uint> _repeated_furnitureIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> furnitureIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockedFurnitureFormulaDataNotify> Parser { get => default; } // 0x000000018183A150-0x000000018183A1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181839EE0-0x0000000181839F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181839B70-0x0000000181839BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181839480-0x00000001818394E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018183A500-0x000000018183A5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018183A310-0x000000018183A370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181839F70-0x000000018183A060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018183A4B0-0x000000018183A500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181839CF0-0x0000000181839DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAll { get => default; set {} } // 0x0000000181839580-0x0000000181839620 0x00000001818394E0-0x0000000181839580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FurnitureIdList { get => default; } // 0x0000000181839BF0-0x0000000181839C50 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23415
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23416
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4491
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureFormulaDataNotify() {} // 0x000000018183A8B0-0x000000018183A940
	static UnlockedFurnitureFormulaDataNotify() {} // 0x000000018183A7D0-0x000000018183A8B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureFormulaDataNotify Clone() => default; // 0x000000018183A060-0x000000018183A150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureFormulaDataNotify ShallowCopy() => default; // 0x0000000181839C50-0x0000000181839CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181839750-0x00000001818397A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018183A270-0x000000018183A2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018183A2C0-0x000000018183A310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818397A0-0x0000000181839860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181839860-0x0000000181839930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockedFurnitureFormulaDataNotify other) => default; // 0x0000000181839930-0x0000000181839A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181839DE0-0x0000000181839EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018183A5F0-0x000000018183A7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018183A370-0x000000018183A4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181839A60-0x0000000181839B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockedFurnitureFormulaDataNotify other) {} // 0x0000000181839620-0x0000000181839750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181839310-0x0000000181839480
}

