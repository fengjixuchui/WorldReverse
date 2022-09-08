/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityRendererChangedInfo : MessageBase, IMessage<EntityRendererChangedInfo> // TypeDefIndex: 26047
{
	// Fields
	private static readonly MessageParser<EntityRendererChangedInfo> _parser; // 0x00
	public const int ChangedRenderersFieldNumber = 1; // Metadata: 0x00B0AE17
	private static readonly MapField<string, uint> _map_changedRenderers_codec; // 0x08
	private readonly MapField<string, uint> changedRenderers_; // 0x18
	public const int VisibilityCountFieldNumber = 2; // Metadata: 0x00B0AE1B
	private uint visibilityCount_; // 0x20
	public const int IsCachedFieldNumber = 3; // Metadata: 0x00B0AE1F
	private bool isCached_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityRendererChangedInfo> Parser { get => default; } // 0x00000001831C9C90-0x00000001831C9D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831C9980-0x00000001831C9A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831C9610-0x00000001831C9690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831C8D50-0x00000001831C8DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831CA0E0-0x00000001831CA1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831C9E50-0x00000001831C9EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831C9AB0-0x00000001831C9BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831CA090-0x00000001831CA0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831C9730-0x00000001831C9820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<string, uint> ChangedRenderers { get => default; } // 0x00000001831C9EB0-0x00000001831C9F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint VisibilityCount { get => default; set {} } // 0x00000001831C94D0-0x00000001831C9570 0x00000001831C8F60-0x00000001831C9000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCached { get => default; set {} } // 0x00000001831C9A10-0x00000001831C9AB0 0x00000001831C9570-0x00000001831C9610

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityRendererChangedInfo() {} // 0x00000001831CA570-0x00000001831CA600
	static EntityRendererChangedInfo() {} // 0x00000001831CA440-0x00000001831CA570

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityRendererChangedInfo Clone() => default; // 0x00000001831C9BA0-0x00000001831C9C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityRendererChangedInfo ShallowCopy() => default; // 0x00000001831C9690-0x00000001831C9730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831C8F10-0x00000001831C8F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831C9DB0-0x00000001831C9E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831C9E00-0x00000001831C9E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831C9000-0x00000001831C90E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831C92A0-0x00000001831C9370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityRendererChangedInfo other) => default; // 0x00000001831C90E0-0x00000001831C92A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831C9820-0x00000001831C9980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831CA1D0-0x00000001831CA440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831C9F10-0x00000001831CA090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831C9370-0x00000001831C94D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityRendererChangedInfo other) {} // 0x00000001831C8DB0-0x00000001831C8F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831C8BD0-0x00000001831C8D50
}

