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

namespace MoleMole.Config
{
	[Serializable]
	public class FaceAnimationItem : ISerializationCallbackReceiver // TypeDefIndex: 19811
	{
		// Fields
		public string name; // 0x10
		public int length; // 0x18
		public float timePerFrame; // 0x1C
		public FaceAnimationFrameBlock[] leftEyeBlocks; // 0x20
		public FaceAnimationFrameBlock[] rightEyeBlocks; // 0x28
		public FaceAnimationFrameBlock[] mouthBlocks; // 0x30
		public FaceAnimationFrameBlock[] attachmentBlocks; // 0x38
		public string message; // 0x40
	
		// Constructors
		public FaceAnimationItem() {} // 0x0000000188D523D0-0x0000000188D52430
	
		// Methods
		// [XID] // 0x00000001896D0920-0x00000001896D0940
		public void OnBeforeSerialize() {} // 0x0000000188D52330-0x0000000188D523D0
		// [XID] // 0x00000001896D7E50-0x00000001896D7E70
		public void OnAfterDeserialize() {} // 0x0000000188D52250-0x0000000188D52330
	}
}
