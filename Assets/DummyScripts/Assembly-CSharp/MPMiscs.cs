/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MPMiscs // TypeDefIndex: 21695
{
	// Fields
	private const float ANGLE_RANGE = 3.1415927f; // Metadata: 0x00AFFC3A
	private const float ANGLE_FLOAT_TO_SHORT = 10430.06f; // Metadata: 0x00AFFC3E
	private const float ANGLE_SHORT_TO_FLOAT = 9.587673E-05f; // Metadata: 0x00AFFC42
	private const float VELOCITY_RANGE = 250f; // Metadata: 0x00AFFC46
	private const float VELOCITY_FLOAT_TO_SHORT = 131.068f; // Metadata: 0x00AFFC4A
	private const float VELOCITY_SHORT_TO_FLOAT = 0.0076296274f; // Metadata: 0x00AFFC4E
	private const float NORMALIZED_TIME_RANGE = 1.00001f; // Metadata: 0x00AFFC52
	private const float NORMALIZED_TIME_TO_SHORT = 32766.672f; // Metadata: 0x00AFFC56
	private const float NORMALIXED_SHORT_TO_TIME = 3.0518815E-05f; // Metadata: 0x00AFFC5A
	private const float FIXED_TIME_RANGE = 30f; // Metadata: 0x00AFFC5E
	private const float FIXED_TIME_TO_SHORT = 1092.2333f; // Metadata: 0x00AFFC62
	private const float FIXED_TIME_SHORT_TO_TIME = 0.0009155553f; // Metadata: 0x00AFFC66
	public const float ANGULAR_LERP_RATIO_RANGE = 3.2f; // Metadata: 0x00AFFC6A
	private const float ANGULAR_LERP_RATIO_TO_SBYTE = 39.6875f; // Metadata: 0x00AFFC6E
	private const float ANGULAR_LERP_SBYTE_TO_RATIO = 0.02519685f; // Metadata: 0x00AFFC72
	public static Vector3 UNITINIALIZED; // 0x00

	// Constructors
	static MPMiscs() {} // 0x0000000183A08170-0x0000000183A08210

	// Methods
	// [XID] // 0x0000000189AC78A0-0x0000000189AC78C0
	public static short EncodeAngle(float f) => default; // 0x0000000183A06070-0x0000000183A061F0
	// [XID] // 0x0000000189B189A0-0x0000000189B189C0
	public static float DecodeAngle(short s) => default; // 0x0000000183A07370-0x0000000183A07430
	// [XID] // 0x0000000189971020-0x0000000189971040
	public static short EncodeVelocityMagnitude(float f) => default; // 0x0000000183A07530-0x0000000183A076B0
	// [XID] // 0x0000000189978A30-0x0000000189978A50
	public static float DecodeVelocityMagnitude(short s) => default; // 0x0000000183A061F0-0x0000000183A062B0
	// [XID] // 0x000000018997FAB0-0x000000018997FAD0
	public static short EncodeNormalizedTime(float f) => default; // 0x0000000183A07D30-0x0000000183A07E20
	// [XID] // 0x00000001899873B0-0x00000001899873D0
	public static float DecodeNormalizdedTime(short s) => default; // 0x0000000183A06850-0x0000000183A06910
	// [IDTag] // 0x000000018998EF80-0x000000018998EFC0
	// [XID] // 0x000000018998EF80-0x000000018998EFC0
	public static short EncodeFixedTime(ref AnimatorStateInfo state) => default; // 0x0000000183A06BE0-0x0000000183A06E30
	// [IDTag] // 0x0000000189999D30-0x0000000189999D70
	// [XID] // 0x0000000189999D30-0x0000000189999D70
	public static short EncodeFixedTime(float f) => default; // 0x0000000183A06A30-0x0000000183A06BE0
	// [XID] // 0x00000001899A4510-0x00000001899A4530
	public static float DecodeFixedTime(short s) => default; // 0x0000000183A07BD0-0x0000000183A07C90
	// [XID] // 0x00000001899ABEF0-0x00000001899ABF10
	public static sbyte EncodeAngularLerpRatio(float f) => default; // 0x0000000183A079C0-0x0000000183A07AC0
	// [XID] // 0x00000001899B3760-0x00000001899B3780
	public static float DecodeAngularLerpRatio(sbyte b) => default; // 0x0000000183A070B0-0x0000000183A07170
	// [XID] // 0x00000001899BAB60-0x00000001899BAB80
	public static Vector3 XZAnglesToForward(float angle) => default; // 0x0000000183A06F70-0x0000000183A070B0
	// [XID] // 0x00000001899C2550-0x00000001899C2570
	public static float ForwardToXZAngles(Vector3 forward) => default; // 0x0000000183A07430-0x0000000183A07530
	// [XID] // 0x00000001899C9C40-0x00000001899C9C60
	public static Vector3 XZAnglesCompactToForward(short angle) => default; // 0x0000000183A07170-0x0000000183A07280
	// [XID] // 0x00000001899D14A0-0x00000001899D14C0
	public static short ForwardToXZAnglesCompact(Vector3 forward) => default; // 0x0000000183A07AC0-0x0000000183A07BD0
	// [XID] // 0x00000001899D89B0-0x00000001899D89D0
	public static void EncodeVelocity(Vector3 velocity, out float xzAngle, out float magnitude) {
		xzAngle = default;
		magnitude = default;
	} // 0x0000000183A06E30-0x0000000183A06F70
	// [XID] // 0x00000001899E00C0-0x00000001899E00E0
	public static Vector3 DecodeVelocity(float xzAngle, float magnitude) => default; // 0x0000000183A07840-0x0000000183A079C0
	// [XID] // 0x00000001899E7BC0-0x00000001899E7BE0
	public static void EncodeVelocityCompact(Vector3 velocity, out short xzAngle, out short magnitude) {
		xzAngle = default;
		magnitude = default;
	} // 0x0000000183A08000-0x0000000183A08170
	// [XID] // 0x00000001899EEF50-0x00000001899EEF70
	public static Vector3 DecodeVelocityCompact(short xzAngle, short magnitude) => default; // 0x0000000183A076B0-0x0000000183A07840
	// [XID] // 0x00000001899F69B0-0x00000001899F69D0
	public static float SignedRadianDiff(float from, float to) => default; // 0x0000000183A07F00-0x0000000183A08000
	// [XID] // 0x00000001899FDF20-0x00000001899FDF40
	public static float AbsRadianDiff(float from, float to) => default; // 0x0000000183A06910-0x0000000183A06A30
	// [XID] // 0x0000000189A05890-0x0000000189A058B0
	public static float NormalizedRotateRadian(float from, float to) => default; // 0x0000000183A07280-0x0000000183A07370
	public static T ResolveProtoMessage<T>(ByteString byteData, T message)
		where T : class, IMessage, new() => default;
	public static ByteString MessageToByteStr<T>(T message)
		where T : IMessage => default;
	// [XID] // 0x0000000189A0CB60-0x0000000189A0CB80
	public static bool IsHostPeer() => default; // 0x0000000183A07E20-0x0000000183A07F00
	// [XID] // 0x0000000189A402C0-0x0000000189A402E0
	public static bool IsAbilityEntryHeadValid(AbilityInvokeEntryHead head) => default; // 0x0000000183A07C90-0x0000000183A07D30
	// [XID] // 0x0000000189A1B6B0-0x0000000189A1B6D0
	public static void FillAbilityOverrideMap(OverrideMap overrideMap, RepeatedMessageField<AbilityScalarValueEntry> abilityOveerrideMap) {} // 0x0000000183A062B0-0x0000000183A06850
}

