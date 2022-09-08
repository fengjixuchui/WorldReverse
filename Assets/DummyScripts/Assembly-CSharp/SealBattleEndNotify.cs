/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SealBattleEndNotify : MessageBase, IMessage<SealBattleEndNotify> // TypeDefIndex: 25091
{
	// Fields
	private static readonly MessageParser<SealBattleEndNotify> _parser; // 0x00
	public const int SealEntityIdFieldNumber = 1; // Metadata: 0x00B07F6B
	private uint sealEntityId_; // 0x18
	public const int IsWinFieldNumber = 2; // Metadata: 0x00B07F6F
	private bool isWin_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SealBattleEndNotify> Parser { get => default; } // 0x000000018415A4A0-0x000000018415A530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018415A190-0x000000018415A220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184159E70-0x0000000184159EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841597F0-0x0000000184159850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018415A830-0x000000018415A920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018415A660-0x000000018415A6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018415A220-0x000000018415A310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018415A7E0-0x000000018415A830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184159F90-0x000000018415A080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SealEntityId { get => default; set {} } // 0x000000018415A400-0x000000018415A4A0 0x0000000184159DD0-0x0000000184159E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsWin { get => default; set {} } // 0x0000000184159850-0x00000001841598F0 0x000000018415A920-0x000000018415A9C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25092
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25093
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 265
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleEndNotify() {} // 0x000000018415AC80-0x000000018415ACE0
	static SealBattleEndNotify() {} // 0x000000018415ABC0-0x000000018415AC80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleEndNotify Clone() => default; // 0x000000018415A310-0x000000018415A400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SealBattleEndNotify ShallowCopy() => default; // 0x0000000184159EF0-0x0000000184159F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184159A20-0x0000000184159A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018415A5C0-0x000000018415A610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018415A610-0x000000018415A660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184159A70-0x0000000184159AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184159C00-0x0000000184159CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SealBattleEndNotify other) => default; // 0x0000000184159AE0-0x0000000184159C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018415A080-0x000000018415A190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018415A9C0-0x000000018415ABC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018415A6C0-0x000000018415A7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184159CD0-0x0000000184159DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SealBattleEndNotify other) {} // 0x00000001841598F0-0x0000000184159A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841596F0-0x00000001841597F0
}

