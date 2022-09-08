/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QueryFilter : MessageBase, IMessage<QueryFilter> // TypeDefIndex: 24253
{
	// Fields
	private static readonly MessageParser<QueryFilter> _parser; // 0x00
	public const int TypeIdFieldNumber = 1; // Metadata: 0x00B05F1F
	private int typeId_; // 0x18
	public const int AreaMaskFieldNumber = 2; // Metadata: 0x00B05F23
	private int areaMask_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QueryFilter> Parser { get => default; } // 0x0000000185134000-0x0000000185134090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185133CF0-0x0000000185133D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851339E0-0x0000000185133A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001851333D0-0x0000000185133430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185134390-0x0000000185134480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001851341C0-0x0000000185134220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185133E20-0x0000000185133F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185134340-0x0000000185134390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185133B00-0x0000000185133BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int TypeId { get => default; set {} } // 0x0000000185133330-0x00000001851333D0 0x0000000185133620-0x00000001851336C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int AreaMask { get => default; set {} } // 0x0000000185133D80-0x0000000185133E20 0x0000000185133290-0x0000000185133330

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryFilter() {} // 0x0000000185134740-0x00000001851347A0
	static QueryFilter() {} // 0x0000000185134680-0x0000000185134740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryFilter Clone() => default; // 0x0000000185133F10-0x0000000185134000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QueryFilter ShallowCopy() => default; // 0x0000000185133A60-0x0000000185133B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185133560-0x00000001851335B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185134120-0x0000000185134170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185134170-0x00000001851341C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851335B0-0x0000000185133620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001851337E0-0x00000001851338B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QueryFilter other) => default; // 0x00000001851336C0-0x00000001851337E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185133BF0-0x0000000185133CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185134480-0x0000000185134680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185134220-0x0000000185134340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851338B0-0x00000001851339E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QueryFilter other) {} // 0x0000000185133430-0x0000000185133560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185133190-0x0000000185133290
}

