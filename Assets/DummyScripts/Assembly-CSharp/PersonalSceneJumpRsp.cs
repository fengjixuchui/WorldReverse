/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PersonalSceneJumpRsp : MessageBase, IMessage<PersonalSceneJumpRsp> // TypeDefIndex: 25085
{
	// Fields
	private static readonly MessageParser<PersonalSceneJumpRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07F2F
	private int retcode_; // 0x18
	public const int DestSceneIdFieldNumber = 2; // Metadata: 0x00B07F33
	private uint destSceneId_; // 0x1C
	public const int DestPosFieldNumber = 3; // Metadata: 0x00B07F37
	private Vector destPos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PersonalSceneJumpRsp> Parser { get => default; } // 0x000000018308B3B0-0x000000018308B440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018308B140-0x000000018308B1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018308ACE0-0x000000018308AD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018308A290-0x000000018308A2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018308B880-0x000000018308B970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018308B670-0x000000018308B6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018308B1D0-0x000000018308B2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018308B830-0x000000018308B880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018308AE00-0x000000018308AEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018308AC40-0x000000018308ACE0 0x000000018308A700-0x000000018308A7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DestSceneId { get => default; set {} } // 0x000000018308B0A0-0x000000018308B140 0x000000018308A2F0-0x000000018308A390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DestPos { get => default; set {} } // 0x000000018308B5D0-0x000000018308B670 0x000000018308ABA0-0x000000018308AC40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25086
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25087
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 263
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalSceneJumpRsp() {} // 0x000000018308BCA0-0x000000018308BD00
	static PersonalSceneJumpRsp() {} // 0x000000018308BBE0-0x000000018308BCA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalSceneJumpRsp Clone() => default; // 0x000000018308B2C0-0x000000018308B3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PersonalSceneJumpRsp ShallowCopy() => default; // 0x000000018308AD60-0x000000018308AE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018308A540-0x000000018308A5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018308B4D0-0x000000018308B550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018308B550-0x000000018308B5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018308A5C0-0x000000018308A700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018308A7A0-0x000000018308A870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PersonalSceneJumpRsp other) => default; // 0x000000018308A870-0x000000018308A9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018308AEF0-0x000000018308B0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018308B970-0x000000018308BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018308B6D0-0x000000018308B830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018308A9C0-0x000000018308ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PersonalSceneJumpRsp other) {} // 0x000000018308A390-0x000000018308A540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018308A130-0x000000018308A290
}

