/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BeginCameraSceneLookNotify : MessageBase, IMessage<BeginCameraSceneLookNotify> // TypeDefIndex: 25034
{
	// Fields
	private static readonly MessageParser<BeginCameraSceneLookNotify> _parser; // 0x00
	public const int LookPosFieldNumber = 1; // Metadata: 0x00B07D27
	private Vector lookPos_; // 0x18
	public const int DurationFieldNumber = 2; // Metadata: 0x00B07D2B
	private float duration_; // 0x20
	public const int IsForceFieldNumber = 3; // Metadata: 0x00B07D2F
	private bool isForce_; // 0x24
	public const int IsRecoverKeepCurrentFieldNumber = 4; // Metadata: 0x00B07D33
	private bool isRecoverKeepCurrent_; // 0x25
	public const int IsAllowInputFieldNumber = 5; // Metadata: 0x00B07D37
	private bool isAllowInput_; // 0x26
	public const int IsSetFollowPosFieldNumber = 6; // Metadata: 0x00B07D3B
	private bool isSetFollowPos_; // 0x27
	public const int FollowPosFieldNumber = 7; // Metadata: 0x00B07D3F
	private Vector followPos_; // 0x28
	public const int IsForceWalkFieldNumber = 8; // Metadata: 0x00B07D43
	private bool isForceWalk_; // 0x30
	public const int IsChangePlayModeFieldNumber = 9; // Metadata: 0x00B07D47
	private bool isChangePlayMode_; // 0x31
	public const int ScreenXFieldNumber = 10; // Metadata: 0x00B07D4B
	private float screenX_; // 0x34
	public const int ScreenYFieldNumber = 11; // Metadata: 0x00B07D4F
	private float screenY_; // 0x38
	public const int IsSetScreenXYFieldNumber = 12; // Metadata: 0x00B07D53
	private bool isSetScreenXY_; // 0x3C
	public const int OtherParamsFieldNumber = 13; // Metadata: 0x00B07D57
	private static readonly FieldCodec<string> _repeated_otherParams_codec; // 0x08
	private readonly RepeatedPrimitiveField<string> otherParams_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BeginCameraSceneLookNotify> Parser { get => default; } // 0x0000000181E0D480-0x0000000181E0D510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E0CEF0-0x0000000181E0CF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E0C7A0-0x0000000181E0C820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E0B1E0-0x0000000181E0B240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E0DDF0-0x0000000181E0DEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E0D8A0-0x0000000181E0D900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E0D160-0x0000000181E0D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E0DDA0-0x0000000181E0DDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E0C8C0-0x0000000181E0C9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector LookPos { get => default; set {} } // 0x0000000181E0D800-0x0000000181E0D8A0 0x0000000181E0D340-0x0000000181E0D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Duration { get => default; set {} } // 0x0000000181E0DEE0-0x0000000181E0DF80 0x0000000181E0B2E0-0x0000000181E0B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsForce { get => default; set {} } // 0x0000000181E0DD00-0x0000000181E0DDA0 0x0000000181E0B380-0x0000000181E0B420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRecoverKeepCurrent { get => default; set {} } // 0x0000000181E0B850-0x0000000181E0B8F0 0x0000000181E0BDE0-0x0000000181E0BE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAllowInput { get => default; set {} } // 0x0000000181E0CF80-0x0000000181E0D020 0x0000000181E0B8F0-0x0000000181E0B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSetFollowPos { get => default; set {} } // 0x0000000181E0C5C0-0x0000000181E0C660 0x0000000181E0D0C0-0x0000000181E0D160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FollowPos { get => default; set {} } // 0x0000000181E0B240-0x0000000181E0B2E0 0x0000000181E0CE50-0x0000000181E0CEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsForceWalk { get => default; set {} } // 0x0000000181E0D6D0-0x0000000181E0D770 0x0000000181E0C700-0x0000000181E0C7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsChangePlayMode { get => default; set {} } // 0x0000000181E0BA20-0x0000000181E0BAC0 0x0000000181E0B7B0-0x0000000181E0B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ScreenX { get => default; set {} } // 0x0000000181E0C520-0x0000000181E0C5C0 0x0000000181E0D510-0x0000000181E0D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ScreenY { get => default; set {} } // 0x0000000181E0D020-0x0000000181E0D0C0 0x0000000181E0CDB0-0x0000000181E0CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSetScreenXY { get => default; set {} } // 0x0000000181E0C660-0x0000000181E0C700 0x0000000181E0D3E0-0x0000000181E0D480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> OtherParams { get => default; } // 0x0000000181E0BAC0-0x0000000181E0BB20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25035
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25036
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 247
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BeginCameraSceneLookNotify() {} // 0x0000000181E0E830-0x0000000181E0E8C0
	static BeginCameraSceneLookNotify() {} // 0x0000000181E0E750-0x0000000181E0E830

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BeginCameraSceneLookNotify Clone() => default; // 0x0000000181E0D250-0x0000000181E0D340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BeginCameraSceneLookNotify ShallowCopy() => default; // 0x0000000181E0C820-0x0000000181E0C8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E0B990-0x0000000181E0BA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E0D640-0x0000000181E0D6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E0D770-0x0000000181E0D800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E0BB20-0x0000000181E0BDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E0C140-0x0000000181E0C210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BeginCameraSceneLookNotify other) => default; // 0x0000000181E0BE80-0x0000000181E0C140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E0C9B0-0x0000000181E0CDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E0DF80-0x0000000181E0E750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E0D900-0x0000000181E0DD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E0C210-0x0000000181E0C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BeginCameraSceneLookNotify other) {} // 0x0000000181E0B420-0x0000000181E0B7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E0AE90-0x0000000181E0B1E0
}

