/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayInfoNotify : MessageBase, IMessage<MultistagePlayInfoNotify> // TypeDefIndex: 24114
{
	// Fields
	private static readonly MessageParser<MultistagePlayInfoNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B05A03
	private MultistagePlayInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistagePlayInfoNotify> Parser { get => default; } // 0x00000001820C3790-0x00000001820C3820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820C3520-0x00000001820C35B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820C31C0-0x00000001820C3240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820C2A90-0x00000001820C2AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820C3BE0-0x00000001820C3CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820C3A50-0x00000001820C3AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820C35B0-0x00000001820C36A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820C3B90-0x00000001820C3BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820C32E0-0x00000001820C33D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfo Info { get => default; set {} } // 0x00000001820C2DF0-0x00000001820C2E90 0x00000001820C39B0-0x00000001820C3A50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24115
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24116
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5301
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfoNotify() {} // 0x00000001820C3EE0-0x00000001820C3F40
	static MultistagePlayInfoNotify() {} // 0x00000001820C3E20-0x00000001820C3EE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfoNotify Clone() => default; // 0x00000001820C36A0-0x00000001820C3790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfoNotify ShallowCopy() => default; // 0x00000001820C3240-0x00000001820C32E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820C2C50-0x00000001820C2CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C38B0-0x00000001820C3930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C3930-0x00000001820C39B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820C2CD0-0x00000001820C2DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820C2FA0-0x00000001820C3070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistagePlayInfoNotify other) => default; // 0x00000001820C2E90-0x00000001820C2FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820C33D0-0x00000001820C3520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820C3CD0-0x00000001820C3E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820C3AB0-0x00000001820C3B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820C3070-0x00000001820C31C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistagePlayInfoNotify other) {} // 0x00000001820C2AF0-0x00000001820C2C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820C2980-0x00000001820C2A90
}

