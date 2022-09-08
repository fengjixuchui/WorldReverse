/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarFaceControl : MonoBehaviour // TypeDefIndex: 19830
	{
		// Fields
		public Renderer faceRenderer; // 0x18
		public FaceTextureItem[] faceTextureItems; // 0x20
		public FaceFrame[] faceFrames; // 0x28
		public int defaultFaceFrameIndex; // 0x30
		private Texture2D _currentTexture; // 0x38
		private int _currentFaceIndex; // 0x40
		public bool useUpdateFaceIndex; // 0x44
		public float targetFaceIndex; // 0x48
	
		// Constructors
		public MonoAvatarFaceControl() {} // 0x000000018421BCD0-0x000000018421BD50
	
		// Methods
		// [XID] // 0x0000000189AC53D0-0x0000000189AC53F0
		private void Start() {} // 0x000000018421BB70-0x000000018421BC10
		// [XID] // 0x0000000189ACC840-0x0000000189ACC860
		private void Update() {} // 0x000000018421BC10-0x000000018421BCD0
		// [XID] // 0x0000000189AD45D0-0x0000000189AD45F0
		public int GetFaceCount() => default; // 0x000000018421B6C0-0x000000018421B770
		// [XID] // 0x0000000189ADBF60-0x0000000189ADBF80
		public bool SetFace(int frameIndex) => default; // 0x000000018421B770-0x000000018421BB70
		// [XID] // 0x0000000189AE3870-0x0000000189AE3890
		private void SetFaceTextureAndUV(Texture2D texture, int row, int index) {} // 0x000000018421B4E0-0x000000018421B6C0
	}
}
