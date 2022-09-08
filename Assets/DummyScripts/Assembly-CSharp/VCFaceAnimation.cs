/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCFaceAnimation : VCBase // TypeDefIndex: 11860
{
	// Fields
	private FaceAnimation _faceAnimation; // 0x108
	public Renderer leftEyeRenderer; // 0x110
	public Renderer rightEyeRenderer; // 0x118
	private AtlasMatInfoProvider _providerL; // 0x120
	private AtlasMatInfoProvider _providerR; // 0x128
	private ConfigFace _faceConfig; // 0x130
	private EntityTimer _timer; // 0x138
	private bool isInDefault; // 0x140
	private string _baseFaceAnimation; // 0x148
	private string _intervalFaceAnimation; // 0x150
	private uint _initState; // 0x158
	private string _eyeProviderPath; // 0x160

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189825200-0x0000000189825220 */ get => default; } // 0x0000000181E068F0-0x0000000181E06990 

	// Nested types
	private enum InitState // TypeDefIndex: 11861
	{
		None = 0,
		LoadREye = 1,
		LoadLEye = 2,
		AllLoaded = 3
	}

	// Constructors
	public VCFaceAnimation() {} // 0x0000000181E06860-0x0000000181E068F0

	// Methods
	// [XID] // 0x000000018982CBF0-0x000000018982CC10
	public override void Init() {} // 0x0000000181E05C00-0x0000000181E062D0
	// [XID] // 0x0000000189BD5650-0x0000000189BD5670
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181E06620-0x0000000181E06740
	// [XID] // 0x000000018983B6D0-0x000000018983B6F0
	private void DelayInitAnimation(ConfigFaceAnimation faceAnimationConfig) {} // 0x0000000181E05660-0x0000000181E05950
	// [XID] // 0x0000000189843090-0x00000001898430B0
	private void StopAnimation() {} // 0x0000000181E053D0-0x0000000181E05560
	// [XID] // 0x000000018984A2F0-0x000000018984A310
	public void PlayAnimation(string animation) {} // 0x0000000181E06330-0x0000000181E06470
	// [XID] // 0x0000000189851930-0x0000000189851950
	protected override void Tick(float inDeltaTime) {} // 0x0000000181E06740-0x0000000181E06860
	// [XID] // 0x0000000189858FD0-0x0000000189858FF0
	private void UpdateFaceAnimation(float inDeltaTime) {} // 0x0000000181E06470-0x0000000181E06540
	// [XID] // 0x00000001898601D0-0x00000001898601F0
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181E05560-0x0000000181E05660
	// [XID] // 0x0000000189867890-0x00000001898678B0
	public override void Destroy() {} // 0x0000000181E05950-0x0000000181E05B80
}

