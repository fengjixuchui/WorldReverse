/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombatInvokeEntry : MessageBase, IMessage<CombatInvokeEntry> // TypeDefIndex: 23126
{
	// Fields
	private static readonly MessageParser<CombatInvokeEntry> _parser; // 0x00
	public const int ArgumentTypeFieldNumber = 1; // Metadata: 0x00B033F7
	private CombatTypeArgument argumentType_; // 0x18
	public const int ForwardTypeFieldNumber = 2; // Metadata: 0x00B033FB
	private ForwardType forwardType_; // 0x1C
	public const int CombatDataFieldNumber = 3; // Metadata: 0x00B033FF
	private ByteString combatData_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombatInvokeEntry> Parser { get => default; } // 0x0000000182644960-0x00000001826449F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182644650-0x00000001826446E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182644270-0x00000001826442F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826439C0-0x0000000182643A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182644DE0-0x0000000182644ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182644B20-0x0000000182644B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182644780-0x0000000182644870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182644CF0-0x0000000182644D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182644390-0x0000000182644480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatTypeArgument ArgumentType { get => default; set {} } // 0x0000000182644D40-0x0000000182644DE0 0x00000001826446E0-0x0000000182644780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x00000001826441D0-0x0000000182644270 0x0000000182643BF0-0x0000000182643C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString CombatData { get => default; set {} } // 0x0000000182644ED0-0x0000000182644F70 0x0000000182644120-0x00000001826441D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvokeEntry() {} // 0x00000001826452A0-0x0000000182645330
	static CombatInvokeEntry() {} // 0x00000001826451E0-0x00000001826452A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvokeEntry Clone() => default; // 0x0000000182644870-0x0000000182644960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvokeEntry ShallowCopy() => default; // 0x00000001826442F0-0x0000000182644390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182643BA0-0x0000000182643BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182644A80-0x0000000182644AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182644AD0-0x0000000182644B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182643C90-0x0000000182643D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182643EB0-0x0000000182643F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombatInvokeEntry other) => default; // 0x0000000182643D40-0x0000000182643EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182644480-0x0000000182644650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182644F70-0x00000001826451E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182644B80-0x0000000182644CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182643F80-0x0000000182644120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombatInvokeEntry other) {} // 0x0000000182643A20-0x0000000182643BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826438C0-0x00000001826439C0
}

