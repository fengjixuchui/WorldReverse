/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Moments;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

// [AddComponentMenu] // 0x000000018983D2F0-0x000000018983D370
// [RequireComponent] // 0x000000018983D2F0-0x000000018983D370
public class RecordCallBack : MonoBehaviour // TypeDefIndex: 7567
{
	// Fields
	private GIFRecorder m_Recorder; // 0x18
	private float m_Progress; // 0x20
	private string m_LastFile; // 0x28
	private bool m_IsSaving; // 0x30

	// Constructors
	public RecordCallBack() {} // 0x00000001862C9950-0x00000001862C99D0

	// Methods
	private void Start() {} // 0x00000001862C97B0-0x00000001862C9900
	private void OnProcessingDone() {} // 0x00000001862C9750-0x00000001862C97B0
	private void OnFileSaveProgress(int id, float percent) {} // 0x00000001862C93A0-0x00000001862C9410
	private void OnFileSaved(int id, string filepath) {} // 0x00000001862C9410-0x00000001862C9480
	private void OnDestroy() {} // 0x00000001862C9350-0x00000001862C93A0
	private void Update() {} // 0x00000001862C9900-0x00000001862C9950
	private void OnGUI() {} // 0x00000001862C9480-0x00000001862C9750
}

