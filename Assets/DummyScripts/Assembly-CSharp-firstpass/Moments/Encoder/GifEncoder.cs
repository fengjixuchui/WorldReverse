/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments.Encoder
{
	public class GifEncoder // TypeDefIndex: 7559
	{
		// Fields
		protected int m_Width; // 0x10
		protected int m_Height; // 0x14
		protected int m_Repeat; // 0x18
		protected int m_FrameDelay; // 0x1C
		protected bool m_HasStarted; // 0x20
		protected FileStream m_FileStream; // 0x28
		protected GifFrame m_CurrentFrame; // 0x30
		protected byte[] m_Pixels; // 0x38
		protected byte[] m_IndexedPixels; // 0x40
		protected int m_ColorDepth; // 0x48
		protected byte[] m_ColorTab; // 0x50
		protected bool[] m_UsedEntry; // 0x58
		protected int m_PaletteSize; // 0x60
		protected int m_DisposalCode; // 0x64
		protected bool m_ShouldCloseStream; // 0x68
		protected bool m_IsFirstFrame; // 0x69
		protected bool m_IsSizeSet; // 0x6A
		protected int m_SampleInterval; // 0x6C
	
		// Constructors
		public GifEncoder() {} // 0x000000018607FEF0-0x000000018607FF60
		public GifEncoder(int repeat, int quality) {} // 0x000000018607FDD0-0x000000018607FEF0
	
		// Methods
		// [XID] // 0x0000000189BC52E0-0x0000000189BC5300
		public void SetDelay(int ms) {} // 0x000000018607EE10-0x000000018607EEF0
		// [XID] // 0x0000000189BCCD60-0x0000000189BCCD80
		public void SetFrameRate(float fps) {} // 0x000000018607EEF0-0x000000018607EFE0
		// [XID] // 0x0000000189BD4420-0x0000000189BD4440
		public void AddFrame(GifFrame frame) {} // 0x000000018607E620-0x000000018607E7E0
		// [IDTag] // 0x0000000189BDBD80-0x0000000189BDBDC0
		// [XID] // 0x0000000189BDBD80-0x0000000189BDBDC0
		public void Start(FileStream os) {} // 0x000000018607F1C0-0x000000018607F2E0
		// [IDTag] // 0x00000001895EB810-0x00000001895EB850
		// [XID] // 0x00000001895EB810-0x00000001895EB850
		public void Start(string file) {} // 0x000000018607F0B0-0x000000018607F1C0
		// [XID] // 0x0000000189908F10-0x0000000189908F30
		public void Finish() {} // 0x000000018607EA70-0x000000018607EBE0
		// [XID] // 0x00000001895FD3D0-0x00000001895FD3F0
		protected void SetSize(int w, int h) {} // 0x000000018607EFE0-0x000000018607F0B0
		// [XID] // 0x0000000189604D70-0x0000000189604D90
		protected void GetImagePixels() {} // 0x000000018607EBE0-0x000000018607EE10
		// [XID] // 0x000000018960C520-0x000000018960C540
		protected void AnalyzePixels() {} // 0x000000018607E7E0-0x000000018607EA70
		// [XID] // 0x0000000189613C60-0x0000000189613C80
		protected void WriteGraphicCtrlExt() {} // 0x000000018607F2E0-0x000000018607F4B0
		// [XID] // 0x000000018961B460-0x000000018961B480
		protected void WriteImageDesc() {} // 0x000000018607F4B0-0x000000018607F630
		// [XID] // 0x0000000189622AC0-0x0000000189622AE0
		protected void WriteLSD() {} // 0x000000018607F630-0x000000018607F7A0
		// [XID] // 0x0000000189608C30-0x0000000189608C50
		protected void WriteNetscapeExt() {} // 0x000000018607F7A0-0x000000018607F930
		// [XID] // 0x0000000189631AA0-0x0000000189631AC0
		protected void WritePalette() {} // 0x000000018607F930-0x000000018607FA60
		// [XID] // 0x00000001896176D0-0x00000001896176F0
		protected void WritePixels() {} // 0x000000018607FA60-0x000000018607FB70
		// [XID] // 0x0000000189640AB0-0x0000000189640AD0
		protected void WriteShort(int value) {} // 0x000000018607FB70-0x000000018607FCB0
		// [XID] // 0x0000000189626680-0x00000001896266A0
		protected void WriteString(string s) {} // 0x000000018607FCB0-0x000000018607FDD0
	}
}
