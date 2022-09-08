/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ProCore.Decals;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[ExecuteInEditMode] // 0x00000001897E6780-0x00000001897E6810
// [RequireComponent] // 0x00000001897E6780-0x00000001897E6810
// [RequireComponent] // 0x00000001897E6780-0x00000001897E6810
public class qd_Decal : MonoBehaviour // TypeDefIndex: 9719
{
	// Fields
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public qd_Resources resources; // 0x18
	public DecalType type; // 0x20
	[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
	[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
	private Texture2D _texture; // 0x28
	[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
	[SerializeField] // 0x00000001898EE050-0x00000001898EE080
	private Texture2D _normalTexture; // 0x30
	[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
	[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
	private Rect _rect; // 0x38
	[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
	[SerializeField] // 0x00000001898EE050-0x00000001898EE080
	private float _scale; // 0x48
	[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
	[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
	private Rect _normalRect; // 0x4C
	[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
	[SerializeField] // 0x00000001898EE050-0x00000001898EE080
	private Texture2D _originalTexture; // 0x60

	// Properties
	public Texture2D texture { get => default; } // 0x000000018602EE70-0x000000018602EED0 
	public Texture2D normalTexture { get => default; } // 0x000000018602EDB0-0x000000018602EE10 
	public Texture2D originalTexture { get => default; set {} } // 0x000000018602EE10-0x000000018602EE70 0x000000018602EED0-0x000000018602EF30

	// Constructors
	public qd_Decal() {} // 0x000000018602ED50-0x000000018602EDB0

	// Methods
	private void Awake() {} // 0x000000018602DC90-0x000000018602DCF0
	public void SetScale(float scale) {} // 0x000000018602DF60-0x000000018602DFD0
	public void SetTexture(Texture2D tex, Texture2D normalTex = null) {} // 0x000000018602DFD0-0x000000018602E050
	public void SetUVRect(Rect rect, Rect normalRect) {} // 0x000000018602E050-0x000000018602E670
	public void FreezeTransform() {} // 0x000000018602DCF0-0x000000018602DF60
	public void Verify() {} // 0x000000018602E730-0x000000018602ED50
}

