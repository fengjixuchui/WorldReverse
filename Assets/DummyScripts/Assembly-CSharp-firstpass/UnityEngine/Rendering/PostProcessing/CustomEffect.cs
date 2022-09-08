/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	public sealed class CustomEffect // TypeDefIndex: 9480
	{
		// Fields
		// [Tooltip] // 0x00000001896DA4A0-0x00000001896DA4D0
		public bool enable; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.Material _material; // 0x18
		public bool needToUpdate; // 0x30
	
		// Properties
		public UnityEngine.Material material { /* [XID] */ /* 0x000000018969F600-0x000000018969F620 */ get => default; /* [XID] */ /* 0x0000000189BDEA80-0x0000000189BDEAA0 */ set {} } // 0x0000000186059F20-0x0000000186059FC0 0x000000018605A080-0x000000018605A130
		public CameraEvent commandBufferEvent { /* [XID] */ /* 0x000000018970E390-0x000000018970E3D0 */ get; /* [XID] */ /* 0x0000000189718AC0-0x0000000189718B00 */ private set; } // 0x0000000186059E60-0x0000000186059EC0 0x0000000186059FC0-0x000000018605A020
		public CommandBuffer commandBuffer { /* [XID] */ /* 0x0000000189722FB0-0x0000000189722FF0 */ get; /* [XID] */ /* 0x000000018972D630-0x000000018972D670 */ private set; } // 0x0000000186059EC0-0x0000000186059F20 0x000000018605A020-0x000000018605A080
	
		// Constructors
		public CustomEffect() {} // 0x0000000186059DF0-0x0000000186059E60
	
		// Methods
		// [XID] // 0x0000000189738060-0x0000000189738080
		public void Init() {} // 0x0000000186059800-0x0000000186059960
		// [XID] // 0x000000018973FC30-0x000000018973FC50
		internal void Render(PostProcessRenderContext context) {} // 0x0000000186059960-0x0000000186059DF0
	}
}
