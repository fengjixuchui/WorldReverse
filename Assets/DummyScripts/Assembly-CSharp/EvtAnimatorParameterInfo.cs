/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAnimatorParameterInfo : MessageBase, IMessage<EvtAnimatorParameterInfo> // TypeDefIndex: 22994
{
	// Fields
	private static readonly MessageParser<EvtAnimatorParameterInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02E2B
	private uint entityId_; // 0x18
	public const int NameIdFieldNumber = 2; // Metadata: 0x00B02E2F
	private int nameId_; // 0x1C
	public const int IsServerCacheFieldNumber = 3; // Metadata: 0x00B02E33
	private bool isServerCache_; // 0x20
	public const int ValueFieldNumber = 4; // Metadata: 0x00B02E37
	private AnimatorParameterValueInfo value_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAnimatorParameterInfo> Parser { get => default; } // 0x0000000184EB80E0-0x0000000184EB8170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184EB7DD0-0x0000000184EB7E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184EB79E0-0x0000000184EB7A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184EB7070-0x0000000184EB70D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184EB87D0-0x0000000184EB88C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184EB84E0-0x0000000184EB8540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184EB7F00-0x0000000184EB7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184EB8780-0x0000000184EB87D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184EB7B00-0x0000000184EB7BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184EB83A0-0x0000000184EB8440 0x0000000184EB88C0-0x0000000184EB8960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int NameId { get => default; set {} } // 0x0000000184EB72A0-0x0000000184EB7340 0x0000000184EB8540-0x0000000184EB85E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerCache { get => default; set {} } // 0x0000000184EB7510-0x0000000184EB75B0 0x0000000184EB8440-0x0000000184EB84E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfo Value { get => default; set {} } // 0x0000000184EB7E60-0x0000000184EB7F00 0x0000000184EB8280-0x0000000184EB8320

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorParameterInfo() {} // 0x0000000184EB8D20-0x0000000184EB8D80
	static EvtAnimatorParameterInfo() {} // 0x0000000184EB8C60-0x0000000184EB8D20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorParameterInfo Clone() => default; // 0x0000000184EB7FF0-0x0000000184EB80E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorParameterInfo ShallowCopy() => default; // 0x0000000184EB7A60-0x0000000184EB7B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184EB7340-0x0000000184EB73C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EB8200-0x0000000184EB8280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184EB8320-0x0000000184EB83A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184EB73C0-0x0000000184EB7510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184EB7720-0x0000000184EB77F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAnimatorParameterInfo other) => default; // 0x0000000184EB75B0-0x0000000184EB7720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184EB7BF0-0x0000000184EB7DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184EB8960-0x0000000184EB8C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184EB85E0-0x0000000184EB8780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184EB77F0-0x0000000184EB79E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAnimatorParameterInfo other) {} // 0x0000000184EB70D0-0x0000000184EB72A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184EB6EF0-0x0000000184EB7070
}

