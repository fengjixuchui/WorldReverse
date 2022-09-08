/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCompoundOutputReq : MessageBase, IMessage<TakeCompoundOutputReq> // TypeDefIndex: 24404
{
	// Fields
	private static readonly MessageParser<TakeCompoundOutputReq> _parser; // 0x00
	public const int CompoundIdFieldNumber = 1; // Metadata: 0x00B065CF
	private uint compoundId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCompoundOutputReq> Parser { get => default; } // 0x0000000180DEA500-0x0000000180DEA590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180DEA290-0x0000000180DEA320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180DE9FA0-0x0000000180DEA020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180DE9AB0-0x0000000180DE9B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180DEA8F0-0x0000000180DEA9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180DEA760-0x0000000180DEA7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180DEA320-0x0000000180DEA410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180DEA8A0-0x0000000180DEA8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180DEA0C0-0x0000000180DEA1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CompoundId { get => default; set {} } // 0x0000000180DEA6C0-0x0000000180DEA760 0x0000000180DEA9E0-0x0000000180DEAA80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24405
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24406
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 135
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputReq() {} // 0x0000000180DEACB0-0x0000000180DEAD10
	static TakeCompoundOutputReq() {} // 0x0000000180DEABF0-0x0000000180DEACB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputReq Clone() => default; // 0x0000000180DEA410-0x0000000180DEA500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCompoundOutputReq ShallowCopy() => default; // 0x0000000180DEA020-0x0000000180DEA0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180DE9C20-0x0000000180DE9C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DEA620-0x0000000180DEA670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DEA670-0x0000000180DEA6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180DE9C70-0x0000000180DE9CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180DE9CE0-0x0000000180DE9DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCompoundOutputReq other) => default; // 0x0000000180DE9DB0-0x0000000180DE9EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180DEA1B0-0x0000000180DEA290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180DEAA80-0x0000000180DEABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180DEA7C0-0x0000000180DEA8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180DE9EB0-0x0000000180DE9FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCompoundOutputReq other) {} // 0x0000000180DE9B10-0x0000000180DE9C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180DE99D0-0x0000000180DE9AB0
}

