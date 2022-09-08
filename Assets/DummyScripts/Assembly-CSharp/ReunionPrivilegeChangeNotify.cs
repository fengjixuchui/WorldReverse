/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionPrivilegeChangeNotify : MessageBase, IMessage<ReunionPrivilegeChangeNotify> // TypeDefIndex: 24864
{
	// Fields
	private static readonly MessageParser<ReunionPrivilegeChangeNotify> _parser; // 0x00
	public const int PrivilegeInfoFieldNumber = 1; // Metadata: 0x00B07683
	private ReunionPrivilegeInfo privilegeInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionPrivilegeChangeNotify> Parser { get => default; } // 0x000000018561AC10-0x000000018561ACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018561A900-0x000000018561A990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018561A5A0-0x000000018561A620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185619E70-0x0000000185619ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018561AFC0-0x000000018561B0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018561AE30-0x000000018561AE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018561A990-0x000000018561AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018561AF70-0x000000018561AFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018561A6C0-0x000000018561A7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeInfo PrivilegeInfo { get => default; set {} } // 0x000000018561A1D0-0x000000018561A270 0x000000018561AB70-0x000000018561AC10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24865
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24866
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5070
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeChangeNotify() {} // 0x000000018561B2C0-0x000000018561B320
	static ReunionPrivilegeChangeNotify() {} // 0x000000018561B200-0x000000018561B2C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeChangeNotify Clone() => default; // 0x000000018561AA80-0x000000018561AB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeChangeNotify ShallowCopy() => default; // 0x000000018561A620-0x000000018561A6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018561A030-0x000000018561A0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018561AD30-0x000000018561ADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018561ADB0-0x000000018561AE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018561A0B0-0x000000018561A1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018561A380-0x000000018561A450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionPrivilegeChangeNotify other) => default; // 0x000000018561A270-0x000000018561A380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018561A7B0-0x000000018561A900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018561B0B0-0x000000018561B200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018561AE90-0x000000018561AF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018561A450-0x000000018561A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionPrivilegeChangeNotify other) {} // 0x0000000185619ED0-0x000000018561A030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185619D60-0x0000000185619E70
}

