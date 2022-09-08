/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleUidOpNotify : MessageBase, IMessage<ScenePlayBattleUidOpNotify> // TypeDefIndex: 25407
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleUidOpNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08ABB
	private uint playId_; // 0x18
	public const int PlayTypeFieldNumber = 2; // Metadata: 0x00B08ABF
	private uint playType_; // 0x1C
	public const int EntityIdFieldNumber = 3; // Metadata: 0x00B08AC3
	private uint entityId_; // 0x20
	public const int UidListFieldNumber = 4; // Metadata: 0x00B08AC7
	private static readonly FieldCodec<uint> _repeated_uidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> uidList_; // 0x28
	public const int OpFieldNumber = 5; // Metadata: 0x00B08ACB
	private uint op_; // 0x30
	public const int ParamStrFieldNumber = 6; // Metadata: 0x00B08ACF
	private string paramStr_; // 0x38
	public const int ParamListFieldNumber = 7; // Metadata: 0x00B08AD3
	private static readonly FieldCodec<uint> _repeated_paramList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> paramList_; // 0x40
	public const int ParamTargetListFieldNumber = 8; // Metadata: 0x00B08AD7
	private static readonly FieldCodec<uint> _repeated_paramTargetList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> paramTargetList_; // 0x48
	public const int ParamIndexFieldNumber = 9; // Metadata: 0x00B08ADB
	private uint paramIndex_; // 0x50
	public const int ParamDurationFieldNumber = 10; // Metadata: 0x00B08ADF
	private uint paramDuration_; // 0x54

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleUidOpNotify> Parser { get => default; } // 0x0000000184BD30C0-0x0000000184BD3150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BD2D10-0x0000000184BD2DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BD2680-0x0000000184BD2700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BD1870-0x0000000184BD18D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BD39D0-0x0000000184BD3AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BD33C0-0x0000000184BD3420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BD2EE0-0x0000000184BD2FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BD3920-0x0000000184BD3970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BD2850-0x0000000184BD2940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000184BD25E0-0x0000000184BD2680 0x0000000184BD2C70-0x0000000184BD2D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000184BD3420-0x0000000184BD34C0 0x0000000184BD1E10-0x0000000184BD1EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184BD3320-0x0000000184BD33C0 0x0000000184BD3AC0-0x0000000184BD3B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UidList { get => default; } // 0x0000000184BD3970-0x0000000184BD39D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Op { get => default; set {} } // 0x0000000184BD2E40-0x0000000184BD2EE0 0x0000000184BD2BD0-0x0000000184BD2C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ParamStr { get => default; set {} } // 0x0000000184BD2DA0-0x0000000184BD2E40 0x0000000184BD27A0-0x0000000184BD2850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamList { get => default; } // 0x0000000184BD3560-0x0000000184BD35C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ParamTargetList { get => default; } // 0x0000000184BD1EB0-0x0000000184BD1F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParamIndex { get => default; set {} } // 0x0000000184BD34C0-0x0000000184BD3560 0x0000000184BD17D0-0x0000000184BD1870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParamDuration { get => default; set {} } // 0x0000000184BD3150-0x0000000184BD31F0 0x0000000184BD18D0-0x0000000184BD1970

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25408
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25409
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4364
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleUidOpNotify() {} // 0x0000000184BD4280-0x0000000184BD4360
	static ScenePlayBattleUidOpNotify() {} // 0x0000000184BD4160-0x0000000184BD4280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleUidOpNotify Clone() => default; // 0x0000000184BD2FD0-0x0000000184BD30C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleUidOpNotify ShallowCopy() => default; // 0x0000000184BD2700-0x0000000184BD27A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BD1BE0-0x0000000184BD1C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BD3280-0x0000000184BD32D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BD32D0-0x0000000184BD3320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BD1C30-0x0000000184BD1E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BD1F10-0x0000000184BD1FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleUidOpNotify other) => default; // 0x0000000184BD1FE0-0x0000000184BD2240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BD2940-0x0000000184BD2BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BD3B60-0x0000000184BD4160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BD35C0-0x0000000184BD3920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BD2240-0x0000000184BD25E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleUidOpNotify other) {} // 0x0000000184BD1970-0x0000000184BD1BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BD14C0-0x0000000184BD17D0
}

