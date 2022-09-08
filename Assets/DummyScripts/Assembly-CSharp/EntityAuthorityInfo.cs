/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityAuthorityInfo : MessageBase, IMessage<EntityAuthorityInfo> // TypeDefIndex: 26052
{
	// Fields
	private static readonly MessageParser<EntityAuthorityInfo> _parser; // 0x00
	public const int AbilityInfoFieldNumber = 1; // Metadata: 0x00B0AE43
	private AbilitySyncStateInfo abilityInfo_; // 0x18
	public const int RendererChangedInfoFieldNumber = 2; // Metadata: 0x00B0AE47
	private EntityRendererChangedInfo rendererChangedInfo_; // 0x20
	public const int AiInfoFieldNumber = 3; // Metadata: 0x00B0AE4B
	private SceneEntityAiInfo aiInfo_; // 0x28
	public const int BornPosFieldNumber = 4; // Metadata: 0x00B0AE4F
	private Vector bornPos_; // 0x30
	public const int PoseParaListFieldNumber = 5; // Metadata: 0x00B0AE53
	private static readonly FieldCodec<AnimatorParameterValueInfoPair> _repeated_poseParaList_codec; // 0x08
	private readonly RepeatedMessageField<AnimatorParameterValueInfoPair> poseParaList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityAuthorityInfo> Parser { get => default; } // 0x00000001834990E0-0x0000000183499170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183498D30-0x0000000183498DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183498720-0x00000001834987A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834977D0-0x0000000183497830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183499770-0x0000000183499860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834994E0-0x0000000183499540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183498E60-0x0000000183498F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183499720-0x0000000183499770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183498840-0x0000000183498930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AbilityInfo { get => default; set {} } // 0x0000000183497730-0x00000001834977D0 0x0000000183498C90-0x0000000183498D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityRendererChangedInfo RendererChangedInfo { get => default; set {} } // 0x0000000183499040-0x00000001834990E0 0x0000000183499860-0x0000000183499900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityAiInfo AiInfo { get => default; set {} } // 0x0000000183498020-0x00000001834980C0 0x0000000183498DC0-0x0000000183498E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector BornPos { get => default; set {} } // 0x0000000183499200-0x00000001834992A0 0x0000000183499440-0x00000001834994E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AnimatorParameterValueInfoPair> PoseParaList { get => default; } // 0x0000000183497FC0-0x0000000183498020 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityInfo() {} // 0x0000000183499D30-0x0000000183499DC0
	static EntityAuthorityInfo() {} // 0x0000000183499C20-0x0000000183499D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityInfo Clone() => default; // 0x0000000183498F50-0x0000000183499040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityInfo ShallowCopy() => default; // 0x00000001834987A0-0x0000000183498840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183497B30-0x0000000183497BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834992A0-0x0000000183499370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183499370-0x0000000183499440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183497BF0-0x0000000183497FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001834980C0-0x0000000183498190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityAuthorityInfo other) => default; // 0x0000000183498190-0x0000000183498360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183498930-0x0000000183498C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183499900-0x0000000183499C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183499540-0x0000000183499720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183498360-0x0000000183498720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityAuthorityInfo other) {} // 0x0000000183497830-0x0000000183497B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834974B0-0x0000000183497730
}

