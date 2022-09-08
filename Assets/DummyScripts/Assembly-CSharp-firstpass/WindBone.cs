/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [RequireComponent] // 0x00000001895F5E60-0x00000001895F5EB0
public class WindBone : MonoBehaviour // TypeDefIndex: 9856
{
	// Fields
	// [Header] // 0x0000000189601CD0-0x0000000189601D00
	public Transform controlTarget; // 0x18
	public Vector3 myForward; // 0x20
	// [Header] // 0x000000018960AEF0-0x000000018960AF50
	// [Tooltip] // 0x000000018960AEF0-0x000000018960AF50
	public Vector3 WindDir; // 0x2C
	// [Tooltip] // 0x0000000189618180-0x00000001896181B0
	public float Strength; // 0x38
	// [Header] // 0x00000001896210D0-0x0000000189621100
	public int TimeMin; // 0x3C
	public int TimeMax; // 0x40
	// [Header] // 0x000000018962A1C0-0x000000018962A220
	// [Tooltip] // 0x000000018962A1C0-0x000000018962A220
	public float FreqMin; // 0x44
	// [Tooltip] // 0x0000000189637F40-0x0000000189637F70
	public float FreqMax; // 0x48
	// [Tooltip] // 0x0000000189640970-0x00000001896409A0
	public float AmpMin; // 0x4C
	// [Tooltip] // 0x0000000189649B00-0x0000000189649B30
	public float AmpMax; // 0x50
	private float m_mainFreq; // 0x54
	private float m_mainAmp; // 0x58
	private float m_mainPhi; // 0x5C
	// [Header] // 0x00000001896528E0-0x0000000189652940
	// [Tooltip] // 0x00000001896528E0-0x0000000189652940
	public float HFreqMin; // 0x60
	// [Tooltip] // 0x000000018965FF40-0x000000018965FF70
	public float HFreqMax; // 0x64
	// [Tooltip] // 0x00000001896692B0-0x00000001896692E0
	public float HAmpMin; // 0x68
	// [Tooltip] // 0x00000001896726D0-0x0000000189672700
	public float HAmpMax; // 0x6C
	private float m_sideFreq; // 0x70
	private float m_sideAmp; // 0x74
	private float m_sidePhi; // 0x78
	// [Header] // 0x000000018967B440-0x000000018967B4A0
	// [Tooltip] // 0x000000018967B440-0x000000018967B4A0
	public float SFreqMin; // 0x7C
	// [Tooltip] // 0x0000000189689060-0x0000000189689090
	public float SFreqMax; // 0x80
	// [Tooltip] // 0x0000000189692550-0x0000000189692580
	public float SAmpMin; // 0x84
	// [Tooltip] // 0x000000018969AFC0-0x000000018969AFF0
	public float SAmpMax; // 0x88
	private float m_selfFreq; // 0x8C
	private float m_selfAmp; // 0x90
	private float m_selfPhi; // 0x94
	private int m_counterMain; // 0x98
	private int m_randNumMain; // 0x9C
	private int m_counterSide; // 0xA0
	private int m_randNumSide; // 0xA4
	private int m_counterSelf; // 0xA8
	private int m_randNumSelf; // 0xAC
	// [Header] // 0x00000001896A3DF0-0x00000001896A3E20
	public bool EnableDirctionRestrict; // 0xB0
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public bool UseDirctionRestrict; // 0xB1
	public Vector3 windLocalRestrictDirection; // 0xB4
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public Vector3 windRestrictDirction; // 0xC0
	public float restrictThreshold; // 0xCC
	private Vector3 desForward; // 0xD0
	private Quaternion initRotation; // 0xDC
	public bool m_enable; // 0xEC

	// Properties
	public bool HasDirctionRestrict { get => default; } // 0x0000000189496B90-0x0000000189496D80 

	// Constructors
	public WindBone() {} // 0x0000000189496A20-0x0000000189496B90

	// Methods
	public void Init() {} // 0x0000000189495F10-0x0000000189496050
	public void Enabled() {} // 0x0000000189495DA0-0x0000000189495E00
	public void Disabled() {} // 0x0000000189495D50-0x0000000189495DA0
	public void InitVariables() {} // 0x0000000189495E00-0x0000000189495F10
	public void UpdateWindBone() {} // 0x0000000189496050-0x0000000189496A20
}

