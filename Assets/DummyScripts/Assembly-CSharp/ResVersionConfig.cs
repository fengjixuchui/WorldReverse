/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ResVersionConfig : MessageBase, IMessage<ResVersionConfig> // TypeDefIndex: 25967
{
	// Fields
	private static readonly MessageParser<ResVersionConfig> _parser; // 0x00
	public const int VersionFieldNumber = 1; // Metadata: 0x00B0A7BF
	private uint version_; // 0x18
	public const int ReloginFieldNumber = 2; // Metadata: 0x00B0A7C3
	private bool relogin_; // 0x1C
	public const int Md5FieldNumber = 3; // Metadata: 0x00B0A7C7
	private string md5_; // 0x20
	public const int ReleaseTotalSizeFieldNumber = 4; // Metadata: 0x00B0A7CB
	private string releaseTotalSize_; // 0x28
	public const int VersionSuffixFieldNumber = 5; // Metadata: 0x00B0A7CF
	private string versionSuffix_; // 0x30
	public const int BranchFieldNumber = 6; // Metadata: 0x00B0A7D3
	private string branch_; // 0x38
	public const int NextScriptVersionFieldNumber = 7; // Metadata: 0x00B0A7D7
	private string nextScriptVersion_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ResVersionConfig> Parser { get => default; } // 0x0000000185883A00-0x0000000185883A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001858834F0-0x0000000185883580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185882EF0-0x0000000185882F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001858821F0-0x0000000185882250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185884130-0x0000000185884220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185883C60-0x0000000185883CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001858836D0-0x00000001858837C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185883FA0-0x0000000185883FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185883010-0x0000000185883100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Version { get => default; set {} } // 0x0000000185883580-0x0000000185883620 0x00000001858837C0-0x0000000185883860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Relogin { get => default; set {} } // 0x0000000185883BC0-0x0000000185883C60 0x0000000185883450-0x00000001858834F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Md5 { get => default; set {} } // 0x0000000185882300-0x00000001858823A0 0x0000000185883620-0x00000001858836D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ReleaseTotalSize { get => default; set {} } // 0x0000000185883FF0-0x0000000185884090 0x00000001858823A0-0x0000000185882450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string VersionSuffix { get => default; set {} } // 0x0000000185884090-0x0000000185884130 0x0000000185883950-0x0000000185883A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Branch { get => default; set {} } // 0x0000000185883100-0x00000001858831A0 0x0000000185884220-0x00000001858842D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NextScriptVersion { get => default; set {} } // 0x00000001858827E0-0x0000000185882880 0x0000000185882250-0x0000000185882300

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig() {} // 0x00000001858847D0-0x0000000185884870
	static ResVersionConfig() {} // 0x0000000185884710-0x00000001858847D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig Clone() => default; // 0x0000000185883860-0x0000000185883950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResVersionConfig ShallowCopy() => default; // 0x0000000185882F70-0x0000000185883010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001858826C0-0x0000000185882710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185883B20-0x0000000185883B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185883B70-0x0000000185883BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185882710-0x00000001858827E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185882B30-0x0000000185882C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ResVersionConfig other) => default; // 0x0000000185882880-0x0000000185882B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001858831A0-0x0000000185883450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001858842D0-0x0000000185884710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185883CC0-0x0000000185883FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185882C00-0x0000000185882EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ResVersionConfig other) {} // 0x0000000185882450-0x00000001858826C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185882060-0x00000001858821F0
}

