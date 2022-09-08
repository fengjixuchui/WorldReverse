/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
public class SECTR_AllBigWorld : MonoBehaviour // TypeDefIndex: 31864
{
	// Fields
	private const string sectorPath = "ART/Stages/BigWorldSECTR/BigWorld_{0}_{1}"; // Metadata: 0x00B13764
	private const string audioPath = "ART/Audio/AudioSECTR/BigWorldAudio_{0}_{1}"; // Metadata: 0x00B13791
	private Vector3 lastPos; // 0x18
	private float updateLen; // 0x24
	private int sectorSize; // 0x28
	private List<string> loadedSectors; // 0x30
	private List<string> newLoadedSectors; // 0x38
	private List<string> loadedAudioSectors; // 0x40
	private List<string> newLoadedAudioSectors; // 0x48
	private List<GameObject> loadedSectorObjs; // 0x50
	private List<GameObject> loadedSectorAudios; // 0x58
	private Dictionary<string, GameObject> cacheObj; // 0x60

	// Constructors
	public SECTR_AllBigWorld() {} // 0x0000000181B55FA0-0x0000000181B56110

	// Methods
	private void Update() {} // 0x0000000181B557C0-0x0000000181B55FA0
}

