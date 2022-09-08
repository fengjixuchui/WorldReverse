/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetStateNotify : MessageBase, IMessage<GadgetStateNotify> // TypeDefIndex: 23182
{
	// Fields
	private static readonly MessageParser<GadgetStateNotify> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B036CB
	private uint gadgetEntityId_; // 0x18
	public const int GadgetStateFieldNumber = 2; // Metadata: 0x00B036CF
	private uint gadgetState_; // 0x1C
	public const int IsEnableInteractFieldNumber = 3; // Metadata: 0x00B036D3
	private bool isEnableInteract_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetStateNotify> Parser { get => default; } // 0x0000000183EB8520-0x0000000183EB85B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EB82B0-0x0000000183EB8340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EB7F70-0x0000000183EB7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EB7660-0x0000000183EB76C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EB8990-0x0000000183EB8A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EB86E0-0x0000000183EB8740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EB8340-0x0000000183EB8430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EB8940-0x0000000183EB8990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EB8090-0x0000000183EB8180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000183EB8740-0x0000000183EB87E0 0x0000000183EB76C0-0x0000000183EB7760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetState { get => default; set {} } // 0x0000000183EB7A30-0x0000000183EB7AD0 0x0000000183EB7ED0-0x0000000183EB7F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEnableInteract { get => default; set {} } // 0x0000000183EB7990-0x0000000183EB7A30 0x0000000183EB7E30-0x0000000183EB7ED0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23183
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23184
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 803
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetStateNotify() {} // 0x0000000183EB8DD0-0x0000000183EB8E30
	static GadgetStateNotify() {} // 0x0000000183EB8D10-0x0000000183EB8DD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetStateNotify Clone() => default; // 0x0000000183EB8430-0x0000000183EB8520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetStateNotify ShallowCopy() => default; // 0x0000000183EB7FF0-0x0000000183EB8090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EB78C0-0x0000000183EB7910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB8640-0x0000000183EB8690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB8690-0x0000000183EB86E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EB7910-0x0000000183EB7990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EB7C10-0x0000000183EB7CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetStateNotify other) => default; // 0x0000000183EB7AD0-0x0000000183EB7C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EB8180-0x0000000183EB82B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EB8A80-0x0000000183EB8D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EB87E0-0x0000000183EB8940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EB7CE0-0x0000000183EB7E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetStateNotify other) {} // 0x0000000183EB7760-0x0000000183EB78C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EB7550-0x0000000183EB7660
}

