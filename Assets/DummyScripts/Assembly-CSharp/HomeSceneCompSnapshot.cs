/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeSceneCompSnapshot : MessageBase, IMessage<HomeSceneCompSnapshot> // TypeDefIndex: 23409
{
	// Fields
	private static readonly MessageParser<HomeSceneCompSnapshot> _parser; // 0x00
	public const int CurModuleIdFieldNumber = 1; // Metadata: 0x00B03F77
	private uint curModuleId_; // 0x18
	public const int ModuleListFieldNumber = 2; // Metadata: 0x00B03F7B
	private static readonly FieldCodec<HomeModuleSnapshot> _repeated_moduleList_codec; // 0x08
	private readonly RepeatedMessageField<HomeModuleSnapshot> moduleList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeSceneCompSnapshot> Parser { get => default; } // 0x00000001814094A0-0x0000000181409530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181409230-0x00000001814092C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181408E80-0x0000000181408F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181408750-0x00000001814087B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814098D0-0x00000001814099C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814096E0-0x0000000181409740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814092C0-0x00000001814093B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181409880-0x00000001814098D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181409040-0x0000000181409130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurModuleId { get => default; set {} } // 0x0000000181408810-0x00000001814088B0 0x0000000181408F00-0x0000000181408FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeModuleSnapshot> ModuleList { get => default; } // 0x00000001814087B0-0x0000000181408810 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneCompSnapshot() {} // 0x0000000181409CB0-0x0000000181409D40
	static HomeSceneCompSnapshot() {} // 0x0000000181409BA0-0x0000000181409CB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneCompSnapshot Clone() => default; // 0x00000001814093B0-0x00000001814094A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneCompSnapshot ShallowCopy() => default; // 0x0000000181408FA0-0x0000000181409040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181408A10-0x0000000181408A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814095C0-0x0000000181409650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181409650-0x00000001814096E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181408A60-0x0000000181408B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181408B40-0x0000000181408C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeSceneCompSnapshot other) => default; // 0x0000000181408C10-0x0000000181408D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181409130-0x0000000181409230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814099C0-0x0000000181409BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181409740-0x0000000181409880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181408D40-0x0000000181408E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeSceneCompSnapshot other) {} // 0x00000001814088B0-0x0000000181408A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814085F0-0x0000000181408750
}

