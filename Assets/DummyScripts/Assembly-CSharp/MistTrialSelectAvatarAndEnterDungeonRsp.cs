/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialSelectAvatarAndEnterDungeonRsp : MessageBase, IMessage<MistTrialSelectAvatarAndEnterDungeonRsp> // TypeDefIndex: 22337
{
	// Fields
	private static readonly MessageParser<MistTrialSelectAvatarAndEnterDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B015CF
	private int retcode_; // 0x18
	public const int TrialIdFieldNumber = 2; // Metadata: 0x00B015D3
	private uint trialId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialSelectAvatarAndEnterDungeonRsp> Parser { get => default; } // 0x0000000184AD7300-0x0000000184AD7390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184AD6FF0-0x0000000184AD7080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184AD6CE0-0x0000000184AD6D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184AD6590-0x0000000184AD65F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184AD7690-0x0000000184AD7780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184AD74C0-0x0000000184AD7520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184AD7080-0x0000000184AD7170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184AD7640-0x0000000184AD7690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184AD6E00-0x0000000184AD6EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184AD6BA0-0x0000000184AD6C40 0x0000000184AD67E0-0x0000000184AD6880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialId { get => default; set {} } // 0x0000000184AD7260-0x0000000184AD7300 0x0000000184AD6C40-0x0000000184AD6CE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22338
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22339
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8022
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonRsp() {} // 0x0000000184AD7A40-0x0000000184AD7AA0
	static MistTrialSelectAvatarAndEnterDungeonRsp() {} // 0x0000000184AD7980-0x0000000184AD7A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonRsp Clone() => default; // 0x0000000184AD7170-0x0000000184AD7260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialSelectAvatarAndEnterDungeonRsp ShallowCopy() => default; // 0x0000000184AD6D60-0x0000000184AD6E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184AD6720-0x0000000184AD6770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD7420-0x0000000184AD7470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD7470-0x0000000184AD74C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184AD6770-0x0000000184AD67E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184AD6880-0x0000000184AD6950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialSelectAvatarAndEnterDungeonRsp other) => default; // 0x0000000184AD6950-0x0000000184AD6A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184AD6EF0-0x0000000184AD6FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184AD7780-0x0000000184AD7980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184AD7520-0x0000000184AD7640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184AD6A70-0x0000000184AD6BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialSelectAvatarAndEnterDungeonRsp other) {} // 0x0000000184AD65F0-0x0000000184AD6720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184AD6490-0x0000000184AD6590
}

