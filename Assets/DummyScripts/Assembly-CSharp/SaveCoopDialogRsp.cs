/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SaveCoopDialogRsp : MessageBase, IMessage<SaveCoopDialogRsp> // TypeDefIndex: 22750
{
	// Fields
	private static readonly MessageParser<SaveCoopDialogRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0248F
	private int retcode_; // 0x18
	public const int MainCoopIdFieldNumber = 2; // Metadata: 0x00B02493
	private uint mainCoopId_; // 0x1C
	public const int DialogIdFieldNumber = 3; // Metadata: 0x00B02497
	private uint dialogId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SaveCoopDialogRsp> Parser { get => default; } // 0x000000018360BAB0-0x000000018360BB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018360B7A0-0x000000018360B830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018360B460-0x000000018360B4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018360AB20-0x000000018360AB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018360BE80-0x000000018360BF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018360BC70-0x000000018360BCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018360B8D0-0x000000018360B9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018360BE30-0x000000018360BE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018360B580-0x000000018360B670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018360B3C0-0x000000018360B460 0x000000018360AE50-0x000000018360AEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MainCoopId { get => default; set {} } // 0x000000018360AEF0-0x000000018360AF90 0x000000018360B320-0x000000018360B3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DialogId { get => default; set {} } // 0x000000018360B830-0x000000018360B8D0 0x000000018360AB80-0x000000018360AC20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22751
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22752
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1972
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogRsp() {} // 0x000000018360C2C0-0x000000018360C320
	static SaveCoopDialogRsp() {} // 0x000000018360C200-0x000000018360C2C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogRsp Clone() => default; // 0x000000018360B9C0-0x000000018360BAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SaveCoopDialogRsp ShallowCopy() => default; // 0x000000018360B4E0-0x000000018360B580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018360AD80-0x000000018360ADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018360BBD0-0x000000018360BC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018360BC20-0x000000018360BC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018360ADD0-0x000000018360AE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018360AF90-0x000000018360B060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SaveCoopDialogRsp other) => default; // 0x000000018360B060-0x000000018360B1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018360B670-0x000000018360B7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018360BF70-0x000000018360C200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018360BCD0-0x000000018360BE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018360B1A0-0x000000018360B320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SaveCoopDialogRsp other) {} // 0x000000018360AC20-0x000000018360AD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018360AA10-0x000000018360AB20
}

