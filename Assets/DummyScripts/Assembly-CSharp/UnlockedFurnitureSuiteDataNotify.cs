/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockedFurnitureSuiteDataNotify : MessageBase, IMessage<UnlockedFurnitureSuiteDataNotify> // TypeDefIndex: 23417
{
	// Fields
	private static readonly MessageParser<UnlockedFurnitureSuiteDataNotify> _parser; // 0x00
	public const int IsAllFieldNumber = 1; // Metadata: 0x00B03FB3
	private bool isAll_; // 0x18
	public const int FurnitureSuiteIdListFieldNumber = 2; // Metadata: 0x00B03FB7
	private static readonly FieldCodec<uint> _repeated_furnitureSuiteIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> furnitureSuiteIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockedFurnitureSuiteDataNotify> Parser { get => default; } // 0x0000000181FC0AF0-0x0000000181FC0B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FC0880-0x0000000181FC0910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FC0570-0x0000000181FC05F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FBFE80-0x0000000181FBFEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FC0F00-0x0000000181FC0FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FC0D10-0x0000000181FC0D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FC0910-0x0000000181FC0A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FC0EB0-0x0000000181FC0F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FC0690-0x0000000181FC0780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAll { get => default; set {} } // 0x0000000181FBFF80-0x0000000181FC0020 0x0000000181FBFEE0-0x0000000181FBFF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FurnitureSuiteIdList { get => default; } // 0x0000000181FC0B80-0x0000000181FC0BE0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23418
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23419
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4492
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureSuiteDataNotify() {} // 0x0000000181FC12B0-0x0000000181FC1340
	static UnlockedFurnitureSuiteDataNotify() {} // 0x0000000181FC11D0-0x0000000181FC12B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureSuiteDataNotify Clone() => default; // 0x0000000181FC0A00-0x0000000181FC0AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockedFurnitureSuiteDataNotify ShallowCopy() => default; // 0x0000000181FC05F0-0x0000000181FC0690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FC0150-0x0000000181FC01A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FC0C70-0x0000000181FC0CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FC0CC0-0x0000000181FC0D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FC01A0-0x0000000181FC0260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FC0390-0x0000000181FC0460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockedFurnitureSuiteDataNotify other) => default; // 0x0000000181FC0260-0x0000000181FC0390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FC0780-0x0000000181FC0880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FC0FF0-0x0000000181FC11D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FC0D70-0x0000000181FC0EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FC0460-0x0000000181FC0570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockedFurnitureSuiteDataNotify other) {} // 0x0000000181FC0020-0x0000000181FC0150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FBFD10-0x0000000181FBFE80
}

