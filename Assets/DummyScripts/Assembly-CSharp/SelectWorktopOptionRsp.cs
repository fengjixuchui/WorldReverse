/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectWorktopOptionRsp : MessageBase, IMessage<SelectWorktopOptionRsp> // TypeDefIndex: 23191
{
	// Fields
	private static readonly MessageParser<SelectWorktopOptionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0371B
	private int retcode_; // 0x18
	public const int GadgetEntityIdFieldNumber = 2; // Metadata: 0x00B0371F
	private uint gadgetEntityId_; // 0x1C
	public const int OptionIdFieldNumber = 3; // Metadata: 0x00B03723
	private uint optionId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectWorktopOptionRsp> Parser { get => default; } // 0x000000018237FC70-0x000000018237FD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018237FA00-0x000000018237FA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018237F620-0x000000018237F6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018237ED80-0x000000018237EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823800E0-0x00000001823801D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018237FE30-0x000000018237FE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018237FA90-0x000000018237FB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182380090-0x00000001823800E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018237F7E0-0x000000018237F8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018237F580-0x000000018237F620 0x000000018237F150-0x000000018237F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x000000018237FE90-0x000000018237FF30 0x000000018237EDE0-0x000000018237EE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OptionId { get => default; set {} } // 0x000000018237F740-0x000000018237F7E0 0x000000018237EFE0-0x000000018237F080

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23192
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23193
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 806
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionRsp() {} // 0x0000000182380520-0x0000000182380580
	static SelectWorktopOptionRsp() {} // 0x0000000182380460-0x0000000182380520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionRsp Clone() => default; // 0x000000018237FB80-0x000000018237FC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionRsp ShallowCopy() => default; // 0x000000018237F6A0-0x000000018237F740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018237F080-0x000000018237F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018237FD90-0x000000018237FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018237FDE0-0x000000018237FE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018237F0D0-0x000000018237F150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018237F1F0-0x000000018237F2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectWorktopOptionRsp other) => default; // 0x000000018237F2C0-0x000000018237F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018237F8D0-0x000000018237FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823801D0-0x0000000182380460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018237FF30-0x0000000182380090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018237F400-0x000000018237F580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectWorktopOptionRsp other) {} // 0x000000018237EE80-0x000000018237EFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018237EC70-0x000000018237ED80
}

