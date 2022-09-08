/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonoAvatarFaceControlPart : MonoBehaviour // TypeDefIndex: 19831
{
	// Fields
	public Renderer leftEyeRenderer; // 0x18
	public Renderer rightEyeRenderer; // 0x20
	public Renderer mouthRenderer; // 0x28
	public Texture2D[] leftEyeTextures; // 0x30
	public Texture2D[] rightEyeTextures; // 0x38
	public Texture2D[] mouthTextures; // 0x40
	private int _currentLeftEyeIndex; // 0x48
	private int _currentRightEyeIndex; // 0x4C
	private int _currentMouthIndex; // 0x50
	public float targetLeftEyeIndex; // 0x54
	public float targetRightEyeIndex; // 0x58
	public float targetMouthIndex; // 0x5C
	public bool useUpdateTargetIndex; // 0x60

	// Constructors
	public MonoAvatarFaceControlPart() {} // 0x0000000181D80610-0x0000000181D80690

	// Methods
	private void Start() {} // 0x0000000181D80500-0x0000000181D80580
	private void Update() {} // 0x0000000181D80580-0x0000000181D80610
	public void SetLeftEye(int index) {} // 0x0000000181D80350-0x0000000181D803E0
	public void SetRightEye(int index) {} // 0x0000000181D80470-0x0000000181D80500
	public void SetMouth(int index) {} // 0x0000000181D803E0-0x0000000181D80470
	private bool SetFacePart(Renderer renderer, Texture2D[] textures, int targetIndex, ref int currentIndex) => default; // 0x0000000181D80110-0x0000000181D80350
}

