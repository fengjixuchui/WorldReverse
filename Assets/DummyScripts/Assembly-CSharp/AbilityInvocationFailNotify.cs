/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityInvocationFailNotify : MessageBase, IMessage<AbilityInvocationFailNotify> // TypeDefIndex: 21798
{
	// Fields
	private static readonly MessageParser<AbilityInvocationFailNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0004B
	private uint entityId_; // 0x18
	public const int InvokeFieldNumber = 2; // Metadata: 0x00B0004F
	private AbilityInvokeEntry invoke_; // 0x20
	public const int ReasonFieldNumber = 3; // Metadata: 0x00B00053
	private string reason_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityInvocationFailNotify> Parser { get => default; } // 0x00000001825D2030-0x00000001825D20C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825D1C80-0x00000001825D1D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825D18A0-0x00000001825D1920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825D0F00-0x00000001825D0F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825D2510-0x00000001825D2600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825D22F0-0x00000001825D2350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825D1DB0-0x00000001825D1EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825D24C0-0x00000001825D2510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825D19C0-0x00000001825D1AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001825D2250-0x00000001825D22F0 0x00000001825D2600-0x00000001825D26A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvokeEntry Invoke { get => default; set {} } // 0x00000001825D1D10-0x00000001825D1DB0 0x00000001825D13A0-0x00000001825D1440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Reason { get => default; set {} } // 0x00000001825D1F90-0x00000001825D2030 0x00000001825D11B0-0x00000001825D1260

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21799
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21800
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1105
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFailNotify() {} // 0x00000001825D29C0-0x00000001825D2A30
	static AbilityInvocationFailNotify() {} // 0x00000001825D2900-0x00000001825D29C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFailNotify Clone() => default; // 0x00000001825D1EA0-0x00000001825D1F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityInvocationFailNotify ShallowCopy() => default; // 0x00000001825D1920-0x00000001825D19C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825D1130-0x00000001825D11B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825D2150-0x00000001825D21D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825D21D0-0x00000001825D2250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825D1260-0x00000001825D13A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825D1440-0x00000001825D1510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityInvocationFailNotify other) => default; // 0x00000001825D1510-0x00000001825D16A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825D1AB0-0x00000001825D1C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825D26A0-0x00000001825D2900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825D2350-0x00000001825D24C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825D16A0-0x00000001825D18A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityInvocationFailNotify other) {} // 0x00000001825D0F60-0x00000001825D1130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825D0DA0-0x00000001825D0F00
}

