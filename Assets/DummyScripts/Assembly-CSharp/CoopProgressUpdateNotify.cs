/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopProgressUpdateNotify : MessageBase, IMessage<CoopProgressUpdateNotify> // TypeDefIndex: 22744
{
	// Fields
	private static readonly MessageParser<CoopProgressUpdateNotify> _parser; // 0x00
	public const int IsHaveProgressFieldNumber = 1; // Metadata: 0x00B0245B
	private bool isHaveProgress_; // 0x18
	public const int CurCoopPointFieldNumber = 2; // Metadata: 0x00B0245F
	private uint curCoopPoint_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopProgressUpdateNotify> Parser { get => default; } // 0x0000000182F7AC40-0x0000000182F7ACD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F7A930-0x0000000182F7A9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F7A570-0x0000000182F7A5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F79F90-0x0000000182F79FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F7B070-0x0000000182F7B160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F7AE00-0x0000000182F7AE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F7A9C0-0x0000000182F7AAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F7B020-0x0000000182F7B070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F7A690-0x0000000182F7A780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsHaveProgress { get => default; set {} } // 0x0000000182F7ABA0-0x0000000182F7AC40 0x0000000182F7AF80-0x0000000182F7B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurCoopPoint { get => default; set {} } // 0x0000000182F79FF0-0x0000000182F7A090 0x0000000182F7A890-0x0000000182F7A930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22745
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22746
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1970
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopProgressUpdateNotify() {} // 0x0000000182F7B420-0x0000000182F7B480
	static CoopProgressUpdateNotify() {} // 0x0000000182F7B360-0x0000000182F7B420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopProgressUpdateNotify Clone() => default; // 0x0000000182F7AAB0-0x0000000182F7ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopProgressUpdateNotify ShallowCopy() => default; // 0x0000000182F7A5F0-0x0000000182F7A690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F7A1C0-0x0000000182F7A210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F7AD60-0x0000000182F7ADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F7ADB0-0x0000000182F7AE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F7A210-0x0000000182F7A280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F7A280-0x0000000182F7A350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopProgressUpdateNotify other) => default; // 0x0000000182F7A350-0x0000000182F7A470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F7A780-0x0000000182F7A890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F7B160-0x0000000182F7B360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F7AE60-0x0000000182F7AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F7A470-0x0000000182F7A570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopProgressUpdateNotify other) {} // 0x0000000182F7A090-0x0000000182F7A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F79E90-0x0000000182F79F90
}

