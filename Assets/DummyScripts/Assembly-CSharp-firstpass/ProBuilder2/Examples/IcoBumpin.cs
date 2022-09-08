/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using ProBuilder2.Common;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ProBuilder2.Examples
{
	// [RequireComponent] // 0x0000000189B18950-0x0000000189B189A0
	public class IcoBumpin : MonoBehaviour // TypeDefIndex: 9691
	{
		// Fields
		private pb_Object ico; // 0x18
		private Mesh icoMesh; // 0x20
		private Transform icoTransform; // 0x28
		private AudioSource audioSource; // 0x30
		private FaceRef[] outsides; // 0x38
		private Vector3[] original_vertices; // 0x40
		private Vector3[] displaced_vertices; // 0x48
		// [Range] // 0x0000000189B24730-0x0000000189B24750
		public float icoRadius; // 0x50
		// [Range] // 0x0000000189B2BB80-0x0000000189B2BBA0
		public int icoSubdivisions; // 0x54
		// [Range] // 0x0000000189927470-0x0000000189927490
		public float startingExtrusion; // 0x58
		public UnityEngine.Material material; // 0x60
		// [Range] // 0x0000000189B3ABF0-0x0000000189B3AC10
		public float extrusion; // 0x68
		// [Range] // 0x0000000189B42370-0x0000000189B42390
		public int fftBounds; // 0x6C
		// [Range] // 0x0000000189B49D30-0x0000000189B49D50
		public float verticalBounce; // 0x70
		public AnimationCurve frequencyCurve; // 0x78
		public LineRenderer waveform; // 0x80
		public float waveformHeight; // 0x88
		public float waveformRadius; // 0x8C
		public float waveformSpeed; // 0x90
		public bool rotateWaveformRing; // 0x94
		public bool bounceWaveform; // 0x95
		public GameObject missingClipWarning; // 0x98
		private Vector3 icoPosition; // 0xA0
		private float faces_length; // 0xAC
		private const float TWOPI = 6.283185f; // Metadata: 0x00AE5D43
		private const int WAVEFORM_SAMPLES = 1024; // Metadata: 0x00AE5D47
		private const int FFT_SAMPLES = 4096; // Metadata: 0x00AE5D4B
		private float[] fft; // 0xB0
		private float[] fft_history; // 0xB8
		private float[] data; // 0xC0
		private float[] data_history; // 0xC8
		private float rms; // 0xD0
		private float rms_history; // 0xD4
	
		// Nested types
		private struct FaceRef // TypeDefIndex: 9692
		{
			// Fields
			public pb_Face face; // 0x00
			public Vector3 nrm; // 0x08
			public int[] indices; // 0x18
	
			// Constructors
			public FaceRef(pb_Face f, Vector3 n, int[] i) {
				face = default;
				nrm = default;
				indices = default;
			} // 0x000000018600DE50-0x000000018600DF00
		}
	
		// Constructors
		public IcoBumpin() {} // 0x000000018600FCE0-0x000000018600FE80
	
		// Methods
		// [XID] // 0x0000000189B515C0-0x0000000189B515E0
		private void Start() {} // 0x000000018600EDB0-0x000000018600F3C0
		// [XID] // 0x0000000189B58EC0-0x0000000189B58EE0
		private void Update() {} // 0x000000018600F3C0-0x000000018600FCE0
		// [XID] // 0x0000000189BBA7C0-0x0000000189BBA7E0
		private float RMS(float[] arr) => default; // 0x000000018600EC10-0x000000018600EDB0
	}
}
