/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ServantInfo : MessageBase, IMessage<ServantInfo> // TypeDefIndex: 26045
{
	// Fields
	private static readonly MessageParser<ServantInfo> _parser; // 0x00
	public const int MasterEntityIdFieldNumber = 1; // Metadata: 0x00B0ADF3
	private uint masterEntityId_; // 0x18
	public const int BornSlotIndexFieldNumber = 2; // Metadata: 0x00B0ADF7
	private uint bornSlotIndex_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServantInfo> Parser { get => default; } // 0x0000000183537980-0x0000000183537A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183537670-0x0000000183537700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183537360-0x00000001835373E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183536CB0-0x0000000183536D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183537DB0-0x0000000183537EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183537B40-0x0000000183537BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183537700-0x00000001835377F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183537D60-0x0000000183537DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183537480-0x0000000183537570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MasterEntityId { get => default; set {} } // 0x0000000183536FA0-0x0000000183537040 0x0000000183537BA0-0x0000000183537C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BornSlotIndex { get => default; set {} } // 0x0000000183536D10-0x0000000183536DB0 0x00000001835378E0-0x0000000183537980

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServantInfo() {} // 0x0000000183538160-0x00000001835381C0
	static ServantInfo() {} // 0x00000001835380A0-0x0000000183538160

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServantInfo Clone() => default; // 0x00000001835377F0-0x00000001835378E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServantInfo ShallowCopy() => default; // 0x00000001835373E0-0x0000000183537480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183536EE0-0x0000000183536F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183537AA0-0x0000000183537AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183537AF0-0x0000000183537B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183536F30-0x0000000183536FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183537160-0x0000000183537230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ServantInfo other) => default; // 0x0000000183537040-0x0000000183537160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183537570-0x0000000183537670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183537EA0-0x00000001835380A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183537C40-0x0000000183537D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183537230-0x0000000183537360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ServantInfo other) {} // 0x0000000183536DB0-0x0000000183536EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183536BB0-0x0000000183536CB0
}

