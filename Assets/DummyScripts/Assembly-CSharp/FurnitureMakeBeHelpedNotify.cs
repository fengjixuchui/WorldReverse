/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeBeHelpedNotify : MessageBase, IMessage<FurnitureMakeBeHelpedNotify> // TypeDefIndex: 23472
{
	// Fields
	private static readonly MessageParser<FurnitureMakeBeHelpedNotify> _parser; // 0x00
	public const int FurnitureMakeHelpedDataFieldNumber = 1; // Metadata: 0x00B04197
	private FurnitureMakeBeHelpedData furnitureMakeHelpedData_; // 0x18
	public const int FurnitureMakeSlotFieldNumber = 2; // Metadata: 0x00B0419B
	private FurnitureMakeSlot furnitureMakeSlot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeBeHelpedNotify> Parser { get => default; } // 0x0000000183E00B60-0x0000000183E00BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E00850-0x0000000183E008E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E003B0-0x0000000183E00430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DFFAE0-0x0000000183DFFB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E01000-0x0000000183E010F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E00E40-0x0000000183E00EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E00980-0x0000000183E00A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E00FB0-0x0000000183E01000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E004D0-0x0000000183E005C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedData FurnitureMakeHelpedData { get => default; set {} } // 0x0000000183DFFA40-0x0000000183DFFAE0 0x0000000183E008E0-0x0000000183E00980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeSlot FurnitureMakeSlot { get => default; set {} } // 0x0000000183E00D10-0x0000000183E00DB0 0x0000000183E007B0-0x0000000183E00850

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23473
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23474
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4610
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedNotify() {} // 0x0000000183E01370-0x0000000183E013D0
	static FurnitureMakeBeHelpedNotify() {} // 0x0000000183E012B0-0x0000000183E01370

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedNotify Clone() => default; // 0x0000000183E00A70-0x0000000183E00B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeBeHelpedNotify ShallowCopy() => default; // 0x0000000183E00430-0x0000000183E004D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DFFD20-0x0000000183DFFDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E00C80-0x0000000183E00D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E00DB0-0x0000000183E00E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DFFDB0-0x0000000183DFFF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DFFF90-0x0000000183E00060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeBeHelpedNotify other) => default; // 0x0000000183E00060-0x0000000183E001A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E005C0-0x0000000183E007B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E010F0-0x0000000183E012B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E00EA0-0x0000000183E00FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E001A0-0x0000000183E003B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeBeHelpedNotify other) {} // 0x0000000183DFFB40-0x0000000183DFFD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DFF8D0-0x0000000183DFFA40
}

