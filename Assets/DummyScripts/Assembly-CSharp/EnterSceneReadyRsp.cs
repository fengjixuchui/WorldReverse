/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterSceneReadyRsp : MessageBase, IMessage<EnterSceneReadyRsp> // TypeDefIndex: 25148
{
	// Fields
	private static readonly MessageParser<EnterSceneReadyRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08167
	private int retcode_; // 0x18
	public const int EnterSceneTokenFieldNumber = 2; // Metadata: 0x00B0816B
	private uint enterSceneToken_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterSceneReadyRsp> Parser { get => default; } // 0x00000001818D25C0-0x00000001818D2650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818D22B0-0x00000001818D2340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818D1FA0-0x00000001818D2020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818D18F0-0x00000001818D1950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818D29F0-0x00000001818D2AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818D2820-0x00000001818D2880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818D23E0-0x00000001818D24D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818D29A0-0x00000001818D29F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818D20C0-0x00000001818D21B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001818D1F00-0x00000001818D1FA0 0x00000001818D1B40-0x00000001818D1BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x00000001818D2340-0x00000001818D23E0 0x00000001818D2780-0x00000001818D2820

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25149
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25150
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 283
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneReadyRsp() {} // 0x00000001818D2DA0-0x00000001818D2E00
	static EnterSceneReadyRsp() {} // 0x00000001818D2CE0-0x00000001818D2DA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneReadyRsp Clone() => default; // 0x00000001818D24D0-0x00000001818D25C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterSceneReadyRsp ShallowCopy() => default; // 0x00000001818D2020-0x00000001818D20C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818D1A80-0x00000001818D1AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818D26E0-0x00000001818D2730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818D2730-0x00000001818D2780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818D1AD0-0x00000001818D1B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818D1BE0-0x00000001818D1CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterSceneReadyRsp other) => default; // 0x00000001818D1CB0-0x00000001818D1DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818D21B0-0x00000001818D22B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818D2AE0-0x00000001818D2CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818D2880-0x00000001818D29A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818D1DD0-0x00000001818D1F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterSceneReadyRsp other) {} // 0x00000001818D1950-0x00000001818D1A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818D17F0-0x00000001818D18F0
}

