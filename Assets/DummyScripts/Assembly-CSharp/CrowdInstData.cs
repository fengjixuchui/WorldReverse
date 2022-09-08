/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CrowdInstData // TypeDefIndex: 20380
{
	// Fields
	public int crowdTypeID; // 0x10
	public int engineRegisterID; // 0x14
	public uint instHandle; // 0x18
	public Vector3 position; // 0x1C
	public Quaternion rotation; // 0x28
	public CrowdAnimSet animConfig; // 0x38
	private GPUAnimInstance _animInstData; // 0x40
	private int _curClipIndex; // 0x48
	private int _curAnimIndex; // 0x4C
	private float _animStartTime; // 0x50
	private float _animPlayTime; // 0x54
	private CrowdAnimClipState _animState; // 0x58
	private bool _needUpdate; // 0x5C
	private Color _hairColor; // 0x60
	private Color _bodyReplaceColor1; // 0x70
	private Color _bodyReplaceColor2; // 0x80
	private Color _bodyReplaceColor3; // 0x90
	private Color _bodyReplaceColor4; // 0xA0
	private MeshFilter _instMeshFilter; // 0xB0
	private MiHoYoLodLoader _instLODLoader; // 0xB8
	private bool _sitOnChair; // 0xC0
	private IChair _occupyChair; // 0xC8
	public int sitListIndex; // 0xD0
	public int sitPointIndex; // 0xD4
	private int desyncAnimIndex; // 0xD8

	// Properties
	public bool sitOnChair { /* [XID] */ /* 0x00000001896D6560-0x00000001896D6580 */ get => default; } // 0x0000000182FC5630-0x0000000182FC56E0 
	public IChair OccupyChair { /* [XID] */ /* 0x00000001896DDC60-0x00000001896DDC80 */ get => default; /* [XID] */ /* 0x00000001896E52B0-0x00000001896E52D0 */ set {} } // 0x0000000182FC4660-0x0000000182FC4710 0x0000000182FC5580-0x0000000182FC5630

	// Constructors
	public CrowdInstData() {} // 0x0000000182FC56E0-0x0000000182FC57F0

	// Methods
	// [XID] // 0x00000001896EC7E0-0x00000001896EC800
	public bool InitCrowdInstData(int crowdTypeID, int engineID, uint instHandle, Vector3 position, Quaternion rotation, bool sitOnChair, CrowdAnimSet animInstConfig, Color hairColor, Color[] bodyColors, int startAnimIndex = -1 /* Metadata: 0x00AFD839 */) => default; // 0x0000000182FC52B0-0x0000000182FC5580
	// [XID] // 0x00000001896F3FC0-0x00000001896F3FE0
	public void SetDesyncAnimIndex(int desyncIndex) {} // 0x0000000182FC4F20-0x0000000182FC4FD0
	// [XID] // 0x00000001896FB890-0x00000001896FB8B0
	private void InitAnimInstData() {} // 0x0000000182FC4220-0x0000000182FC4660
	// [XID] // 0x0000000189702E70-0x0000000189702E90
	public void SetVisible(bool visible) {} // 0x0000000182FC4DB0-0x0000000182FC4E70
	// [XID] // 0x000000018970A520-0x000000018970A540
	private void ClearInstData() {} // 0x0000000182FC4710-0x0000000182FC48A0
	// [XID] // 0x0000000189712030-0x0000000189712050
	public uint GetInstConfigID() => default; // 0x0000000182FC4E70-0x0000000182FC4F20
	// [XID] // 0x00000001897195D0-0x00000001897195F0
	private CrowdAnimClip GetCurrentClip() => default; // 0x0000000182FC4CC0-0x0000000182FC4DB0
	// [XID] // 0x0000000189720B50-0x0000000189720B70
	public GameObject GetCrowdGameObject() => default; // 0x0000000182FC4FD0-0x0000000182FC50C0
	// [XID] // 0x00000001897281B0-0x00000001897281D0
	public void UpdateCrowdInst() {} // 0x0000000182FC3EE0-0x0000000182FC4220
	// [XID] // 0x000000018972F890-0x000000018972F8B0
	public void SetLOD(float[] lodArray) {} // 0x0000000182FC51A0-0x0000000182FC52B0
	// [XID] // 0x00000001897372C0-0x00000001897372E0
	private void StartPlayNewClip(CrowdAnimClip animClip) {} // 0x0000000182FC50C0-0x0000000182FC51A0
	// [XID] // 0x000000018973EDC0-0x000000018973EDE0
	private void PlayCrowdAnimationByIndex(CrowdAnimClip animClip, CrowdAnimClipState animState, bool desyncRandom = false /* Metadata: 0x00AFD83D */) {} // 0x0000000182FC48A0-0x0000000182FC4CC0
}

