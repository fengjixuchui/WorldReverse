/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneReliquaryInfo : MessageBase, IMessage<SceneReliquaryInfo> // TypeDefIndex: 26012
{
	// Fields
	private static readonly MessageParser<SceneReliquaryInfo> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0AABF
	private uint itemId_; // 0x18
	public const int GuidFieldNumber = 2; // Metadata: 0x00B0AAC3
	private ulong guid_; // 0x20
	public const int LevelFieldNumber = 3; // Metadata: 0x00B0AAC7
	private uint level_; // 0x28
	public const int PromoteLevelFieldNumber = 4; // Metadata: 0x00B0AACB
	private uint promoteLevel_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneReliquaryInfo> Parser { get => default; } // 0x000000018444B930-0x000000018444B9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018444B620-0x000000018444B6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018444B210-0x000000018444B290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018444A8C0-0x000000018444A920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018444BE80-0x000000018444BF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018444BB90-0x000000018444BBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018444B6B0-0x000000018444B7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018444BD90-0x000000018444BDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018444B3D0-0x000000018444B4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x000000018444BA50-0x000000018444BAF0 0x000000018444BDE0-0x000000018444BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x000000018444AAB0-0x000000018444AB50 0x000000018444ACD0-0x000000018444AD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x000000018444AB50-0x000000018444ABF0 0x000000018444B330-0x000000018444B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x000000018444B170-0x000000018444B210 0x000000018444B890-0x000000018444B930

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneReliquaryInfo() {} // 0x000000018444C350-0x000000018444C3B0
	static SceneReliquaryInfo() {} // 0x000000018444C290-0x000000018444C350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneReliquaryInfo Clone() => default; // 0x000000018444B7A0-0x000000018444B890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneReliquaryInfo ShallowCopy() => default; // 0x000000018444B290-0x000000018444B330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018444ABF0-0x000000018444AC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018444BAF0-0x000000018444BB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018444BB40-0x000000018444BB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018444AC40-0x000000018444ACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018444AD70-0x000000018444AE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneReliquaryInfo other) => default; // 0x000000018444AE40-0x000000018444AFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018444B4C0-0x000000018444B620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018444BF70-0x000000018444C290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018444BBF0-0x000000018444BD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018444AFA0-0x000000018444B170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneReliquaryInfo other) {} // 0x000000018444A920-0x000000018444AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018444A790-0x000000018444A8C0
}

