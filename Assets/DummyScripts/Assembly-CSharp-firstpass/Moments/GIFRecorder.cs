/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;
using Moments.Encoder;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments
{
	[DisallowMultipleComponent] // 0x00000001896D5D20-0x00000001896D5D80
	// [RequireComponent] // 0x00000001896D5D20-0x00000001896D5D80
	public sealed class GIFRecorder : MonoBehaviour // TypeDefIndex: 7564
	{
		// Fields
		// [Min] // 0x00000001896E4AB0-0x00000001896E4AF0
		[SerializeField] // 0x00000001896E4AB0-0x00000001896E4AF0
		private int m_Width; // 0x18
		// [Min] // 0x00000001896E4AB0-0x00000001896E4AF0
		[SerializeField] // 0x00000001896E4AB0-0x00000001896E4AF0
		private int m_Height; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_AutoAspect; // 0x20
		// [Range] // 0x0000000189700DF0-0x0000000189700E30
		[SerializeField] // 0x0000000189700DF0-0x0000000189700E30
		private int m_FramePerSecond; // 0x24
		// [Min] // 0x000000018970B4D0-0x000000018970B510
		[SerializeField] // 0x000000018970B4D0-0x000000018970B510
		private int m_Repeat; // 0x28
		// [Range] // 0x0000000189A036A0-0x0000000189A036E0
		[SerializeField] // 0x0000000189A036A0-0x0000000189A036E0
		private int m_Quality; // 0x2C
		// [Min] // 0x0000000189720420-0x0000000189720460
		[SerializeField] // 0x0000000189720420-0x0000000189720460
		private float m_BufferSize; // 0x30
		public ThreadPriority WorkerPriority; // 0x40
		public Action OnPreProcessingDone; // 0x48
		public Action<int, float> OnFileSaveProgress; // 0x50
		public Action<int, string> OnFileSaved; // 0x58
		private int m_MaxFrameCount; // 0x60
		private float m_Time; // 0x64
		private float m_TimePerFrame; // 0x68
		private Queue<RenderTexture> m_Frames; // 0x70
		private RenderTexture m_RecycledRenderTexture; // 0x78
		private ReflectionUtils<GIFRecorder> m_ReflectionUtils; // 0x80
	
		// Properties
		public RecorderState State { /* [XID] */ /* 0x000000018973FD80-0x000000018973FDC0 */ get; /* [XID] */ /* 0x000000018974A310-0x000000018974A350 */ private set; } // 0x000000018607E500-0x000000018607E560 0x000000018607E5C0-0x000000018607E620
		public string SaveFolder { /* [XID] */ /* 0x00000001897549D0-0x0000000189754A10 */ get; /* [XID] */ /* 0x000000018975EFB0-0x000000018975EFF0 */ set; } // 0x000000018607E4A0-0x000000018607E500 0x000000018607E560-0x000000018607E5C0
		public float EstimatedMemoryUse { /* [XID] */ /* 0x0000000189910470-0x0000000189910490 */ get => default; } // 0x000000018607E3D0-0x000000018607E4A0 
	
		// Constructors
		public GIFRecorder() {} // 0x000000018607E340-0x000000018607E3D0
	
		// Methods
		// [XID] // 0x00000001899B5B20-0x00000001899B5B40
		public void Setup(bool autoAspect, int width, int height, int fps, float bufferSize, int repeat, int quality) {} // 0x000000018607D930-0x000000018607E110
		// [XID] // 0x00000001899BD300-0x00000001899BD320
		public void Pause() {} // 0x000000018607CF10-0x000000018607D060
		// [XID] // 0x000000018977F840-0x000000018977F860
		public void Record() {} // 0x000000018607D550-0x000000018607D6A0
		// [XID] // 0x00000001897872D0-0x00000001897872F0
		public void FlushMemory() {} // 0x000000018607C540-0x000000018607C790
		// [IDTag] // 0x000000018978E840-0x000000018978E880
		// [XID] // 0x000000018978E840-0x000000018978E880
		public void Save() {} // 0x000000018607D6A0-0x000000018607D750
		// [IDTag] // 0x0000000189798DF0-0x0000000189798E30
		// [XID] // 0x0000000189798DF0-0x0000000189798E30
		public void Save(string filename) {} // 0x000000018607D750-0x000000018607D930
		// [XID] // 0x00000001897A3CD0-0x00000001897A3CF0
		private void Awake() {} // 0x000000018607C1C0-0x000000018607C2E0
		// [XID] // 0x00000001897AB060-0x00000001897AB080
		private void OnDestroy() {} // 0x000000018607CB70-0x000000018607CC10
		// [XID] // 0x00000001897B2F50-0x00000001897B2F70
		private void OnPostRender() {} // 0x000000018607CC10-0x000000018607CF10
		// [XID] // 0x00000001897BAAD0-0x00000001897BAAF0
		private string EditorDataPathToProjectPath(string strPath) => default; // 0x000000018607C400-0x000000018607C540
		// [XID] // 0x00000001897C2780-0x00000001897C27A0
		private void Init() {} // 0x000000018607C990-0x000000018607CB70
		// [XID] // 0x0000000189621010-0x0000000189621030
		public void ComputeHeight() {} // 0x000000018607C2E0-0x000000018607C400
		// [XID] // 0x00000001897D1600-0x00000001897D1620
		private void Flush(UnityEngine.Object obj) {} // 0x000000018607C790-0x000000018607C860
		// [XID] // 0x0000000189A77A40-0x0000000189A77A60
		private string GenerateFileName() => default; // 0x000000018607C860-0x000000018607C990
		[DebuggerHidden] // 0x00000001897E0800-0x00000001897E0840
		// [XID] // 0x00000001897E0800-0x00000001897E0840
		private IEnumerator PreProcess(string filename) => default; // 0x000000018607D430-0x000000018607D550
		// [XID] // 0x00000001897EB090-0x00000001897EB0B0
		private void PreProcessSync(string filename) {} // 0x000000018607D060-0x000000018607D430
		// [XID] // 0x00000001897F2DE0-0x00000001897F2E00
		private GifFrame ToGifFrame(RenderTexture source, Texture2D target) => default; // 0x000000018607E110-0x000000018607E340
	}
}
