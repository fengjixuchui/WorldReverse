/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class FaceAnimation : IAutoAllocRecycle // TypeDefIndex: 19816
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private Dictionary<string, FaceAnimationFrameInfo> _frameInfoDict; // 0x10
	private FaceAnimationFrameInfo _curFrameInfo; // 0x18
	private float _timer; // 0x20
	private FacePartControl _leftEye; // 0x28
	private FacePartControl _rightEye; // 0x30
	private bool _playing; // 0x38
	private FaceAnimationPlayMode _playMode; // 0x3C
	public Action stopCallBack; // 0x40

	// Properties
	public float timer { /* [XID] */ /* 0x0000000189732880-0x00000001897328A0 */ get => default; } // 0x000000018391E600-0x000000018391E6B0 
	public bool isPlaying { /* [XID] */ /* 0x0000000189739FA0-0x0000000189739FC0 */ get => default; } // 0x000000018391E870-0x000000018391E910 

	// Constructors
	public FaceAnimation() {} // 0x000000018391F860-0x000000018391F8D0

	// Methods
	// [XID] // 0x0000000189741B20-0x0000000189741B40
	public void OnBeforePoolRecycled() {} // 0x000000018391F320-0x000000018391F5D0
	// [XID] // 0x0000000189749420-0x0000000189749440
	public void OnPoolAllocated() {} // 0x000000018391F5D0-0x000000018391F670
	// [XID] // 0x00000001897508E0-0x0000000189750900
	public void Setup(ConfigFaceAnimation config, FacePartControl leftEye, FacePartControl rightEye, IMouthFrameOverrider mouthOverrider = null) {} // 0x000000018391E780-0x000000018391E870
	// [XID] // 0x0000000189B69490-0x0000000189B694B0
	public void PlayFaceAnimation(string name, FaceAnimationPlayMode mode = FaceAnimationPlayMode.Normal /* Metadata: 0x00AFCEF4 */) {} // 0x000000018391F670-0x000000018391F7C0
	// [XID] // 0x000000018975F8B0-0x000000018975F8D0
	public void Stop() {} // 0x000000018391DEE0-0x000000018391DFC0
	// [XID] // 0x0000000189766D60-0x0000000189766D80
	public void PrepareFaceAnmation(string name) {} // 0x000000018391E160-0x000000018391E290
	// [XID] // 0x000000018976E2E0-0x000000018976E300
	public void Process(float dt) {} // 0x000000018391E530-0x000000018391E600
	// [XID] // 0x0000000189775B80-0x0000000189775BA0
	public void SetTime(float time) {} // 0x000000018391EAA0-0x000000018391EB60
	// [XID] // 0x000000018977D320-0x000000018977D340
	public void SetTimePerFrame(float time) {} // 0x000000018391F260-0x000000018391F320
	// [XID] // 0x0000000189784D60-0x0000000189784D80
	private void SetupFace() {} // 0x000000018391EB60-0x000000018391EC80
	// [XID] // 0x000000018978C250-0x000000018978C270
	private void SetFrameFace(int frame) {} // 0x000000018391E910-0x000000018391EAA0
	// [XID] // 0x0000000189793800-0x0000000189793820
	private void NormalizedTimer() {} // 0x000000018391E6B0-0x000000018391E780
	// [XID] // 0x000000018979BA10-0x000000018979BA30
	private void BuildAnimationFrameInfo(ConfigFaceAnimation config) {} // 0x000000018391EC80-0x000000018391F260
	// [XID] // 0x00000001897A2E00-0x00000001897A2E20
	private int[] GetFrameInfoFromBlocks(FaceAnimationFrameBlock[] blocks, int length, string[] names) => default; // 0x000000018391E290-0x000000018391E530
	[BlackList] // 0x00000001897AA480-0x00000001897AA4C0
	// [XID] // 0x00000001897AA480-0x00000001897AA4C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018391DFC0-0x000000018391E090
	[BlackList] // 0x00000001897B56F0-0x00000001897B5730
	// [XID] // 0x00000001897B56F0-0x00000001897B5730
	public virtual void AutoRecycleTypeFields() {} // 0x000000018391E090-0x000000018391E160
	[BlackList] // 0x00000001897C04C0-0x00000001897C0500
	// [XID] // 0x00000001897C04C0-0x00000001897C0500
	public virtual void ReturnToObjectPool() {} // 0x000000018391F7C0-0x000000018391F860
}

