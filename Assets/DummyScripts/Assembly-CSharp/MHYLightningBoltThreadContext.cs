/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using DigitalRuby.ThunderAndLightning;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MHYLightningBoltThreadContext : ILightningBoltThreadContext // TypeDefIndex: 26291
{
	// Fields
	private LightningBoltStateData _threadData; // 0x10

	// Constructors
	public MHYLightningBoltThreadContext() {} // 0x0000000181FBDD90-0x0000000181FBDDF0

	// Methods
	// [XID] // 0x00000001896E3900-0x00000001896E3920
	public static MHYLightningBoltThreadContext Get(LightningBolt blot) => default; // 0x0000000181FBD7E0-0x0000000181FBD900
	// [XID] // 0x00000001896EAD30-0x00000001896EAD50
	public void ForceClear() {} // 0x0000000181FBD6F0-0x0000000181FBD7E0
	// [XID] // 0x00000001896F2100-0x00000001896F2120
	public ThreadCreateRenderState CreateThreadRenderState() => default; // 0x0000000181FBD460-0x0000000181FBD510
	// [XID] // 0x00000001896F9B20-0x00000001896F9B40
	public void ReleaseThreadCreateRenderState(ThreadCreateRenderState state) {} // 0x0000000181FBD900-0x0000000181FBD9D0
	// [XID] // 0x0000000189701370-0x0000000189701390
	public void EnableCurrentLineRendererFromThread(LightningBolt blot) {} // 0x0000000181FBD610-0x0000000181FBD6F0
	// [XID] // 0x0000000189708B00-0x0000000189708B20
	public void EnableAndGetOrCreateLineRenderer(LightningBolt blot, ThreadCreateRenderState state) {} // 0x0000000181FBD510-0x0000000181FBD610
	// [XID] // 0x00000001897103B0-0x00000001897103D0
	public void RenderParticleSystems(LightningBolt blot, Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds) {} // 0x0000000181FBD9D0-0x0000000181FBDBB0
	// [XID] // 0x0000000189717730-0x0000000189717750
	public void StartNotifyBolt(LightningBolt blot, LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end) {} // 0x0000000181FBDBB0-0x0000000181FBDD90
}

