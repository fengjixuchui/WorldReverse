/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class WindBoneLOD : MonoBehaviour // TypeDefIndex: 9857
{
	// Fields
	public WindBone[] windBones; // 0x18
	public SpringMagicBone[] springMagicBones; // 0x20
	public QualityLevel qualityLevel; // 0x28
	public bool EnableLinkWindBone; // 0x2C
	public Transform windBoneTrans; // 0x30
	public WindBone mainWindBone; // 0x38

	// Nested types
	public enum QualityLevel // TypeDefIndex: 9858
	{
		None = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		ExtraHigh = 4
	}

	// Constructors
	public WindBoneLOD() {} // 0x0000000189495CE0-0x0000000189495D50

	// Methods
	private void Start() {} // 0x0000000189495890-0x0000000189495950
	private void Update() {} // 0x0000000189495B30-0x0000000189495CE0
	public void LinkWindBone(WindBone from, ref WindBone to) {} // 0x00000001894956E0-0x0000000189495890
	private void UpdateQuality(SpringMagicBone _springMagicBone) {} // 0x0000000189495950-0x0000000189495A40
	private void UpdateQuality(WindBone _windBone) {} // 0x0000000189495A40-0x0000000189495B30
}

